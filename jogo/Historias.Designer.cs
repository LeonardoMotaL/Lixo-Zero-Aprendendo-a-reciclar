namespace jogo
{
    partial class Historias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historias));
            this.lbldescricao = new System.Windows.Forms.Label();
            this.labelpags = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnprox = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.picbimagens = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbimagens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldescricao
            // 
            this.lbldescricao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(128, 9);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(544, 94);
            this.lbldescricao.TabIndex = 1;
            this.lbldescricao.Text = "Descrição";
            this.lbldescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelpags
            // 
            this.labelpags.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpags.Location = new System.Drawing.Point(170, 417);
            this.labelpags.Name = "labelpags";
            this.labelpags.Size = new System.Drawing.Size(460, 20);
            this.labelpags.TabIndex = 32;
            this.labelpags.Text = "páginas";
            this.labelpags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::jogo.Properties.Resources.placareciclagem;
            this.pictureBox2.Location = new System.Drawing.Point(723, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 115);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::jogo.Properties.Resources.reciclagemlogo_resized;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnprox
            // 
            this.btnprox.BackColor = System.Drawing.Color.Transparent;
            this.btnprox.FlatAppearance.BorderSize = 0;
            this.btnprox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprox.Image = global::jogo.Properties.Resources.btnprox;
            this.btnprox.Location = new System.Drawing.Point(636, 202);
            this.btnprox.Name = "btnprox";
            this.btnprox.Size = new System.Drawing.Size(75, 100);
            this.btnprox.TabIndex = 3;
            this.btnprox.UseVisualStyleBackColor = false;
            this.btnprox.Click += new System.EventHandler(this.ProximaPag);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnvoltar.FlatAppearance.BorderSize = 0;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Image = global::jogo.Properties.Resources.btnvoltar;
            this.btnvoltar.Location = new System.Drawing.Point(89, 202);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 100);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.VoltarPag);
            // 
            // picbimagens
            // 
            this.picbimagens.Image = global::jogo.Properties.Resources.PLASTICO_FINAL;
            this.picbimagens.Location = new System.Drawing.Point(170, 106);
            this.picbimagens.Name = "picbimagens";
            this.picbimagens.Size = new System.Drawing.Size(460, 293);
            this.picbimagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbimagens.TabIndex = 0;
            this.picbimagens.TabStop = false;
            // 
            // Historias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(223)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelpags);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnprox);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.picbimagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Historias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lixo Zero: Aprendendo a Reciclar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbimagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbimagens;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnprox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelpags;
    }
}