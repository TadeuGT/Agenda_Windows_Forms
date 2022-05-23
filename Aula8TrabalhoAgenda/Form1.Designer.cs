namespace Aula8TrabalhoAgenda {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelContatos = new System.Windows.Forms.Label();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.buttonContatosEditar = new System.Windows.Forms.Button();
            this.buttonContatosRemover = new System.Windows.Forms.Button();
            this.buttonContatosLimpar = new System.Windows.Forms.Button();
            this.buttonEventosLimpar = new System.Windows.Forms.Button();
            this.buttonEventosRemover = new System.Windows.Forms.Button();
            this.buttonEventosVer = new System.Windows.Forms.Button();
            this.listEventos = new System.Windows.Forms.ListBox();
            this.labelEventos = new System.Windows.Forms.Label();
            this.buttonContatosIncluirImg = new System.Windows.Forms.PictureBox();
            this.buttonEventosIncluirImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonContatosIncluirImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEventosIncluirImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContatos
            // 
            this.labelContatos.AutoSize = true;
            this.labelContatos.BackColor = System.Drawing.Color.Transparent;
            this.labelContatos.Font = new System.Drawing.Font("Bodo Amat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContatos.Location = new System.Drawing.Point(108, 53);
            this.labelContatos.Name = "labelContatos";
            this.labelContatos.Size = new System.Drawing.Size(256, 52);
            this.labelContatos.TabIndex = 0;
            this.labelContatos.Text = "Contatos";
            this.labelContatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // listContatos
            // 
            this.listContatos.BackColor = System.Drawing.Color.DarkGray;
            this.listContatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listContatos.Font = new System.Drawing.Font("Soda Land", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 37;
            this.listContatos.Location = new System.Drawing.Point(35, 108);
            this.listContatos.MaximumSize = new System.Drawing.Size(457, 407);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(457, 407);
            this.listContatos.TabIndex = 1;
            this.listContatos.SelectedIndexChanged += new System.EventHandler(this.listContatos_SelectedIndexChanged);
            // 
            // buttonContatosEditar
            // 
            this.buttonContatosEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonContatosEditar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonContatosEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonContatosEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonContatosEditar.FlatAppearance.BorderSize = 2;
            this.buttonContatosEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContatosEditar.Font = new System.Drawing.Font("Soda Land", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContatosEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonContatosEditar.Image")));
            this.buttonContatosEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonContatosEditar.Location = new System.Drawing.Point(35, 553);
            this.buttonContatosEditar.Name = "buttonContatosEditar";
            this.buttonContatosEditar.Size = new System.Drawing.Size(122, 88);
            this.buttonContatosEditar.TabIndex = 2;
            this.buttonContatosEditar.Text = "Visualizar";
            this.buttonContatosEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonContatosEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonContatosEditar.UseVisualStyleBackColor = false;
            this.buttonContatosEditar.Click += new System.EventHandler(this.buttonContatosEditar_Click);
            // 
            // buttonContatosRemover
            // 
            this.buttonContatosRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonContatosRemover.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonContatosRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonContatosRemover.FlatAppearance.BorderSize = 2;
            this.buttonContatosRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContatosRemover.Font = new System.Drawing.Font("Soda Land", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContatosRemover.Image = ((System.Drawing.Image)(resources.GetObject("buttonContatosRemover.Image")));
            this.buttonContatosRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonContatosRemover.Location = new System.Drawing.Point(202, 553);
            this.buttonContatosRemover.Name = "buttonContatosRemover";
            this.buttonContatosRemover.Size = new System.Drawing.Size(122, 88);
            this.buttonContatosRemover.TabIndex = 3;
            this.buttonContatosRemover.Text = "Remover";
            this.buttonContatosRemover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonContatosRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonContatosRemover.UseVisualStyleBackColor = false;
            this.buttonContatosRemover.Click += new System.EventHandler(this.buttonContatosRemover_Click);
            // 
            // buttonContatosLimpar
            // 
            this.buttonContatosLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonContatosLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonContatosLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonContatosLimpar.FlatAppearance.BorderSize = 2;
            this.buttonContatosLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContatosLimpar.Font = new System.Drawing.Font("Soda Land", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContatosLimpar.Image = ((System.Drawing.Image)(resources.GetObject("buttonContatosLimpar.Image")));
            this.buttonContatosLimpar.Location = new System.Drawing.Point(370, 553);
            this.buttonContatosLimpar.Name = "buttonContatosLimpar";
            this.buttonContatosLimpar.Size = new System.Drawing.Size(122, 88);
            this.buttonContatosLimpar.TabIndex = 4;
            this.buttonContatosLimpar.Text = "Limpar";
            this.buttonContatosLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonContatosLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonContatosLimpar.UseVisualStyleBackColor = false;
            this.buttonContatosLimpar.Click += new System.EventHandler(this.buttonContatosLimpar_Click);
            // 
            // buttonEventosLimpar
            // 
            this.buttonEventosLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEventosLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEventosLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEventosLimpar.FlatAppearance.BorderSize = 2;
            this.buttonEventosLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEventosLimpar.Font = new System.Drawing.Font("Soda Land", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEventosLimpar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEventosLimpar.Image")));
            this.buttonEventosLimpar.Location = new System.Drawing.Point(960, 553);
            this.buttonEventosLimpar.Name = "buttonEventosLimpar";
            this.buttonEventosLimpar.Size = new System.Drawing.Size(122, 88);
            this.buttonEventosLimpar.TabIndex = 10;
            this.buttonEventosLimpar.Text = "Limpar";
            this.buttonEventosLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEventosLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEventosLimpar.UseVisualStyleBackColor = false;
            this.buttonEventosLimpar.Click += new System.EventHandler(this.buttonEventosLimpar_Click);
            // 
            // buttonEventosRemover
            // 
            this.buttonEventosRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEventosRemover.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEventosRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEventosRemover.FlatAppearance.BorderSize = 2;
            this.buttonEventosRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEventosRemover.Font = new System.Drawing.Font("Soda Land", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEventosRemover.Image = ((System.Drawing.Image)(resources.GetObject("buttonEventosRemover.Image")));
            this.buttonEventosRemover.Location = new System.Drawing.Point(792, 553);
            this.buttonEventosRemover.Name = "buttonEventosRemover";
            this.buttonEventosRemover.Size = new System.Drawing.Size(122, 88);
            this.buttonEventosRemover.TabIndex = 9;
            this.buttonEventosRemover.Text = "Remover";
            this.buttonEventosRemover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEventosRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEventosRemover.UseVisualStyleBackColor = false;
            this.buttonEventosRemover.Click += new System.EventHandler(this.buttonEventosRemover_Click);
            // 
            // buttonEventosVer
            // 
            this.buttonEventosVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEventosVer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEventosVer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEventosVer.FlatAppearance.BorderSize = 2;
            this.buttonEventosVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEventosVer.Font = new System.Drawing.Font("Soda Land", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEventosVer.Image = ((System.Drawing.Image)(resources.GetObject("buttonEventosVer.Image")));
            this.buttonEventosVer.Location = new System.Drawing.Point(625, 553);
            this.buttonEventosVer.Name = "buttonEventosVer";
            this.buttonEventosVer.Size = new System.Drawing.Size(122, 88);
            this.buttonEventosVer.TabIndex = 8;
            this.buttonEventosVer.Text = "Visualizar";
            this.buttonEventosVer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEventosVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEventosVer.UseVisualStyleBackColor = false;
            this.buttonEventosVer.Click += new System.EventHandler(this.buttonEventosVer_Click);
            // 
            // listEventos
            // 
            this.listEventos.BackColor = System.Drawing.Color.DarkGray;
            this.listEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEventos.Font = new System.Drawing.Font("Soda Land", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listEventos.FormattingEnabled = true;
            this.listEventos.ItemHeight = 37;
            this.listEventos.Location = new System.Drawing.Point(625, 108);
            this.listEventos.MaximumSize = new System.Drawing.Size(457, 407);
            this.listEventos.Name = "listEventos";
            this.listEventos.Size = new System.Drawing.Size(457, 407);
            this.listEventos.TabIndex = 7;
            this.listEventos.SelectedIndexChanged += new System.EventHandler(this.listEventos_SelectedIndexChanged);
            // 
            // labelEventos
            // 
            this.labelEventos.AutoSize = true;
            this.labelEventos.BackColor = System.Drawing.Color.Transparent;
            this.labelEventos.Font = new System.Drawing.Font("Bodo Amat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEventos.Location = new System.Drawing.Point(714, 53);
            this.labelEventos.Name = "labelEventos";
            this.labelEventos.Size = new System.Drawing.Size(225, 52);
            this.labelEventos.TabIndex = 6;
            this.labelEventos.Text = "Eventos";
            // 
            // buttonContatosIncluirImg
            // 
            this.buttonContatosIncluirImg.BackColor = System.Drawing.Color.Transparent;
            this.buttonContatosIncluirImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContatosIncluirImg.Image = ((System.Drawing.Image)(resources.GetObject("buttonContatosIncluirImg.Image")));
            this.buttonContatosIncluirImg.Location = new System.Drawing.Point(370, 39);
            this.buttonContatosIncluirImg.Name = "buttonContatosIncluirImg";
            this.buttonContatosIncluirImg.Size = new System.Drawing.Size(70, 67);
            this.buttonContatosIncluirImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonContatosIncluirImg.TabIndex = 12;
            this.buttonContatosIncluirImg.TabStop = false;
            this.buttonContatosIncluirImg.Click += new System.EventHandler(this.buttonContatosIncluir2_Click);
            // 
            // buttonEventosIncluirImg
            // 
            this.buttonEventosIncluirImg.BackColor = System.Drawing.Color.Transparent;
            this.buttonEventosIncluirImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEventosIncluirImg.Image = ((System.Drawing.Image)(resources.GetObject("buttonEventosIncluirImg.Image")));
            this.buttonEventosIncluirImg.Location = new System.Drawing.Point(945, 39);
            this.buttonEventosIncluirImg.Name = "buttonEventosIncluirImg";
            this.buttonEventosIncluirImg.Size = new System.Drawing.Size(70, 67);
            this.buttonEventosIncluirImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonEventosIncluirImg.TabIndex = 13;
            this.buttonEventosIncluirImg.TabStop = false;
            this.buttonEventosIncluirImg.Click += new System.EventHandler(this.buttonEventosIncluirImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 681);
            this.Controls.Add(this.buttonEventosIncluirImg);
            this.Controls.Add(this.buttonContatosIncluirImg);
            this.Controls.Add(this.buttonEventosLimpar);
            this.Controls.Add(this.buttonEventosRemover);
            this.Controls.Add(this.buttonEventosVer);
            this.Controls.Add(this.listEventos);
            this.Controls.Add(this.labelEventos);
            this.Controls.Add(this.buttonContatosLimpar);
            this.Controls.Add(this.buttonContatosRemover);
            this.Controls.Add(this.buttonContatosEditar);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.labelContatos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1132, 720);
            this.MinimumSize = new System.Drawing.Size(1132, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonContatosIncluirImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEventosIncluirImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContatos;
        private System.Windows.Forms.Button buttonContatosEditar;
        private System.Windows.Forms.Button buttonContatosRemover;
        private System.Windows.Forms.Button buttonContatosLimpar;
        private System.Windows.Forms.Button buttonEventosLimpar;
        private System.Windows.Forms.Button buttonEventosRemover;
        private System.Windows.Forms.Button buttonEventosVer;
        private System.Windows.Forms.ListBox listEventos;
        private System.Windows.Forms.Label labelEventos;
        public System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.PictureBox buttonContatosIncluirImg;
        private System.Windows.Forms.PictureBox buttonEventosIncluirImg;
    }
}
