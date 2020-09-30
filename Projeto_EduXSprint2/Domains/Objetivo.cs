using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Objetivo
    {
        public Objetivo()
        {
            ObjetivoAluno = new HashSet<ObjetivoAluno>();
<<<<<<< HEAD
            IdObjetivo = Guid.NewGuid();
=======
>>>>>>> 3c07407f424fc1cb164ca7023d52b74aabe965ab
        }

        public Guid IdObjetivo { get; set; }
        public string Descricao { get; set; }
        public Guid IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<ObjetivoAluno> ObjetivoAluno { get; set; }
    }
}
