namespace Aula8TrabalhoAgenda {
    partial class FormInclusaoEvento {
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
            this.components = new System.ComponentModel.Container();
            this.contatosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelApresentador = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textNomeEvento = new System.Windows.Forms.TextBox();
            this.labelNomeEvento = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.buttonAdicionarContato = new System.Windows.Forms.Button();
            this.buttonCancelarContato = new System.Windows.Forms.Button();
            this.comboBoxHost = new System.Windows.Forms.ComboBox();
            this.textData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contatosBindingSource2
            // 
            this.contatosBindingSource2.DataSource = typeof(Aula8TrabalhoAgenda.Contatos);
            // 
            // contatosBindingSource
            // 
            this.contatosBindingSource.DataSource = typeof(Aula8TrabalhoAgenda.Contatos);
            // 
            // contatosBindingSource1
            // 
            this.contatosBindingSource1.DataSource = typeof(Aula8TrabalhoAgenda.Contatos);
            // 
            // labelApresentador
            // 
            this.labelApresentador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelApresentador.AutoSize = true;
            this.labelApresentador.Font = new System.Drawing.Font("Bodo Amat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelApresentador.Location = new System.Drawing.Point(118, 161);
            this.labelApresentador.Name = "labelApresentador";
            this.labelApresentador.Size = new System.Drawing.Size(161, 23);
            this.labelApresentador.TabIndex = 16;
            this.labelApresentador.Text = "Apresentador";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Bodo Amat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(118, 90);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(61, 23);
            this.labelNome.TabIndex = 9;
            this.labelNome.Text = "Data";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // textNomeEvento
            // 
            this.textNomeEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNomeEvento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNomeEvento.Location = new System.Drawing.Point(118, 45);
            this.textNomeEvento.Name = "textNomeEvento";
            this.textNomeEvento.Size = new System.Drawing.Size(340, 35);
            this.textNomeEvento.TabIndex = 10;
            // 
            // labelNomeEvento
            // 
            this.labelNomeEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomeEvento.AutoSize = true;
            this.labelNomeEvento.Font = new System.Drawing.Font("Bodo Amat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomeEvento.Location = new System.Drawing.Point(118, 19);
            this.labelNomeEvento.Name = "labelNomeEvento";
            this.labelNomeEvento.Size = new System.Drawing.Size(72, 23);
            this.labelNomeEvento.TabIndex = 11;
            this.labelNomeEvento.Text = "Nome";
            // 
            // textDescricao
            // 
            this.textDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescricao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDescricao.Location = new System.Drawing.Point(118, 265);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(340, 35);
            this.textDescricao.TabIndex = 13;
            // 
            // labelDescricao
            // 
            this.labelDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Bodo Amat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescricao.Location = new System.Drawing.Point(118, 239);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(113, 23);
            this.labelDescricao.TabIndex = 13;
            this.labelDescricao.Text = "Descrição";
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
            this.buttonAdicionarContato.Location = new System.Drawing.Point(118, 328);
            this.buttonAdicionarContato.Name = "buttonAdicionarContato";
            this.buttonAdicionarContato.Size = new System.Drawing.Size(122, 57);
            this.buttonAdicionarContato.TabIndex = 14;
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
            this.buttonCancelarContato.Location = new System.Drawing.Point(336, 328);
            this.buttonCancelarContato.Name = "buttonCancelarContato";
            this.buttonCancelarContato.Size = new System.Drawing.Size(122, 57);
            this.buttonCancelarContato.TabIndex = 15;
            this.buttonCancelarContato.Text = "Cancelar";
            this.buttonCancelarContato.UseVisualStyleBackColor = false;
            this.buttonCancelarContato.Click += new System.EventHandler(this.buttonCancelarContato_Click);
            // 
            // comboBoxHost
            // 
            this.comboBoxHost.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxHost.FormattingEnabled = true;
            this.comboBoxHost.Location = new System.Drawing.Point(118, 187);
            this.comboBoxHost.Name = "comboBoxHost";
            this.comboBoxHost.Size = new System.Drawing.Size(340, 38);
            this.comboBoxHost.TabIndex = 12;
            this.comboBoxHost.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textData
            // 
            this.textData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textData.Location = new System.Drawing.Point(118, 116);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(340, 35);
            this.textData.TabIndex = 11;
            this.textData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // FormInclusaoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.comboBoxHost);
            this.Controls.Add(this.labelApresentador);
            this.Controls.Add(this.buttonCancelarContato);
            this.Controls.Add(this.buttonAdicionarContato);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.labelNomeEvento);
            this.Controls.Add(this.textNomeEvento);
            this.Controls.Add(this.labelNome);
            this.Name = "FormInclusaoEvento";
            this.Text = "FormInclusaoEvento";
            this.Load += new System.EventHandler(this.FormInclusaoEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contatosBindingSource2;
        private System.Windows.Forms.BindingSource contatosBindingSource;
        private System.Windows.Forms.BindingSource contatosBindingSource1;
        private System.Windows.Forms.Label labelApresentador;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textNomeEvento;
        private System.Windows.Forms.Label labelNomeEvento;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Button buttonAdicionarContato;
        private System.Windows.Forms.Button buttonCancelarContato;
        private System.Windows.Forms.ComboBox comboBoxHost;
        private System.Windows.Forms.MaskedTextBox textData;
    }
}