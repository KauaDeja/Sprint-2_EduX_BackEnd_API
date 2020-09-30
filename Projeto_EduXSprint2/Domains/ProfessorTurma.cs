using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class ProfessorTurma
    {
        public ProfessorTurma()
        {
<<<<<<< HEAD
=======
            IdProfessorTurma = Guid.NewGuid();
>>>>>>> 58901c01bfdd9c77c5cc47609c125d6a3789230b
        }
        public Guid IdProfessorTurma { get; set; }
        public string Descricao { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdTurma { get; set; }

        public virtual Turma IdTurmaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
