namespace KargoTakipProjesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Kargolistele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kargoekleme = new System.Windows.Forms.Button();
            this.kargomnerde = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kargolistele
            // 
            this.Kargolistele.BackColor = System.Drawing.Color.Transparent;
            this.Kargolistele.ImageIndex = 0;
            this.Kargolistele.ImageList = this.ımageList1;
            this.Kargolistele.Location = new System.Drawing.Point(57, 12);
            this.Kargolistele.Name = "Kargolistele";
            this.Kargolistele.Size = new System.Drawing.Size(119, 82);
            this.Kargolistele.TabIndex = 0;
            this.Kargolistele.Text = "Kargo Listele";
            this.Kargolistele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Kargolistele.UseVisualStyleBackColor = false;
            this.Kargolistele.Click += new System.EventHandler(this.Kargolistele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kargo.png");
            this.ımageList1.Images.SetKeyName(1, "314-3146431_cardboard-box-icon-box-vector-png.png");
            this.ımageList1.Images.SetKeyName(2, "—Pngtree—red gradient maps landmark icon_5591445.png");
            this.ımageList1.Images.SetKeyName(3, "—Pngtree—vector cartoon deduction landmark_4661601.png");
            this.ımageList1.Images.SetKeyName(4, "box_PNG49.png");
            this.ımageList1.Images.SetKeyName(5, "delivery-truck-1523003-1289689.png");
            this.ımageList1.Images.SetKeyName(6, "logo-exit-png-5-Transparent-Images-Free.png");
            this.ımageList1.Images.SetKeyName(7, "7-79819_search-icon-png-orange-clipart.png");
            // 
            // kargoekleme
            // 
            this.kargoekleme.AutoSize = true;
            this.kargoekleme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kargoekleme.ImageKey = "box_PNG49.png";
            this.kargoekleme.ImageList = this.ımageList1;
            this.kargoekleme.Location = new System.Drawing.Point(306, 12);
            this.kargoekleme.Name = "kargoekleme";
            this.kargoekleme.Size = new System.Drawing.Size(119, 82);
            this.kargoekleme.TabIndex = 1;
            this.kargoekleme.Text = "Kargo Ekleme";
            this.kargoekleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kargoekleme.UseVisualStyleBackColor = false;
            this.kargoekleme.Click += new System.EventHandler(this.kargoekleme_Click);
            // 
            // kargomnerde
            // 
            this.kargomnerde.ImageKey = "—Pngtree—red gradient maps landmark icon_5591445.png";
            this.kargomnerde.ImageList = this.ımageList1;
            this.kargomnerde.Location = new System.Drawing.Point(548, 12);
            this.kargomnerde.Name = "kargomnerde";
            this.kargomnerde.Size = new System.Drawing.Size(119, 82);
            this.kargomnerde.TabIndex = 2;
            this.kargomnerde.Text = "Kargom Nerde?";
            this.kargomnerde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kargomnerde.UseVisualStyleBackColor = true;
            this.kargomnerde.Click += new System.EventHandler(this.kargomnerde_Click);
            // 
            // cikis
            // 
            this.cikis.ImageKey = "logo-exit-png-5-Transparent-Images-Free.png";
            this.cikis.ImageList = this.ımageList1;
            this.cikis.Location = new System.Drawing.Point(769, 12);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(119, 82);
            this.cikis.TabIndex = 3;
            this.cikis.Text = "Çıkış";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(317, 130);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(350, 20);
            this.txtara.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Takip Numarası";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kargo Türü";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(348, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gönderici Firma";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(348, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gönderen Adı";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(578, 257);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kargo Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Teslim Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gönderim Tarihi";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(578, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Alıcı Adı";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(578, 209);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(578, 235);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 22;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 328);
            this.dataGridView1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(57, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 328);
            this.panel1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1019, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kargomnerde);
            this.Controls.Add(this.kargoekleme);
            this.Controls.Add(this.Kargolistele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kargolistele;
        private System.Windows.Forms.Button kargoekleme;
        private System.Windows.Forms.Button kargomnerde;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

