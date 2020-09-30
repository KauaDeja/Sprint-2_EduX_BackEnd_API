using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Categoria
    {
<<<<<<< HEAD
        
        public Categoria()
        {
            Objetivo = new HashSet<Objetivo>();
            IdCategoria = Guid.NewGuid();
=======

        public Categoria()
        {
            Objetivo = new HashSet<Objetivo>();
>>>>>>> 1f24855ef81e8cd8ec819060a8c0c4ed5f7c139d
        }

        public Guid IdCategoria { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Objetivo> Objetivo { get; set; }
    }
}
