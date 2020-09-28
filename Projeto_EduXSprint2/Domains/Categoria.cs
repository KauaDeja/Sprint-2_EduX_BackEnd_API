using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Categoria
    {
        [Key]
        public Guid Id { get; set; }
        public Categoria()
        {
            Objetivo = new HashSet<Objetivo>();
            Id = Guid.NewGuid();
        }

        public Guid IdCategoria { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Objetivo> Objetivo { get; set; }
    }
}
