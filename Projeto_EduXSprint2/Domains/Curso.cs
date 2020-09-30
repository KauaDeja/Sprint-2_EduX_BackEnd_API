using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Curso
    {
<<<<<<< HEAD
     
=======

>>>>>>> 13736be80c8b2c4180a7339713c8164335ef1281
        public Curso()
        {
            Turma = new HashSet<Turma>();
        }

        public Guid IdCurso { get; set; }
        public string Titulo { get; set; }
        public Guid IdInstituicao { get; set; }

        public virtual Instituicao IdInstituicaoNavigation { get; set; }
        public virtual ICollection<Turma> Turma { get; set; }
    }
}
