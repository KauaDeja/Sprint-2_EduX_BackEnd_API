using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class AlunoTurma
    {
        [Key]
        public Guid Id { get; set; }
        public AlunoTurma()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
            Id = Guid.NewGuid();
        }

        public Guid IdAlunoTurma { get; set; }
        public string Matricula { get; set; }
        public Guid IdTurma { get; set; }
        public Guid IdUsuario { get; set; }

        public virtual Turma IdTurmaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ObjetivoAluno> ObjetivoAluno { get; set; }
    }
}
