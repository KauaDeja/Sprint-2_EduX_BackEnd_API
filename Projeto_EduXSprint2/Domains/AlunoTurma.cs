using System;
using System.Collections.Generic;

namespace Projeto_EduXSprint2.Domains
{
    public partial class AlunoTurma
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public AlunoTurma()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
            IdAlunoTurma = Guid.NewGuid();
=======
   
        public AlunoTurma()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
>>>>>>> 1f24855ef81e8cd8ec819060a8c0c4ed5f7c139d
=======

        public AlunoTurma()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
>>>>>>> 13736be80c8b2c4180a7339713c8164335ef1281
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
