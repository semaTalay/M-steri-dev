namespace MüsteriÖdev
{
    partial class Form2
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
            btnListeyeGeriDön = new Button();
            btnKaydet = new Button();
            txtAdres = new TextBox();
            nudYas = new NumericUpDown();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            SuspendLayout();
            // 
            // btnListeyeGeriDön
            // 
            btnListeyeGeriDön.Location = new Point(196, 349);
            btnListeyeGeriDön.Name = "btnListeyeGeriDön";
            btnListeyeGeriDön.Size = new Size(130, 49);
            btnListeyeGeriDön.TabIndex = 18;
            btnListeyeGeriDön.Text = "Listeye Geri Dön";
            btnListeyeGeriDön.UseVisualStyleBackColor = true;
            btnListeyeGeriDön.Click += btnListeyeGeriDön_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(196, 289);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(130, 44);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(196, 169);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(130, 84);
            txtAdres.TabIndex = 16;
            // 
            // nudYas
            // 
            nudYas.Location = new Point(206, 120);
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(120, 23);
            nudYas.TabIndex = 15;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(206, 73);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 13;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(206, 21);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 187);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 12;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 128);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 11;
            label3.Text = "Yaş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 76);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 10;
            label2.Text = "Telefon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 29);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 9;
            label1.Text = "Ad Soyad";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 444);
            Controls.Add(btnListeyeGeriDön);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(nudYas);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListeyeGeriDön;
        private Button btnKaydet;
        private TextBox txtAdres;
        private NumericUpDown nudYas;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}