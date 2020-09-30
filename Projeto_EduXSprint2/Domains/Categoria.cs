using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Categoria
    {
        public Categoria()
        {
            Objetivo = new HashSet<Objetivo>();
<<<<<<< HEAD
            IdCategoria = Guid.NewGuid();
=======
>>>>>>> 3c07407f424fc1cb164ca7023d52b74aabe965ab
        }

        public Guid IdCategoria { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Objetivo> Objetivo { get; set; }
    }
}
