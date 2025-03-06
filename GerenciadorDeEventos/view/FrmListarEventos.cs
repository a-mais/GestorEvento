using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GerenciadorDeEventos.model.dto;
using GerenciadorDeEventos.controller;

namespace GerenciadorDeEventos
{
    public partial class FrmListarEventos : Form
    {
        EventoController eventoController = new EventoController();

        public FrmListarEventos()
        {
            InitializeComponent();
            this.Load += FrmListarEventos_Load;
            dgvEventos.CellContentClick += dgvEventos_CellContentClick;
        }

        private void FrmListarEventos_Load(object sender, EventArgs e)
        {
            try
            {
                // Recupera os eventos
                List<EventoDTO> eventos = eventoController.ListarEventos();

                // Configura o DataGridView para não gerar colunas automaticamente
                dgvEventos.AutoGenerateColumns = false;
                dgvEventos.Columns.Clear();

                // Cria a coluna de Código (IdEvento)
                DataGridViewTextBoxColumn colCodigo = new DataGridViewTextBoxColumn();
                colCodigo.Name = "IdEvento";
                colCodigo.DataPropertyName = "IdEvento";
                colCodigo.HeaderText = "Código";
                dgvEventos.Columns.Add(colCodigo);

                // Cria a coluna de Nome
                DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn();
                colNome.Name = "Nome";
                colNome.DataPropertyName = "Nome";
                colNome.HeaderText = "Nome";
                dgvEventos.Columns.Add(colNome);

                // Cria a coluna de Data/Hora
                DataGridViewTextBoxColumn colDtHora = new DataGridViewTextBoxColumn();
                colDtHora.Name = "DtHora";
                colDtHora.DataPropertyName = "DtHora";
                colDtHora.HeaderText = "Data/Hora";
                dgvEventos.Columns.Add(colDtHora);

                // Define o DataSource com a lista de eventos
                dgvEventos.DataSource = eventos;

                // Adiciona a coluna de botão "Detalhes" ao final
                DataGridViewButtonColumn btnDetalhes = new DataGridViewButtonColumn();
                btnDetalhes.Name = "Details";
                btnDetalhes.HeaderText = "Detalhes";
                btnDetalhes.Text = "Ver Detalhes";
                btnDetalhes.UseColumnTextForButtonValue = true;
                dgvEventos.Columns.Add(btnDetalhes);

                // Adiciona a coluna de botão "Excluir" ao final
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.HeaderText = "Excluir";
                btnDelete.Text = "Excluir";
                btnDelete.UseColumnTextForButtonValue = true;
                dgvEventos.Columns.Add(btnDelete);

                // Ajusta o tamanho das colunas conforme o conteúdo
                dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os eventos: " + ex.Message);
            }
        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a linha clicada é válida
            if (e.RowIndex < 0)
                return;

            // Recupera o evento associado à linha clicada
            EventoDTO evento = dgvEventos.Rows[e.RowIndex].DataBoundItem as EventoDTO;
            if (evento == null)
                return;

            // Se o botão "Detalhes" foi clicado
            if (dgvEventos.Columns[e.ColumnIndex].Name == "Details")
            {
                string detalhes = $"Código: {evento.IdEvento}\n" +
                                  $"Nome: {evento.Nome}\n" +
                                  $"Data/Hora: {evento.DtHora}\n" +
                                  $"Local: {evento.Local}\n" +
                                  $"Descrição: {evento.Descricao}\n" +
                                  $"Categoria: {evento.Categoria}\n" +
                                  $"Duração: {evento.Duracao}";
                MessageBox.Show(detalhes, "Detalhes do Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Se o botão "Excluir" foi clicado
            else if (dgvEventos.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir este evento?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Chama o método de exclusão no controller
                        eventoController.DeletarEvento(evento.IdEvento);
                        MessageBox.Show("Evento deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Atualiza a lista de eventos no DataGridView
                        dgvEventos.DataSource = eventoController.ListarEventos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar evento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
