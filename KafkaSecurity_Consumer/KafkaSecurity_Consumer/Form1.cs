using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaSecurity_Consumer
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

            message.Enabled = false;
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
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SASLPLAINTEXT")
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
            if (saslAuthentication_cmb.SelectedItem.ToString() == "GSSAPI")
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
                ConsumerConfig conf = GetConfig();

                var isCancelled = false;

                using (var consumer = new ConsumerBuilder<Ignore, string>(conf).Build())
                {
                    consumer.Subscribe(Topic.Text);

                    CancellationTokenSource cts = new CancellationTokenSource();

                    while (!isCancelled)
                    {
                        try
                        {
                            var consumeResult = consumer.Consume(cts.Token);
                            MessageBox.Show(string.Format("\n\n Consumed message : {0} at partition : {1}", consumeResult.Message.Value, consumeResult.TopicPartitionOffset));

                            message.Text = string.Format("{0}", consumeResult.Message.Value);
                        }
                        catch (ConsumeException cEx)
                        {
                            MessageBox.Show(string.Format("Error occured: {0}", cEx.Error.Reason));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(string.Format("Error occured: {0}", ex.Message));
                        }
                    }

                    consumer.Close();
                }

                message.Enabled = true;
                button1.Enabled = true;
                reset.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error occured: {0}", ex.Message));

                button1.Enabled = true;
                reset.Enabled = true;
            }
        }

        private ConsumerConfig GetConfig()
        {
            ConsumerConfig consumerConfig = null;


            if (SecurityProtocol_cmb.SelectedItem.ToString() == "PLAINTEXT")
            {
                consumerConfig = new ConsumerConfig
                {
                    GroupId = ConsumerGroupId.Text,
                    BootstrapServers = BootstrapServer.Text,
                    SecurityProtocol = GetSecurityProtocol(),

                    //Debug="all",
                    // Note: The AutoOffsetReset property determines the start offset in the event
                    // there are not yet any committed offsets for the consumer group for the
                    // topic/partitions of interest. By default, offsets are committed
                    // automatically, so in this example, consumption will only start from the
                    // earliest message in the topic 'my-topic' the first time you run the program.
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };
            }
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SSL")
            {
                consumerConfig = new ConsumerConfig
                {
                    GroupId = ConsumerGroupId.Text,
                    BootstrapServers = BootstrapServer.Text,
                    SecurityProtocol = GetSecurityProtocol(),
                    SslCertificateLocation = sslCALocation.Text,
                    SslCaLocation = sslCALocation.Text,
                    SslKeystoreLocation = sslKeystoreLocation.Text,
                    SslKeystorePassword = sslKeystorePassword.Text,

                    //Debug="all",
                    // Note: The AutoOffsetReset property determines the start offset in the event
                    // there are not yet any committed offsets for the consumer group for the
                    // topic/partitions of interest. By default, offsets are committed
                    // automatically, so in this example, consumption will only start from the
                    // earliest message in the topic 'my-topic' the first time you run the program.
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };
            }
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SASLPLAINTEXT")
            {
                consumerConfig = new ConsumerConfig
                {
                    GroupId = ConsumerGroupId.Text,
                    BootstrapServers = BootstrapServer.Text,
                    SecurityProtocol = GetSecurityProtocol(),
                    SslCertificateLocation = sslCALocation.Text,
                    SslCaLocation = sslCALocation.Text,
                    SslKeystoreLocation = sslKeystoreLocation.Text,
                    SslKeystorePassword = sslKeystorePassword.Text,
                    SaslUsername = username.Text,
                    SaslPassword = password.Text,

                    //Debug="all",
                    // Note: The AutoOffsetReset property determines the start offset in the event
                    // there are not yet any committed offsets for the consumer group for the
                    // topic/partitions of interest. By default, offsets are committed
                    // automatically, so in this example, consumption will only start from the
                    // earliest message in the topic 'my-topic' the first time you run the program.
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };
            }
            else if (SecurityProtocol_cmb.SelectedItem.ToString() == "SASLSSL")
            {
                consumerConfig = new ConsumerConfig
                {
                    GroupId = ConsumerGroupId.Text,
                    BootstrapServers = BootstrapServer.Text,
                    SecurityProtocol = GetSecurityProtocol(),
                    SslCertificateLocation = sslCALocation.Text,
                    SslCaLocation = sslCALocation.Text,
                    SslKeystoreLocation = sslKeystoreLocation.Text,
                    SslKeystorePassword = sslKeystorePassword.Text,
                    SaslUsername = username.Text,
                    SaslPassword = password.Text,

                    //Debug="all",
                    // Note: The AutoOffsetReset property determines the start offset in the event
                    // there are not yet any committed offsets for the consumer group for the
                    // topic/partitions of interest. By default, offsets are committed
                    // automatically, so in this example, consumption will only start from the
                    // earliest message in the topic 'my-topic' the first time you run the program.
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };
            }

            AdditionalConfiguration(ref consumerConfig);

            return consumerConfig;
        }

        private void AdditionalConfiguration(ref ConsumerConfig consumerConfig)
        {
            if (!saslAuthentication_cmb.Enabled)
                return;

            if (saslAuthentication_cmb.SelectedItem.ToString() == "GSSAPI")
            {
                consumerConfig.SaslKerberosPrincipal = principal.Text;
                consumerConfig.SaslKerberosServiceName = service.Text;
                consumerConfig.SaslKerberosKeytab = keytab.Text;
                consumerConfig.SaslMechanism = SaslMechanism.Gssapi;
            }
            else if (saslAuthentication_cmb.SelectedItem.ToString() == "PLAIN")
            {
                consumerConfig.SaslMechanism = SaslMechanism.Plain;
            }
            else if (saslAuthentication_cmb.SelectedItem.ToString() == "SCRAM-SHA-256")
            {
                consumerConfig.SaslMechanism = SaslMechanism.ScramSha256;
            }
            else if (saslAuthentication_cmb.SelectedItem.ToString() == "SCRAM-SHA-512")
            {
                consumerConfig.SaslMechanism = SaslMechanism.ScramSha512;
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

        private void button2_Click(object sender, EventArgs e)
        {
            SecurityProtocol_cmb.SelectedItem = "PLAINTEXT";
            saslAuthentication_cmb.SelectedItem = "GSSAPI";

            BootstrapServer.Text = string.Empty;
            Topic.Text = string.Empty;
            ConsumerGroupId.Text = string.Empty;
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

        private void SecurityProtocol_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibility();
        }

        private void saslAuthentication_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibility();
        }
    }
}
