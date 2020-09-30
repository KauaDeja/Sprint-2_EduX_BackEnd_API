using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Perfil
    {
<<<<<<< HEAD

        public Perfil()
        {
            Usuario = new HashSet<Usuario>();
            IdPerfil = Guid.NewGuid();
=======
        public Perfil()
        {
            Usuario = new HashSet<Usuario>();
>>>>>>> 58901c01bfdd9c77c5cc47609c125d6a3789230b
        }

        public Guid IdPerfil { get; set; }
        public string Permissao { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
