using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
<<<<<<< HEAD
    public partial class ObjetivoAluno {        
        public ObjetivoAluno()
        {
            IdObjetivoAluno = Guid.NewGuid();
            DataAlcancado = DateTime.Now;
        }
=======
    public partial class ObjetivoAluno
    {
>>>>>>> 58901c01bfdd9c77c5cc47609c125d6a3789230b
        public Guid IdObjetivoAluno { get; set; }

        public DateTime? DataAlcancado { get; set; }
        public decimal? Nota { get; set; }
        public Guid? IdAlunoTurma { get; set; }
        public Guid? IdObjetivo { get; set; }

        public virtual AlunoTurma IdAlunoTurmaNavigation { get; set; }
        public virtual Objetivo IdObjetivoNavigation { get; set; }
    }
}
