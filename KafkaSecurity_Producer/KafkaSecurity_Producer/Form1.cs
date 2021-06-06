using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaSecurity_Producer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            SecurityProtocol_cmb.SelectedItem = "PLAINTEXT";
            saslAuthentication_cmb.SelectedItem = "GSSAPI";

            UpdateVisibility();

            base.OnLoad(e); 
        }

        private void UpdateVisibility()
        {
            if (SecurityProtocol_cmb.SelectedItem.ToString() == "PLAINTEXT")
            {
                sslGroup.Enabled = false;
                saslGroup.Enabled = false;
            }
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SSL")
            {
                sslGroup.Enabled = true;
                saslGroup.Enabled = false;
            }
            else if(SecurityProtocol_cmb.SelectedItem.ToString() == "SASLPLAINTEXT")
            {
                saslGroup.Enabled = true;
                sslGroup.Enabled = false;

                UpdateSaslVisiblilty();
            }
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SASLSSL")
            {
                saslGroup.Enabled = true;
                sslGroup.Enabled = true;

                UpdateSaslVisiblilty();
            }

        }

        private void UpdateSaslVisiblilty()
        {
            if(saslAuthentication_cmb.SelectedItem.ToString() == "GSSAPI")
            {
                kerberosGroup.Enabled = true;
            }
            else if (saslAuthentication_cmb.SelectedItem.ToString() == "PLAIN")
            {
                kerberosGroup.Enabled = false;
                username.Enabled = true;
                password.Enabled = true;
            }
            else if (saslAuthentication_cmb.SelectedItem.ToString() == "SCRAM-SHA-256" || saslAuthentication_cmb.SelectedItem.ToString() == "SCRAM-SHA-512")
            {
                kerberosGroup.Enabled = false;
                username.Enabled = true;
                password.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                reset.Enabled = false;
                ProducerConfig config = GetConfig();

                Action<DeliveryReport<Null, string>> handler = r =>
                MessageBox.Show(string.Format("\n\n Message delivered successfully to  {0}", r.TopicPartitionOffset));

                using (var producer = new ProducerBuilder<Null, string>(config).Build())
                {
                    try
                    {
                        producer.Produce(Topic.Text, new Message<Null, string> { Value = message.Text }, handler);

                        producer.Flush(TimeSpan.FromSeconds(10));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //MessageBox.Show("Message Produced Successfully !!!");

                message.Text = string.Empty;
                button1.Enabled = true;
                reset.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("\n\n Exception: \n Message: {0} \n\n stacktrace: {1}", ex.Message, ex.StackTrace));

                button1.Enabled = true;
                reset.Enabled = true;

            }

        }

        private ProducerConfig GetConfig()
        {
            ProducerConfig producerConfig = null;

            if (SecurityProtocol_cmb.SelectedItem.ToString() == "PLAINTEXT")
            {
                producerConfig = new ProducerConfig
                {
                    BootstrapServers = BootstrapServer.Text,
                    SecurityProtocol = GetSecurityProtocol()
                };
            }
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SSL")
            {
                producerConfig = new ProducerConfig
                {
                    BootstrapServers = BootstrapServer.Text,
                    SecurityProtocol = GetSecurityProtocol(),
                    SslCertificateLocation = sslCALocation.Text,
                    SslCaLocation = sslCALocation.Text,
                    SslKeystoreLocation = sslKeystoreLocation.Text,
                    SslKeystorePassword = sslKeystorePassword.Text
                };
            }
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SASLPLAINTEXT")
            {
                producerConfig = new ProducerConfig
                {
                    BootstrapServers = BootstrapServer.Text,
                    SecurityProtocol = GetSecurityProtocol(),
                    SslCertificateLocation = sslCALocation.Text,
                    SslCaLocation = sslCALocation.Text,
                    SslKeystoreLocation = sslKeystoreLocation.Text,
                    SslKeystorePassword = sslKeystorePassword.Text,
                    SaslUsername = username.Text,
                    SaslPassword = password.Text
                };
            }
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SASLSSL")
            {
                producerConfig = new ProducerConfig
                {
                    BootstrapServers = BootstrapServer.Text,
                    SecurityProtocol = GetSecurityProtocol(),
                    SslCertificateLocation = sslCALocation.Text,
                    SslCaLocation = sslCALocation.Text,
                    SslKeystoreLocation = sslKeystoreLocation.Text,
                    SslKeystorePassword = sslKeystorePassword.Text,
                    SaslUsername = username.Text,
                    SaslPassword = password.Text
                };
            }

            AdditionalConfiguration(ref producerConfig);

            return producerConfig;

        }

        private void AdditionalConfiguration(ref ProducerConfig producerConfig)
        {
            if (!saslAuthentication_cmb.Enabled)
                return;

            if (saslAuthentication_cmb.SelectedItem.ToString() == "GSSAPI")
            {
                producerConfig.SaslKerberosPrincipal = principal.Text;
                producerConfig.SaslKerberosServiceName = service.Text;
                producerConfig.SaslKerberosKeytab = keytab.Text;
                producerConfig.SaslMechanism = SaslMechanism.Gssapi;
            }
            else if (saslAuthentication_cmb.SelectedItem.ToString() == "PLAIN")
            {
                producerConfig.SaslMechanism = SaslMechanism.Plain;
            }
            else if (saslAuthentication_cmb.SelectedItem.ToString() == "SCRAM-SHA-256")
            {
                producerConfig.SaslMechanism = SaslMechanism.ScramSha256;
            }
            else if (saslAuthentication_cmb.SelectedItem.ToString() == "SCRAM-SHA-512")
            {
                producerConfig.SaslMechanism = SaslMechanism.ScramSha512;
            }
        }

        private SecurityProtocol GetSecurityProtocol()
        {
            if (SecurityProtocol_cmb.SelectedItem.ToString() == "PLAINTEXT")
                return SecurityProtocol.Plaintext;
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SSL")
                return SecurityProtocol.Ssl;
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SASLPLAINTEXT")
                return SecurityProtocol.SaslPlaintext;
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SASLSSL")
                return SecurityProtocol.SaslSsl;
            else
                return SecurityProtocol.Plaintext;
        }

        private void SecurityProtocol_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibility();

        }

        private void saslAuthentication_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibility();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecurityProtocol_cmb.SelectedItem = "PLAINTEXT";
            saslAuthentication_cmb.SelectedItem = "GSSAPI";

            BootstrapServer.Text = string.Empty;
            Topic.Text = string.Empty;
            username.Text = string.Empty;
            password.Text = string.Empty;
            principal.Text = string.Empty;
            service.Text = string.Empty;
            keytab.Text = string.Empty;
            sslCALocation.Text = string.Empty;
            sslCertificateLocation.Text = string.Empty;
            sslKeystoreLocation.Text = string.Empty;
            sslKeystorePassword.Text = string.Empty;
            message.Text = string.Empty;

        }
    }
}
