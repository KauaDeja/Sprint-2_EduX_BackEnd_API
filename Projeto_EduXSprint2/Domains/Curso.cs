using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Curso
    {
        public Curso()
        {
            Turma = new HashSet<Turma>();
<<<<<<< HEAD
            IdCurso = Guid.NewGuid();
=======
>>>>>>> 3c07407f424fc1cb164ca7023d52b74aabe965ab
        }

        public Guid IdCurso { get; set; }
        public string Titulo { get; set; }
        public Guid IdInstituicao { get; set; }

        public virtual Instituicao IdInstituicaoNavigation { get; set; }
        public virtual ICollection<Turma> Turma { get; set; }
    }
}
