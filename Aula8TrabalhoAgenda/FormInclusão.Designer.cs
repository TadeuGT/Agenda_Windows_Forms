namespace Aula8TrabalhoAgenda {
    partial class FormInclusão {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.buttonAdicionarContato = new System.Windows.Forms.Button();
            this.buttonCancelarContato = new System.Windows.Forms.Button();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNome.Location = new System.Drawing.Point(118, 57);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(340, 35);
            this.textNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Bodo Amat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(118, 31);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(72, 23);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelTelefone
            // 
            this.labelTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Bodo Amat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefone.Location = new System.Drawing.Point(118, 117);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(105, 23);
            this.labelTelefone.TabIndex = 3;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Bodo Amat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(118, 209);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(77, 23);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "E-mail";
            // 
            // textEmail
            // 
            this.textEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEmail.Location = new System.Drawing.Point(118, 235);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(340, 35);
            this.textEmail.TabIndex = 2;
            // 
            // buttonAdicionarContato
            // 
            this.buttonAdicionarContato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarContato.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAdicionarContato.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdicionarContato.FlatAppearance.BorderSize = 2;
            this.buttonAdicionarContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdicionarContato.Font = new System.Drawing.Font("Soda Land", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdicionarContato.Location = new System.Drawing.Point(118, 285);
            this.buttonAdicionarContato.Name = "buttonAdicionarContato";
            this.buttonAdicionarContato.Size = new System.Drawing.Size(122, 56);
            this.buttonAdicionarContato.TabIndex = 6;
            this.buttonAdicionarContato.Text = "Adicionar";
            this.buttonAdicionarContato.UseVisualStyleBackColor = false;
            this.buttonAdicionarContato.Click += new System.EventHandler(this.buttonAdicionarContato_Click);
            // 
            // buttonCancelarContato
            // 
            this.buttonCancelarContato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelarContato.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCancelarContato.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelarContato.FlatAppearance.BorderSize = 2;
            this.buttonCancelarContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelarContato.Font = new System.Drawing.Font("Soda Land", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelarContato.Location = new System.Drawing.Point(336, 285);
            this.buttonCancelarContato.Name = "buttonCancelarContato";
            this.buttonCancelarContato.Size = new System.Drawing.Size(122, 56);
            this.buttonCancelarContato.TabIndex = 7;
            this.buttonCancelarContato.Text = "Cancelar";
            this.buttonCancelarContato.UseVisualStyleBackColor = false;
            this.buttonCancelarContato.Click += new System.EventHandler(this.buttonCancelarContato_Click);
            // 
            // textTelefone
            // 
            this.textTelefone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTelefone.Location = new System.Drawing.Point(118, 143);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(340, 35);
            this.textTelefone.TabIndex = 1;
            this.textTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textData_MaskInputRejected);
            // 
            // FormInclusão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.buttonCancelarContato);
            this.Controls.Add(this.buttonAdicionarContato);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textNome);
            this.Name = "FormInclusão";
            this.Text = "FormInclusão";
            this.Load += new System.EventHandler(this.FormInclusão_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button buttonAdicionarContato;
        private System.Windows.Forms.Button buttonCancelarContato;
        private System.Windows.Forms.MaskedTextBox textTelefone;
    }
}