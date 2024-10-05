namespace jogo
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.lblquiz = new System.Windows.Forms.Label();
            this.lblpontos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnquiz3 = new System.Windows.Forms.Button();
            this.btnquiz2 = new System.Windows.Forms.Button();
            this.btnquiz1 = new System.Windows.Forms.Button();
            this.btnquiz4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picbquiz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbquiz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblquiz
            // 
            this.lblquiz.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquiz.Location = new System.Drawing.Point(161, 236);
            this.lblquiz.Name = "lblquiz";
            this.lblquiz.Size = new System.Drawing.Size(478, 68);
            this.lblquiz.TabIndex = 20;
            this.lblquiz.Text = "Perguntas";
            this.lblquiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpontos
            // 
            this.lblpontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpontos.Location = new System.Drawing.Point(619, 82);
            this.lblpontos.Name = "lblpontos";
            this.lblpontos.Size = new System.Drawing.Size(169, 23);
            this.lblpontos.TabIndex = 27;
            this.lblpontos.Text = "0 / 10";
            this.lblpontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "Perguntas respondidas\r\ncorretamente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::jogo.Properties.Resources.reciclagemlogo_resized;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnquiz3
            // 
            this.btnquiz3.BackColor = System.Drawing.Color.Transparent;
            this.btnquiz3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquiz3.Image = global::jogo.Properties.Resources.lixeira_resized;
            this.btnquiz3.Location = new System.Drawing.Point(408, 307);
            this.btnquiz3.Name = "btnquiz3";
            this.btnquiz3.Size = new System.Drawing.Size(110, 100);
            this.btnquiz3.TabIndex = 24;
            this.btnquiz3.Tag = "3";
            this.btnquiz3.UseVisualStyleBackColor = false;
            this.btnquiz3.Click += new System.EventHandler(this.eventrespostas);
            // 
            // btnquiz2
            // 
            this.btnquiz2.BackColor = System.Drawing.Color.Transparent;
            this.btnquiz2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquiz2.Image = global::jogo.Properties.Resources.lixeirazul_resized;
            this.btnquiz2.Location = new System.Drawing.Point(282, 307);
            this.btnquiz2.Name = "btnquiz2";
            this.btnquiz2.Size = new System.Drawing.Size(110, 100);
            this.btnquiz2.TabIndex = 23;
            this.btnquiz2.Tag = "2";
            this.btnquiz2.UseVisualStyleBackColor = false;
            this.btnquiz2.Click += new System.EventHandler(this.eventrespostas);
            // 
            // btnquiz1
            // 
            this.btnquiz1.BackColor = System.Drawing.Color.Transparent;
            this.btnquiz1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquiz1.Image = global::jogo.Properties.Resources.lixeiravermelha_resized;
            this.btnquiz1.Location = new System.Drawing.Point(156, 307);
            this.btnquiz1.Name = "btnquiz1";
            this.btnquiz1.Size = new System.Drawing.Size(110, 100);
            this.btnquiz1.TabIndex = 22;
            this.btnquiz1.Tag = "1";
            this.btnquiz1.UseVisualStyleBackColor = false;
            this.btnquiz1.Click += new System.EventHandler(this.eventrespostas);
            // 
            // btnquiz4
            // 
            this.btnquiz4.BackColor = System.Drawing.Color.Transparent;
            this.btnquiz4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquiz4.Image = global::jogo.Properties.Resources.lixeiraamarela_resized;
            this.btnquiz4.Location = new System.Drawing.Point(534, 307);
            this.btnquiz4.Name = "btnquiz4";
            this.btnquiz4.Size = new System.Drawing.Size(110, 100);
            this.btnquiz4.TabIndex = 21;
            this.btnquiz4.Tag = "4";
            this.btnquiz4.UseVisualStyleBackColor = false;
            this.btnquiz4.Click += new System.EventHandler(this.eventrespostas);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::jogo.Properties.Resources.lixoia_resized;
            this.pictureBox2.Location = new System.Drawing.Point(645, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 181);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // picbquiz
            // 
            this.picbquiz.Image = global::jogo.Properties.Resources.caderno_resized;
            this.picbquiz.Location = new System.Drawing.Point(299, 33);
            this.picbquiz.Name = "picbquiz";
            this.picbquiz.Size = new System.Drawing.Size(200, 200);
            this.picbquiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbquiz.TabIndex = 0;
            this.picbquiz.TabStop = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(223)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpontos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnquiz3);
            this.Controls.Add(this.btnquiz2);
            this.Controls.Add(this.btnquiz1);
            this.Controls.Add(this.btnquiz4);
            this.Controls.Add(this.lblquiz);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picbquiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lixo Zero: Aprendendo a Reciclar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbquiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbquiz;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblquiz;
        private System.Windows.Forms.Button btnquiz4;
        private System.Windows.Forms.Button btnquiz1;
        private System.Windows.Forms.Button btnquiz2;
        private System.Windows.Forms.Button btnquiz3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblpontos;
        private System.Windows.Forms.Label label1;
    }
}