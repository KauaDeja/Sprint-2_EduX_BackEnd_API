using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class ProfessorTurma
    {
<<<<<<< HEAD
=======

>>>>>>> 13736be80c8b2c4180a7339713c8164335ef1281
        public ProfessorTurma()
        {
        }
        public Guid IdProfessorTurma { get; set; }
        public string Descricao { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdTurma { get; set; }

        public virtual Turma IdTurmaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
