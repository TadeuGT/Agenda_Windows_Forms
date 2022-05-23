using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8TrabalhoAgenda {
    public partial class FormInclusão : Form {

        public Contatos ListContatos;
        public FormInclusão(Contatos c) {
            this.ListContatos = c;
            InitializeComponent();
        }

        private void buttonAdicionarContato_Click(object sender, EventArgs e) {
            string nome = textNome.Text;
            string tel = textTelefone.Text;
            string email = textEmail.Text;

            try {
                if (!Regex.IsMatch(tel, @"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$")) {
                    throw new FormatException();
                }
                if (nome.Trim() == "" || email.Trim() == "") {
                    MessageBox.Show("Preencha as informações corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    Contato c1 = new Contato(nome, tel, email);
                    this.ListContatos.Adicionar(c1);

                    Form1 f1 = (Form1)Application.OpenForms["Form1"];
                    f1.UpdateListBox();
                    this.Close();
                }
            }
            catch (FormatException) {
                MessageBox.Show("Verifique o telefone digitado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormInclusão_Load(object sender, EventArgs e) {
            textTelefone.Mask = "(00) 00000-0000";
        }

        private void buttonCancelarContato_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void labelNome_Click(object sender, EventArgs e) { }
        private void textTelefone_TextChanged(object sender, EventArgs e) { }
        private void textData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
    }
}
