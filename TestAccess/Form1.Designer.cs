namespace DataBasesTest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btConnection = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.btOracleRun = new System.Windows.Forms.Button();
            this.gvOracle = new System.Windows.Forms.DataGridView();
            this.tbSQLOracle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTestConnection = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWorkspace = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbSQLMessages = new System.Windows.Forms.TextBox();
            this.btSQLRun = new System.Windows.Forms.Button();
            this.gvSQLData = new System.Windows.Forms.DataGridView();
            this.tbSQLCommand = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSQLConnect = new System.Windows.Forms.Button();
            this.tbSQLCatalog = new System.Windows.Forms.TextBox();
            this.tbSQLUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSQLServer = new System.Windows.Forms.TextBox();
            this.tbSQLPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSQLInstance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOracle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSQLData)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oracle XE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btConnection);
            this.groupBox2.Controls.Add(this.btClear);
            this.groupBox2.Controls.Add(this.tbMessages);
            this.groupBox2.Controls.Add(this.btOracleRun);
            this.groupBox2.Controls.Add(this.gvOracle);
            this.groupBox2.Controls.Add(this.tbSQLOracle);
            this.groupBox2.Location = new System.Drawing.Point(6, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 376);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btConnection
            // 
            this.btConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConnection.Location = new System.Drawing.Point(844, 142);
            this.btConnection.Name = "btConnection";
            this.btConnection.Size = new System.Drawing.Size(84, 23);
            this.btConnection.TabIndex = 5;
            this.btConnection.Text = "Conexión";
            this.btConnection.UseVisualStyleBackColor = true;
            this.btConnection.Click += new System.EventHandler(this.btConnection_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.Location = new System.Drawing.Point(844, 171);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(84, 23);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Limpiar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbMessages
            // 
            this.tbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessages.Location = new System.Drawing.Point(6, 118);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessages.Size = new System.Drawing.Size(832, 76);
            this.tbMessages.TabIndex = 3;
            // 
            // btOracleRun
            // 
            this.btOracleRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOracleRun.Location = new System.Drawing.Point(844, 89);
            this.btOracleRun.Name = "btOracleRun";
            this.btOracleRun.Size = new System.Drawing.Size(84, 23);
            this.btOracleRun.TabIndex = 2;
            this.btOracleRun.Text = "Ejecutar";
            this.btOracleRun.UseVisualStyleBackColor = true;
            this.btOracleRun.Click += new System.EventHandler(this.btOracleRun_Click);
            // 
            // gvOracle
            // 
            this.gvOracle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvOracle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOracle.Location = new System.Drawing.Point(6, 200);
            this.gvOracle.Name = "gvOracle";
            this.gvOracle.RowTemplate.Height = 24;
            this.gvOracle.Size = new System.Drawing.Size(832, 170);
            this.gvOracle.TabIndex = 1;
            // 
            // tbSQLOracle
            // 
            this.tbSQLOracle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSQLOracle.Location = new System.Drawing.Point(6, 21);
            this.tbSQLOracle.Multiline = true;
            this.tbSQLOracle.Name = "tbSQLOracle";
            this.tbSQLOracle.Size = new System.Drawing.Size(832, 91);
            this.tbSQLOracle.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btTestConnection);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbServer);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbWorkspace);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // btTestConnection
            // 
            this.btTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTestConnection.Location = new System.Drawing.Point(728, 53);
            this.btTestConnection.Name = "btTestConnection";
            this.btTestConnection.Size = new System.Drawing.Size(98, 23);
            this.btTestConnection.TabIndex = 0;
            this.btTestConnection.Text = "Conectar";
            this.btTestConnection.UseVisualStyleBackColor = true;
            this.btTestConnection.Click += new System.EventHandler(this.btTestConnection_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(728, 25);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(98, 22);
            this.tbPort.TabIndex = 10;
            this.tbPort.Text = "1521";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(73, 25);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(98, 22);
            this.tbUser.TabIndex = 2;
            this.tbUser.Text = "Admin";
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puerto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(564, 25);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(98, 22);
            this.tbServer.TabIndex = 8;
            this.tbServer.Text = "localhost";
            this.tbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(256, 25);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(98, 22);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "admin1234";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "SID:";
            // 
            // tbWorkspace
            // 
            this.tbWorkspace.Location = new System.Drawing.Point(400, 25);
            this.tbWorkspace.Name = "tbWorkspace";
            this.tbWorkspace.Size = new System.Drawing.Size(98, 22);
            this.tbWorkspace.TabIndex = 6;
            this.tbWorkspace.Text = "XE";
            this.tbWorkspace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(891, 529);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Cerrar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(946, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL Express";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.tbSQLMessages);
            this.groupBox3.Controls.Add(this.btSQLRun);
            this.groupBox3.Controls.Add(this.gvSQLData);
            this.groupBox3.Controls.Add(this.tbSQLCommand);
            this.groupBox3.Location = new System.Drawing.Point(6, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 376);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(844, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Conexión";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(844, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbSQLMessages
            // 
            this.tbSQLMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSQLMessages.Location = new System.Drawing.Point(6, 118);
            this.tbSQLMessages.Multiline = true;
            this.tbSQLMessages.Name = "tbSQLMessages";
            this.tbSQLMessages.ReadOnly = true;
            this.tbSQLMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSQLMessages.Size = new System.Drawing.Size(832, 76);
            this.tbSQLMessages.TabIndex = 3;
            // 
            // btSQLRun
            // 
            this.btSQLRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSQLRun.Location = new System.Drawing.Point(844, 89);
            this.btSQLRun.Name = "btSQLRun";
            this.btSQLRun.Size = new System.Drawing.Size(84, 23);
            this.btSQLRun.TabIndex = 2;
            this.btSQLRun.Text = "Ejecutar";
            this.btSQLRun.UseVisualStyleBackColor = true;
            this.btSQLRun.Click += new System.EventHandler(this.btSQLRun_Click);
            // 
            // gvSQLData
            // 
            this.gvSQLData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSQLData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSQLData.Location = new System.Drawing.Point(6, 200);
            this.gvSQLData.Name = "gvSQLData";
            this.gvSQLData.RowTemplate.Height = 24;
            this.gvSQLData.Size = new System.Drawing.Size(832, 170);
            this.gvSQLData.TabIndex = 1;
            // 
            // tbSQLCommand
            // 
            this.tbSQLCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSQLCommand.Location = new System.Drawing.Point(6, 21);
            this.tbSQLCommand.Multiline = true;
            this.tbSQLCommand.Name = "tbSQLCommand";
            this.tbSQLCommand.Size = new System.Drawing.Size(832, 91);
            this.tbSQLCommand.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btSQLConnect);
            this.groupBox4.Controls.Add(this.tbSQLCatalog);
            this.groupBox4.Controls.Add(this.tbSQLUser);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbSQLServer);
            this.groupBox4.Controls.Add(this.tbSQLPassword);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbSQLInstance);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(934, 88);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Usuario:";
            // 
            // btSQLConnect
            // 
            this.btSQLConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSQLConnect.Location = new System.Drawing.Point(765, 53);
            this.btSQLConnect.Name = "btSQLConnect";
            this.btSQLConnect.Size = new System.Drawing.Size(98, 23);
            this.btSQLConnect.TabIndex = 0;
            this.btSQLConnect.Text = "Conectar";
            this.btSQLConnect.UseVisualStyleBackColor = true;
            this.btSQLConnect.Click += new System.EventHandler(this.btSQLConnect_Click);
            // 
            // tbSQLCatalog
            // 
            this.tbSQLCatalog.Location = new System.Drawing.Point(765, 25);
            this.tbSQLCatalog.Name = "tbSQLCatalog";
            this.tbSQLCatalog.Size = new System.Drawing.Size(98, 22);
            this.tbSQLCatalog.TabIndex = 10;
            this.tbSQLCatalog.Text = "TestSQLExpress";
            this.tbSQLCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSQLUser
            // 
            this.tbSQLUser.Location = new System.Drawing.Point(73, 25);
            this.tbSQLUser.Name = "tbSQLUser";
            this.tbSQLUser.Size = new System.Drawing.Size(98, 22);
            this.tbSQLUser.TabIndex = 2;
            this.tbSQLUser.Text = "sa";
            this.tbSQLUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(699, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Catalog:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Password:";
            // 
            // tbSQLServer
            // 
            this.tbSQLServer.Location = new System.Drawing.Point(420, 25);
            this.tbSQLServer.Name = "tbSQLServer";
            this.tbSQLServer.Size = new System.Drawing.Size(98, 22);
            this.tbSQLServer.TabIndex = 8;
            this.tbSQLServer.Text = "localhost";
            this.tbSQLServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSQLPassword
            // 
            this.tbSQLPassword.Location = new System.Drawing.Point(256, 25);
            this.tbSQLPassword.Name = "tbSQLPassword";
            this.tbSQLPassword.Size = new System.Drawing.Size(98, 22);
            this.tbSQLPassword.TabIndex = 4;
            this.tbSQLPassword.Text = "admin1234";
            this.tbSQLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Server:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Instance:";
            // 
            // tbSQLInstance
            // 
            this.tbSQLInstance.Location = new System.Drawing.Point(595, 25);
            this.tbSQLInstance.Name = "tbSQLInstance";
            this.tbSQLInstance.Size = new System.Drawing.Size(98, 22);
            this.tbSQLInstance.TabIndex = 6;
            this.tbSQLInstance.Text = "MSSQLSERVER";
            this.tbSQLInstance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 564);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Test Base de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOracle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSQLData)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWorkspace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTestConnection;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOracleRun;
        private System.Windows.Forms.DataGridView gvOracle;
        private System.Windows.Forms.TextBox tbSQLOracle;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btConnection;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbSQLMessages;
        private System.Windows.Forms.Button btSQLRun;
        private System.Windows.Forms.DataGridView gvSQLData;
        private System.Windows.Forms.TextBox tbSQLCommand;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSQLConnect;
        private System.Windows.Forms.TextBox tbSQLCatalog;
        private System.Windows.Forms.TextBox tbSQLUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSQLServer;
        private System.Windows.Forms.TextBox tbSQLPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSQLInstance;
    }
}

