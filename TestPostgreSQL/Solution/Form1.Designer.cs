namespace TestPostgreSQL
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
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.btImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pxImage
            // 
            this.pxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxImage.Location = new System.Drawing.Point(470, 12);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(300, 300);
            this.pxImage.TabIndex = 0;
            this.pxImage.TabStop = false;
            // 
            // btImage
            // 
            this.btImage.Location = new System.Drawing.Point(186, 141);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(93, 23);
            this.btImage.TabIndex = 1;
            this.btImage.Text = "Examinar...";
            this.btImage.UseVisualStyleBackColor = true;
            this.btImage.Click += new System.EventHandler(this.btImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 188);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(199, 22);
            this.tbName.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(186, 216);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(93, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 170);
            this.dataGridView1.TabIndex = 8;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(352, 216);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(28, 17);
            this.lbSize.TabIndex = 9;
            this.lbSize.Text = "----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btImage);
            this.Controls.Add(this.pxImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxImage;
        private System.Windows.Forms.Button btImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSize;
    }
}

