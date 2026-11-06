namespace projetogit_2._6
{
    partial class iniciarsessao
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_esconder = new System.Windows.Forms.Button();
            this.textBox_passe = new System.Windows.Forms.TextBox();
            this.textBox_utilizador = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_iniciarsessao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::projetogit_2._6.Properties.Resources.transferir;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(115, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 192);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(193, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 31);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Iniciar Sessâo";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_esconder
            // 
            this.button_esconder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_esconder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_esconder.Location = new System.Drawing.Point(420, 411);
            this.button_esconder.Name = "button_esconder";
            this.button_esconder.Size = new System.Drawing.Size(49, 38);
            this.button_esconder.TabIndex = 30;
            this.button_esconder.Text = "👁️";
            this.button_esconder.UseVisualStyleBackColor = false;
            // 
            // textBox_passe
            // 
            this.textBox_passe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_passe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_passe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passe.Location = new System.Drawing.Point(183, 411);
            this.textBox_passe.Multiline = true;
            this.textBox_passe.Name = "textBox_passe";
            this.textBox_passe.Size = new System.Drawing.Size(286, 38);
            this.textBox_passe.TabIndex = 28;
            // 
            // textBox_utilizador
            // 
            this.textBox_utilizador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_utilizador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_utilizador.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_utilizador.Location = new System.Drawing.Point(183, 322);
            this.textBox_utilizador.Multiline = true;
            this.textBox_utilizador.Name = "textBox_utilizador";
            this.textBox_utilizador.Size = new System.Drawing.Size(286, 38);
            this.textBox_utilizador.TabIndex = 27;
            this.textBox_utilizador.TextChanged += new System.EventHandler(this.textBox_utilizador_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(183, 387);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 18);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "🔒 Palavra-Passe";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(183, 298);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 18);
            this.textBox3.TabIndex = 23;
            this.textBox3.Text = "👤 Nome de Utilizador *";
            // 
            // button_iniciarsessao
            // 
            this.button_iniciarsessao.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_iniciarsessao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciarsessao.Location = new System.Drawing.Point(212, 495);
            this.button_iniciarsessao.Name = "button_iniciarsessao";
            this.button_iniciarsessao.Size = new System.Drawing.Size(210, 58);
            this.button_iniciarsessao.TabIndex = 22;
            this.button_iniciarsessao.Text = "Iniciar Sessâo";
            this.button_iniciarsessao.UseVisualStyleBackColor = false;
            // 
            // iniciarsessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 744);
            this.Controls.Add(this.button_esconder);
            this.Controls.Add(this.textBox_passe);
            this.Controls.Add(this.textBox_utilizador);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_iniciarsessao);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "iniciarsessao";
            this.Text = "iniciarsessao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_esconder;
        private System.Windows.Forms.TextBox textBox_passe;
        private System.Windows.Forms.TextBox textBox_utilizador;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_iniciarsessao;
    }
}