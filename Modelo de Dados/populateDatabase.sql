USE gestorevento;

-- Inserção de eventos
INSERT INTO Evento (idEvento, nome, dt_hora, local, descricao, categoria, duracao)
VALUES 
  (1, 'Festa de Aniversário', '2025-05-10 20:00:00', 'Salão de Festas', 'Comemoração dos 30 anos de João', 'Festa', '4 horas'),
  (2, 'Conferência de Tecnologia', '2025-06-15 09:00:00', 'Centro de Convenções', 'Evento sobre inovações tecnológicas', 'Conferência', '8 horas'),
  (3, 'Show de Rock', '2025-07-20 21:00:00', 'Estádio Municipal', 'Show de uma banda de rock renomada', 'Show', '3 horas');

-- Inserção de convidados
INSERT INTO Convidado (idConvidado, nome, idade, sexo, numConvite)
VALUES
  (7, 'João Silva', 30, 'M', 1014),
  (8, 'Maria Oliveira', 28, 'F', 10142),
  (9, 'Carlos Souza', 35, 'M', 10413),
  (10, 'Ana Costa', 27, 'F', 104515),
  (11, 'Pedro Santos', 40, 'M', 101415);

-- Vinculação de convidados aos eventos na tabela ConvidadoEvento
-- Status: 'PRESENTE', 'AUSENTE' ou 'N/A' (padrão)
INSERT INTO ConvidadoEvento (idConvidado, idEvento, status)
VALUES
  -- Evento 1: Festa de Aniversário
  (11, 1, 'PRESENTE'),
  (10, 1, 'AUSENTE'),
  (7, 1, 'N/A'),
  
  -- Evento 2: Conferência de Tecnologia
  (8, 2, 'PRESENTE'),
  (9, 2, 'PRESENTE'),
  
  -- Evento 3: Show de Rock
  (8, 3, 'N/A'),
  (9, 3, 'AUSENTE');
