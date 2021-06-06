namespace KafkaSecurity_Consumer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Topic = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BootstrapServer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.saslGroup = new System.Windows.Forms.GroupBox();
            this.saslAuthentication_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kerberosGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.principal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.TextBox();
            this.keytab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.sslGroup = new System.Windows.Forms.GroupBox();
            this.sslKeystorePassword = new System.Windows.Forms.TextBox();
            this.sslKeystoreLocation = new System.Windows.Forms.TextBox();
            this.sslCertificateLocation = new System.Windows.Forms.TextBox();
            this.sslCALocation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ConsumerGroupId = new System.Windows.Forms.TextBox();
            this.SecurityProtocol_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saslGroup.SuspendLayout();
            this.kerberosGroup.SuspendLayout();
            this.sslGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topic
            // 
            this.Topic.Location = new System.Drawing.Point(164, 72);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(192, 20);
            this.Topic.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(97, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Topic";
            // 
            // BootstrapServer
            // 
            this.BootstrapServer.Location = new System.Drawing.Point(563, 30);
            this.BootstrapServer.Name = "BootstrapServer";
            this.BootstrapServer.Size = new System.Drawing.Size(192, 20);
            this.BootstrapServer.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(435, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Bootstrap Server(s)";
            // 
            // saslGroup
            // 
            this.saslGroup.Controls.Add(this.saslAuthentication_cmb);
            this.saslGroup.Controls.Add(this.label2);
            this.saslGroup.Controls.Add(this.label7);
            this.saslGroup.Controls.Add(this.label6);
            this.saslGroup.Controls.Add(this.kerberosGroup);
            this.saslGroup.Controls.Add(this.username);
            this.saslGroup.Controls.Add(this.password);
            this.saslGroup.Location = new System.Drawing.Point(36, 110);
            this.saslGroup.Name = "saslGroup";
            this.saslGroup.Size = new System.Drawing.Size(728, 160);
            this.saslGroup.TabIndex = 39;
            this.saslGroup.TabStop = false;
            this.saslGroup.Text = "sasl";
            // 
            // saslAuthentication_cmb
            // 
            this.saslAuthentication_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saslAuthentication_cmb.FormattingEnabled = true;
            this.saslAuthentication_cmb.Items.AddRange(new object[] {
            "GSSAPI",
            "PLAIN",
            "SCRAM-SHA-256",
            "SCRAM-SHA-512"});
            this.saslAuthentication_cmb.Location = new System.Drawing.Point(127, 19);
            this.saslAuthentication_cmb.Name = "saslAuthentication_cmb";
            this.saslAuthentication_cmb.Size = new System.Drawing.Size(192, 21);
            this.saslAuthentication_cmb.TabIndex = 28;
            this.saslAuthentication_cmb.SelectedIndexChanged += new System.EventHandler(this.saslAuthentication_cmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sasl Authentication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "UserName";
            // 
            // kerberosGroup
            // 
            this.kerberosGroup.Controls.Add(this.label3);
            this.kerberosGroup.Controls.Add(this.principal);
            this.kerberosGroup.Controls.Add(this.label4);
            this.kerberosGroup.Controls.Add(this.service);
            this.kerberosGroup.Controls.Add(this.keytab);
            this.kerberosGroup.Controls.Add(this.label5);
            this.kerberosGroup.Location = new System.Drawing.Point(3, 90);
            this.kerberosGroup.Name = "kerberosGroup";
            this.kerberosGroup.Size = new System.Drawing.Size(719, 56);
            this.kerberosGroup.TabIndex = 26;
            this.kerberosGroup.TabStop = false;
            this.kerberosGroup.Text = "kerberos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Principal Name";
            // 
            // principal
            // 
            this.principal.Location = new System.Drawing.Point(124, 21);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(118, 20);
            this.principal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Service Name";
            // 
            // service
            // 
            this.service.Location = new System.Drawing.Point(348, 21);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(118, 20);
            this.service.TabIndex = 14;
            // 
            // keytab
            // 
            this.keytab.Location = new System.Drawing.Point(590, 21);
            this.keytab.Name = "keytab";
            this.keytab.Size = new System.Drawing.Size(125, 20);
            this.keytab.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "KeyTab FilePath";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(127, 58);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(192, 20);
            this.username.TabIndex = 16;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(526, 58);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(192, 20);
            this.password.TabIndex = 17;
            // 
            // sslGroup
            // 
            this.sslGroup.Controls.Add(this.sslKeystorePassword);
            this.sslGroup.Controls.Add(this.sslKeystoreLocation);
            this.sslGroup.Controls.Add(this.sslCertificateLocation);
            this.sslGroup.Controls.Add(this.sslCALocation);
            this.sslGroup.Controls.Add(this.label11);
            this.sslGroup.Controls.Add(this.label10);
            this.sslGroup.Controls.Add(this.label9);
            this.sslGroup.Controls.Add(this.label8);
            this.sslGroup.Location = new System.Drawing.Point(36, 278);
            this.sslGroup.Name = "sslGroup";
            this.sslGroup.Size = new System.Drawing.Size(729, 100);
            this.sslGroup.TabIndex = 38;
            this.sslGroup.TabStop = false;
            this.sslGroup.Text = "ssl";
            // 
            // sslKeystorePassword
            // 
            this.sslKeystorePassword.Location = new System.Drawing.Point(527, 65);
            this.sslKeystorePassword.Name = "sslKeystorePassword";
            this.sslKeystorePassword.Size = new System.Drawing.Size(192, 20);
            this.sslKeystorePassword.TabIndex = 29;
            // 
            // sslKeystoreLocation
            // 
            this.sslKeystoreLocation.Location = new System.Drawing.Point(128, 62);
            this.sslKeystoreLocation.Name = "sslKeystoreLocation";
            this.sslKeystoreLocation.Size = new System.Drawing.Size(192, 20);
            this.sslKeystoreLocation.TabIndex = 28;
            // 
            // sslCertificateLocation
            // 
            this.sslCertificateLocation.Location = new System.Drawing.Point(527, 20);
            this.sslCertificateLocation.Name = "sslCertificateLocation";
            this.sslCertificateLocation.Size = new System.Drawing.Size(192, 20);
            this.sslCertificateLocation.TabIndex = 27;
            // 
            // sslCALocation
            // 
            this.sslCALocation.Location = new System.Drawing.Point(128, 16);
            this.sslCALocation.Name = "sslCALocation";
            this.sslCALocation.Size = new System.Drawing.Size(192, 20);
            this.sslCALocation.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "SSLKeyStorePassword";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "SSLKeyStoreLocation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "SSLCertificateLocation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "SSLCALocation";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(164, 390);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(591, 46);
            this.message.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Message";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(388, 453);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(125, 30);
            this.reset.TabIndex = 35;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(229, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Consume Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(429, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Consumer Group Id";
            // 
            // ConsumerGroupId
            // 
            this.ConsumerGroupId.Location = new System.Drawing.Point(563, 72);
            this.ConsumerGroupId.Name = "ConsumerGroupId";
            this.ConsumerGroupId.Size = new System.Drawing.Size(192, 20);
            this.ConsumerGroupId.TabIndex = 45;
            // 
            // SecurityProtocol_cmb
            // 
            this.SecurityProtocol_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityProtocol_cmb.FormattingEnabled = true;
            this.SecurityProtocol_cmb.Items.AddRange(new object[] {
            "PLAINTEXT",
            "SSL",
            "SASLPLAINTEXT",
            "SASLSSL"});
            this.SecurityProtocol_cmb.Location = new System.Drawing.Point(164, 34);
            this.SecurityProtocol_cmb.Name = "SecurityProtocol_cmb";
            this.SecurityProtocol_cmb.Size = new System.Drawing.Size(192, 21);
            this.SecurityProtocol_cmb.TabIndex = 32;
            this.SecurityProtocol_cmb.SelectedIndexChanged += new System.EventHandler(this.SecurityProtocol_cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Security Protocol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.ConsumerGroupId);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BootstrapServer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.saslGroup);
            this.Controls.Add(this.sslGroup);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecurityProtocol_cmb);
            this.Name = "Form1";
            this.Text = "Kafka Consumer";
            this.saslGroup.ResumeLayout(false);
            this.saslGroup.PerformLayout();
            this.kerberosGroup.ResumeLayout(false);
            this.kerberosGroup.PerformLayout();
            this.sslGroup.ResumeLayout(false);
            this.sslGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BootstrapServer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox saslGroup;
        private System.Windows.Forms.ComboBox saslAuthentication_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox kerberosGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox principal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox service;
        private System.Windows.Forms.TextBox keytab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.GroupBox sslGroup;
        private System.Windows.Forms.TextBox sslKeystorePassword;
        private System.Windows.Forms.TextBox sslKeystoreLocation;
        private System.Windows.Forms.TextBox sslCertificateLocation;
        private System.Windows.Forms.TextBox sslCALocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ConsumerGroupId;
        private System.Windows.Forms.ComboBox SecurityProtocol_cmb;
        private System.Windows.Forms.Label label1;
    }
}

