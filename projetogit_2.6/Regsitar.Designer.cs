namespace projetogit_2._6
{
    partial class Regsitar
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
            this.btnEscolherFoto = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_adiconarconta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox_utilizador = new System.Windows.Forms.TextBox();
            this.textBox_passe = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_esconder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscolherFoto
            // 
            this.btnEscolherFoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEscolherFoto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherFoto.Location = new System.Drawing.Point(312, 127);
            this.btnEscolherFoto.Name = "btnEscolherFoto";
            this.btnEscolherFoto.Size = new System.Drawing.Size(162, 43);
            this.btnEscolherFoto.TabIndex = 6;
            this.btnEscolherFoto.Text = "Escolher Imagem";
            this.btnEscolherFoto.UseVisualStyleBackColor = false;
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_voltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(12, 12);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(49, 49);
            this.button_voltar.TabIndex = 7;
            this.button_voltar.Text = "⬅️";
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_adiconarconta
            // 
            this.button_adiconarconta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_adiconarconta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adiconarconta.Location = new System.Drawing.Point(229, 604);
            this.button_adiconarconta.Name = "button_adiconarconta";
            this.button_adiconarconta.Size = new System.Drawing.Size(182, 42);
            this.button_adiconarconta.TabIndex = 8;
            this.button_adiconarconta.Text = " Registar Conta";
            this.button_adiconarconta.UseVisualStyleBackColor = false;
            this.button_adiconarconta.Click += new System.EventHandler(this.button_adiconarconta_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(177, 246);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 18);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "👤 Nome de Utilizador *";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(177, 314);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 18);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "🔒 Palavra-Passe";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(177, 450);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(297, 18);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "🗓️ Data de Nascimento";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(177, 382);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(297, 18);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "👤 Nome Real *";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox_utilizador
            // 
            this.textBox_utilizador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_utilizador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_utilizador.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_utilizador.Location = new System.Drawing.Point(177, 270);
            this.textBox_utilizador.Multiline = true;
            this.textBox_utilizador.Name = "textBox_utilizador";
            this.textBox_utilizador.Size = new System.Drawing.Size(286, 38);
            this.textBox_utilizador.TabIndex = 15;
            // 
            // textBox_passe
            // 
            this.textBox_passe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_passe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_passe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passe.Location = new System.Drawing.Point(177, 338);
            this.textBox_passe.Multiline = true;
            this.textBox_passe.Name = "textBox_passe";
            this.textBox_passe.Size = new System.Drawing.Size(286, 38);
            this.textBox_passe.TabIndex = 16;
            this.textBox_passe.TextChanged += new System.EventHandler(this.textBox_passe_TextChanged);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Nome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nome.Location = new System.Drawing.Point(177, 406);
            this.textBox_Nome.Multiline = true;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(286, 38);
            this.textBox_Nome.TabIndex = 17;
            // 
            // textBox_Data
            // 
            this.textBox_Data.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Data.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Data.Location = new System.Drawing.Point(177, 474);
            this.textBox_Data.Multiline = true;
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(286, 38);
            this.textBox_Data.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::projetogit_2._6.Properties.Resources._3da39_no_user_image_icon_27;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(154, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 143);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button_esconder
            // 
            this.button_esconder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_esconder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_esconder.Location = new System.Drawing.Point(414, 338);
            this.button_esconder.Name = "button_esconder";
            this.button_esconder.Size = new System.Drawing.Size(49, 38);
            this.button_esconder.TabIndex = 20;
            this.button_esconder.Text = "👁️";
            this.button_esconder.UseVisualStyleBackColor = false;
            this.button_esconder.Click += new System.EventHandler(this.button_esconder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Regsitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 744);
            this.Controls.Add(this.button_esconder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.textBox_passe);
            this.Controls.Add(this.textBox_utilizador);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_adiconarconta);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.btnEscolherFoto);
            this.Name = "Regsitar";
            this.Text = "Regsitar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolherFoto;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_adiconarconta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox_utilizador;
        private System.Windows.Forms.TextBox textBox_passe;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_esconder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}