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
    public partial class FormInclusaoEvento : Form {

        public Eventos ListEventos;
        public Contatos ListContatos;
        public FormInclusaoEvento(Eventos e, Contatos c) {
            this.ListEventos = e;
            this.ListContatos = c;
            InitializeComponent();

            int i = 1;
            foreach (var item in this.ListContatos.contatos) {
                comboBoxHost.Items.Add(i + ". " + item.retornaDados());
                i++;
            }
        }

        private void buttonAdicionarContato_Click(object sender, EventArgs e) {

            string data = textData.Text;
            string nome = textNomeEvento.Text;
            int contNome = comboBoxHost.SelectedIndex;
            string descricao = textDescricao.Text;

            try {
                if (!Regex.IsMatch(data, @"^([0-2][0-9]|3[0-1])/(0[0-9]|1[0-2])/[0-9]{4}$")) {
                    throw new FormatException();
                }
                if (nome.Trim() == "" || descricao.Trim() == "") {
                    MessageBox.Show("Preencha as informações corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else if (contNome == -1) {
                    throw new IndexOutOfRangeException();

                } else {
                    Contato cont = ListContatos.Encontrar(contNome);
                    Evento e1 = new Evento(data, nome, cont, descricao);
                    this.ListEventos.Adicionar(e1);

                    Form1 f1 = (Form1)Application.OpenForms["Form1"];
                    f1.UpdateEventBox();
                    this.Close();
                }
            }
            catch (FormatException) {
                MessageBox.Show("Escreva a data no formato dd/mm/aaaa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IndexOutOfRangeException) {
                MessageBox.Show("Evento deve ter um apresentador cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormInclusaoEvento_Load(object sender, EventArgs e) {
            textData.Mask = "00/00/0000";
        }

        private void buttonCancelarContato_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void labelNome_Click(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void textData_TextChanged(object sender, EventArgs e) { }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
    }
}
