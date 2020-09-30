using System;
using System.Collections.Generic;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Turma
    {

        public Turma()
        {
            AlunoTurma = new HashSet<AlunoTurma>();
            ProfessorTurma = new HashSet<ProfessorTurma>();
<<<<<<< HEAD
            IdTurma = Guid.NewGuid();
=======
>>>>>>> 1f24855ef81e8cd8ec819060a8c0c4ed5f7c139d
        }

        public Guid IdTurma { get; set; }
        public string Descricao { get; set; }
        public Guid IdCurso { get; set; }

        public virtual Curso IdCursoNavigation { get; set; }
        public virtual ICollection<AlunoTurma> AlunoTurma { get; set; }
        public virtual ICollection<ProfessorTurma> ProfessorTurma { get; set; }
    }
}
