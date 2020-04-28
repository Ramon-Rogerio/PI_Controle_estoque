namespace Projeto1
{
    partial class frmcadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomedaempresa = new System.Windows.Forms.TextBox();
            this.txtsenhacadastro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrepetir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnVol = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 75);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "CADASTRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME DE USUÁRIO:";
            // 
            // txtnomedaempresa
            // 
            this.txtnomedaempresa.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomedaempresa.Location = new System.Drawing.Point(15, 139);
            this.txtnomedaempresa.Name = "txtnomedaempresa";
            this.txtnomedaempresa.Size = new System.Drawing.Size(242, 26);
            this.txtnomedaempresa.TabIndex = 7;
            // 
            // txtsenhacadastro
            // 
            this.txtsenhacadastro.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenhacadastro.Location = new System.Drawing.Point(15, 199);
            this.txtsenhacadastro.Name = "txtsenhacadastro";
            this.txtsenhacadastro.PasswordChar = '*';
            this.txtsenhacadastro.Size = new System.Drawing.Size(242, 26);
            this.txtsenhacadastro.TabIndex = 9;
            this.txtsenhacadastro.TextChanged += new System.EventHandler(this.txtsenhacadastro_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "SENHA:";
            // 
            // txtrepetir
            // 
            this.txtrepetir.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepetir.Location = new System.Drawing.Point(15, 260);
            this.txtrepetir.Name = "txtrepetir";
            this.txtrepetir.PasswordChar = '*';
            this.txtrepetir.Size = new System.Drawing.Size(242, 26);
            this.txtrepetir.TabIndex = 11;
            this.txtrepetir.TextChanged += new System.EventHandler(this.txtrepetir_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "REPETIR SENHA:";
            // 
            // btncadastrar
            // 
            this.btncadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btncadastrar.BackColor = System.Drawing.Color.White;
            this.btncadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadastrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncadastrar.FlatAppearance.BorderSize = 0;
            this.btncadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btncadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.Color.Black;
            this.btncadastrar.Location = new System.Drawing.Point(12, 304);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(118, 37);
            this.btncadastrar.TabIndex = 12;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnlimpar.BackColor = System.Drawing.Color.White;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnlimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpar.Location = new System.Drawing.Point(136, 304);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(121, 37);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnVol
            // 
            this.btnVol.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnVol.BackColor = System.Drawing.Color.White;
            this.btnVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVol.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVol.FlatAppearance.BorderSize = 0;
            this.btnVol.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnVol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVol.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVol.ForeColor = System.Drawing.Color.Black;
            this.btnVol.Location = new System.Drawing.Point(68, 347);
            this.btnVol.Name = "btnVol";
            this.btnVol.Size = new System.Drawing.Size(121, 37);
            this.btnVol.TabIndex = 14;
            this.btnVol.Text = "Voltar";
            this.btnVol.UseVisualStyleBackColor = false;
            this.btnVol.Click += new System.EventHandler(this.btnVol_Click);
            // 
            // frmcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(269, 392);
            this.Controls.Add(this.btnVol);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtrepetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsenhacadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnomedaempresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmcadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmcadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomedaempresa;
        private System.Windows.Forms.TextBox txtsenhacadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrepetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnVol;
    }
}