using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GerenciadorDeEventos.controller;
using GerenciadorDeEventos.model.dto;

namespace GerenciadorDeEventos.view
{
    public partial class FrmListarConvidados : Form
    {
        public FrmListarConvidados()
        {
            InitializeComponent();
            this.Load += FrmListarConvidados_Load;
            dgvConvidados.CellClick += dgvConvidados_CellClick;
            dgvConvidados.RowPrePaint += dgvConvidados_RowPrePaint;
            // Ajusta as colunas conforme o conteúdo
            dgvConvidados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cmbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcional: Se desejar tratar mudança de seleção
        }

        // Carrega os eventos no ComboBox quando o formulário é aberto
        private void FrmListarConvidados_Load(object sender, EventArgs e)
        {
            try
            {
                EventoController eventoController = new EventoController();
                List<EventoDTO> eventos = eventoController.ListarEventos();
                cmbEvento.DataSource = eventos;
                cmbEvento.DisplayMember = "Nome";    // Exibe o nome do evento
                cmbEvento.ValueMember = "IdEvento";    // Usa o id do evento como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os eventos: " + ex.Message);
            }
        }

        // Busca os convidados para o evento selecionado e configura as colunas do DataGridView
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEvento.SelectedValue != null)
                {
                    int idEvento = Convert.ToInt32(cmbEvento.SelectedValue);
                    ConvidadoController convidadoController = new ConvidadoController();
                    List<ConvidadoDTO> convidados = convidadoController.ListarConvidadosPorEvento(idEvento);
                    dgvConvidados.DataSource = convidados;

                    // Configura os cabeçalhos das colunas que queremos exibir
                    if (dgvConvidados.Columns.Contains("IdConvidado"))
                        dgvConvidados.Columns["IdConvidado"].HeaderText = "Código";
                    if (dgvConvidados.Columns.Contains("Nome"))
                        dgvConvidados.Columns["Nome"].HeaderText = "Nome";
                    if (dgvConvidados.Columns.Contains("NumConvite"))
                        dgvConvidados.Columns["NumConvite"].HeaderText = "Número de Convite";
                    if (dgvConvidados.Columns.Contains("Status"))
                        dgvConvidados.Columns["Status"].HeaderText = "Status";

                    // Oculta as colunas que não queremos exibir
                    if (dgvConvidados.Columns.Contains("Idade"))
                        dgvConvidados.Columns["Idade"].Visible = false;
                    if (dgvConvidados.Columns.Contains("Sexo"))
                        dgvConvidados.Columns["Sexo"].Visible = false;

                    // Adiciona a coluna de botão "Detalhes" se ainda não existir
                    if (!dgvConvidados.Columns.Contains("Detalhes"))
                    {
                        DataGridViewButtonColumn btnDetalhes = new DataGridViewButtonColumn();
                        btnDetalhes.Name = "Detalhes";
                        btnDetalhes.HeaderText = "Detalhes";
                        btnDetalhes.Text = "Detalhes";
                        btnDetalhes.UseColumnTextForButtonValue = true;
                        dgvConvidados.Columns.Add(btnDetalhes);
                    }
                    // Adiciona a coluna de botão "Atualizar" se ainda não existir
                    if (!dgvConvidados.Columns.Contains("Atualizar"))
                    {
                        DataGridViewButtonColumn btnAtualizar = new DataGridViewButtonColumn();
                        btnAtualizar.Name = "Atualizar";
                        btnAtualizar.HeaderText = "Atualizar Status";
                        btnAtualizar.Text = "Atualizar";
                        btnAtualizar.UseColumnTextForButtonValue = true;
                        dgvConvidados.Columns.Add(btnAtualizar);
                    }
                    // Adiciona a coluna de botão "Remover" se ainda não existir
                    if (!dgvConvidados.Columns.Contains("Remover"))
                    {
                        DataGridViewButtonColumn btnRemover = new DataGridViewButtonColumn();
                        btnRemover.Name = "Remover";
                        btnRemover.HeaderText = "Remover";
                        btnRemover.Text = "Remover";
                        btnRemover.UseColumnTextForButtonValue = true;
                        dgvConvidados.Columns.Add(btnRemover);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um evento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os convidados: " + ex.Message);
            }
        }

        // Trata os cliques das células do DataGridView para atualizar, remover ou exibir detalhes
        private void dgvConvidados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se os índices de linha e coluna são válidos
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Evita a "new row"
            if (dgvConvidados.Rows[e.RowIndex].IsNewRow)
                return;

            // Identifica o nome da coluna clicada
            string colName = dgvConvidados.Columns[e.ColumnIndex].Name;

            // Botão "Detalhes": exibe os dados completos do convidado
            if (colName == "Detalhes")
            {
                ConvidadoDTO convidado = dgvConvidados.Rows[e.RowIndex].DataBoundItem as ConvidadoDTO;
                if (convidado != null)
                {
                    string detalhes = $"Código: {convidado.IdConvidado}\n" +
                                       $"Nome: {convidado.Nome}\n" +
                                       $"Idade: {convidado.Idade}\n" +
                                       $"Sexo: {convidado.Sexo}\n" +
                                       $"Número do Convite: {convidado.NumConvite}\n" +
                                       $"Status: {convidado.Status}";
                    MessageBox.Show(detalhes, "Detalhes do Convidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // Botão "Atualizar": solicita e atualiza o status do convidado
            else if (colName == "Atualizar")
            {
                // Verifica se a célula "IdConvidado" existe na linha
                if (!dgvConvidados.Columns.Contains("IdConvidado"))
                {
                    MessageBox.Show("A coluna 'IdConvidado' não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idConvidado = Convert.ToInt32(dgvConvidados.Rows[e.RowIndex].Cells["IdConvidado"].Value);
                int idEvento = Convert.ToInt32(cmbEvento.SelectedValue);
                string novoStatus = Prompt.ShowDialog("Digite o novo status (PRESENTE, AUSENTE, N/A):", "Atualizar Status");
                if (!string.IsNullOrWhiteSpace(novoStatus))
                {
                    EventoController eventoController = new EventoController();
                    eventoController.AtualizarStatusConvidado(idConvidado, idEvento, novoStatus);
                    MessageBox.Show("Status atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar_Click(null, null); // Atualiza a grid
                }
            }
            // Botão "Remover": solicita confirmação e remove o convidado
            else if (colName == "Remover")
            {
                // Verifica se a célula "IdConvidado" existe na linha
                if (!dgvConvidados.Columns.Contains("IdConvidado"))
                {
                    MessageBox.Show("A coluna 'IdConvidado' não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idConvidado = Convert.ToInt32(dgvConvidados.Rows[e.RowIndex].Cells["IdConvidado"].Value);
                if (MessageBox.Show("Deseja remover o convidado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConvidadoController convidadoController = new ConvidadoController();
                    convidadoController.DeletarConvidado(idConvidado);
                    MessageBox.Show("Convidado removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar_Click(null, null); // Atualiza a grid
                }
            }
        }


        // Altera a cor da linha com base no status do convidado
        private void dgvConvidados_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvConvidados.Rows[e.RowIndex];
            if (row.Cells["Status"].Value != null)
            {
                string status = row.Cells["Status"].Value.ToString();
                if (status.Equals("PRESENTE", StringComparison.OrdinalIgnoreCase))
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (status.Equals("AUSENTE", StringComparison.OrdinalIgnoreCase))
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                else // "N/A" ou outro valor
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
