using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class ObjetivoAluno
    {
        [Key]
        public Guid Id { get; set; }
        public ObjetivoAluno()
        {
            Id = Guid.NewGuid();
        }
        public Guid IdObjetivoAluno { get; set; }
        public DateTime? DataAlcancado { get; set; }
        public decimal? Nota { get; set; }
        public Guid? IdAlunoTurma { get; set; }
        public Guid? IdObjetivo { get; set; }

        public virtual AlunoTurma IdAlunoTurmaNavigation { get; set; }
        public virtual Objetivo IdObjetivoNavigation { get; set; }
    }
}
