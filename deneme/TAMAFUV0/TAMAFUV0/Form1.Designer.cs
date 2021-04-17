namespace TAMAFUV0
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.fotoUrltxt = new System.Windows.Forms.TextBox();
            this.fotoPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnyukle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fotoUrltxt
            // 
            this.fotoUrltxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.fotoUrltxt.Location = new System.Drawing.Point(0, 0);
            this.fotoUrltxt.Name = "fotoUrltxt";
            this.fotoUrltxt.Size = new System.Drawing.Size(800, 22);
            this.fotoUrltxt.TabIndex = 0;
            // 
            // fotoPic
            // 
            this.fotoPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fotoPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fotoPic.Location = new System.Drawing.Point(0, 22);
            this.fotoPic.Name = "fotoPic";
            this.fotoPic.Size = new System.Drawing.Size(800, 428);
            this.fotoPic.TabIndex = 1;
            this.fotoPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnyukle);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(395, 46);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Foto Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnyukle
            // 
            this.btnyukle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnyukle.Location = new System.Drawing.Point(401, 0);
            this.btnyukle.Name = "btnyukle";
            this.btnyukle.Size = new System.Drawing.Size(399, 46);
            this.btnyukle.TabIndex = 1;
            this.btnyukle.Text = "Foto Yükle";
            this.btnyukle.UseVisualStyleBackColor = true;
            this.btnyukle.Click += new System.EventHandler(this.btnyukle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fotoPic);
            this.Controls.Add(this.fotoUrltxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fotoUrltxt;
        private System.Windows.Forms.PictureBox fotoPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnyukle;
        private System.Windows.Forms.Button btnKaydet;
    }
}

