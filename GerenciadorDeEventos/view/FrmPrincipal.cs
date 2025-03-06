using System;
using System.Windows.Forms;
using GerenciadorDeEventos.view;

namespace GerenciadorDeEventos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void cadastrarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Cadastrar Evento
            FrmCadastrarEvento frm = new FrmCadastrarEvento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exibirEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Exibir Eventos
            FrmListarEventos frm = new FrmListarEventos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastrarConvidadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Cadastrar Convidado
            FrmCadastrarConvidado frm = new FrmCadastrarConvidado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listarConvidadosDeUmEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Lista de Convidados a partir de um Evento
            FrmListarConvidados frm = new FrmListarConvidados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bem-vindo ao Gerenciador de Eventos!\n\n" +
                "= Para cadastrar um novo evento, v� em 'Eventos' -> 'Cadastrar Evento'.\n" +
                "= Para exibir a lista de eventos, v� em 'Eventos' -> 'Exibir Eventos'.\n" +
                "= Para cadastrar um novo convidado, v� em 'Convidados' -> 'Cadastrar Convidado'.\n" +
                "= Para listar os convidados de um evento, v� em 'Convidados' -> 'Listar Convidados de um Evento'.\n\n" +
                "Em caso de d�vidas, entre em contato com o suporte.",
                "Ajuda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
