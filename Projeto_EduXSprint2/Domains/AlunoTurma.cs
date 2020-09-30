using System;
using System.Collections.Generic;

namespace Projeto_EduXSprint2.Domains
{
    public partial class AlunoTurma
    {
<<<<<<< HEAD
        public AlunoTurma()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
            IdAlunoTurma = Guid.NewGuid();
=======
       
        public AlunoTurma()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();

>>>>>>> 3c07407f424fc1cb164ca7023d52b74aabe965ab
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
