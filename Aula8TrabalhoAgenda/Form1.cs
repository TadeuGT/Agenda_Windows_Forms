using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8TrabalhoAgenda {
    public partial class Form1 : Form {

        public Contatos ListContatos = new Contatos();
        public Eventos ListEventos = new Eventos();

        public Form1() {
            InitializeComponent();
        }

        private void buttonContatosIncluir2_Click(object sender, EventArgs e) {
            var inclusao = new FormInclusão(this.ListContatos);
            inclusao.Show();
        }

        private void buttonEventosIncluirImg_Click(object sender, EventArgs e) {
            if (listContatos.Items.Count == 0) {
                MessageBox.Show("O evento deverá ter um contato associado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                var inclusaoEvento = new FormInclusaoEvento(this.ListEventos, this.ListContatos);
                inclusaoEvento.Show();
            }
        }

        private void buttonContatosLimpar_Click(object sender, EventArgs e) {
            if (listContatos.Items.Equals(null)) {
                MessageBox.Show("Não há contatos na lista!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else { 
                ListContatos.LimparLista();
                listContatos.Items.Clear();
            }
        }


        private void buttonEventosLimpar_Click(object sender, EventArgs e) {
            if (listContatos.Items.Equals(null)) {
                MessageBox.Show("Não há eventos na lista!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                ListEventos.LimparLista();
                listEventos.Items.Clear();
            }
        }


        private void buttonContatosEditar_Click(object sender, EventArgs e) {
            int ver = listContatos.SelectedIndex;
            if (ver == -1) {
                MessageBox.Show("Selecione um contato para visualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else { 
            MessageBox.Show(this.ListContatos.Visualizar(ver), "Visualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listContatos_SelectedIndexChanged(object sender, EventArgs e) { }
        public void UpdateListBox() {
            int i = 1;
            listContatos.Items.Clear();
            foreach (var item in this.ListContatos.contatos) {
                listContatos.Items.Add(i + ". " + item.retornaDados());
                i++;
            }
        }

        public void UpdateEventBox() {
            int i = 1;
            listEventos.Items.Clear();
            foreach (var item in this.ListEventos.eventos) {
                listEventos.Items.Add(i + ". " + item.retornaDados());
                i++;
            }
        }

        private void buttonContatosRemover_Click(object sender, EventArgs e) {
            int remover = listContatos.SelectedIndex;
            if (remover == -1) {
                MessageBox.Show("Selecione um contato para remover!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (remover >= 0 ) {
                this.ListContatos.Remover(remover);
                UpdateListBox();
            }
        }

        private void buttonEventosRemover_Click(object sender, EventArgs e) {
            int remover = listEventos.SelectedIndex;
            if (remover == -1) {
                MessageBox.Show("Selecione um evento para remover!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (remover >= 0) {
                this.ListEventos.Remover(remover);
                UpdateEventBox();
            }
        }

        private void buttonEventosVer_Click(object sender, EventArgs e) {
            int ver = listEventos.SelectedIndex;
            if (ver == -1) {
                MessageBox.Show("Selecione um evento para visualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this.ListEventos.Visualizar(ver), "Visualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEventosIncluir_Click(object sender, EventArgs e) { }
        private void buttonContatosIncluir_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void listEventos_SelectedIndexChanged(object sender, EventArgs e) { }

    }
}
