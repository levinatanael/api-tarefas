﻿using System;

namespace Tarefa.Application.Dtos
{
    public class TarefaDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public int ProjetoId { get; set; }
    }
}