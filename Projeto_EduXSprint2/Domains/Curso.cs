using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Curso
    {
        [Key]
        public Guid Id { get; set; }
        public Curso()
        {
            Turma = new HashSet<Turma>();
            Id = Guid.NewGuid();
        }

        public Guid IdCurso { get; set; }
        public string Titulo { get; set; }
        public Guid IdInstituicao { get; set; }

        public virtual Instituicao IdInstituicaoNavigation { get; set; }
        public virtual ICollection<Turma> Turma { get; set; }
    }
}
