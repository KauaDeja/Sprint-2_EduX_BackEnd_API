using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Perfil
    {
        public Perfil()
        {
            Usuario = new HashSet<Usuario>();
<<<<<<< HEAD
            IdPerfil = Guid.NewGuid();
=======
>>>>>>> 3c07407f424fc1cb164ca7023d52b74aabe965ab
        }

        public Guid IdPerfil { get; set; }
        public string Permissao { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
