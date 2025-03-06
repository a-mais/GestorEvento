using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeEventos.controller;
using GerenciadorDeEventos.model.dto;

namespace GerenciadorDeEventos
{
    public partial class FrmCadastrarEvento : Form
    {
        public FrmCadastrarEvento()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crie um objeto DTO para armazenar os dados do evento
                EventoDTO novoEvento = new EventoDTO();

                // Captura os valores dos controles
                novoEvento.Nome = txtNome.Text;
                novoEvento.DtHora = dtpDataHora.Value; // Valor do DateTimePicker (data e hora)
                novoEvento.Local = txtLocal.Text;
                novoEvento.Descricao = txtDescricao.Text;
                novoEvento.Categoria = cmbCategoria.Text;
                novoEvento.Duracao = cmbDuracao.Text;

                // Chama o controller para cadastrar o evento no banco de dados
                EventoController eventoController = new EventoController();
                eventoController.CadastrarEvento(novoEvento);

                MessageBox.Show("Evento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpa os controles após cadastro
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o evento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpar os campos após cadastro (opcional)
        private void LimparCampos()
        {
            txtNome.Clear();
            txtLocal.Clear();
            txtDescricao.Clear();

            // Limpa os ComboBox: define SelectedIndex para -1 para remover a seleção
            cmbCategoria.SelectedIndex = -1;
            cmbDuracao.SelectedIndex = -1;

            // Redefine o DateTimePicker para a data e hora atual
            dtpDataHora.Value = DateTime.Now;
        }
    }
}
