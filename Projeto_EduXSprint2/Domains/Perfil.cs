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
<<<<<<< HEAD
            IdPerfil = Guid.NewGuid();
=======
>>>>>>> 1f24855ef81e8cd8ec819060a8c0c4ed5f7c139d
=======
>>>>>>> 13736be80c8b2c4180a7339713c8164335ef1281
        }

        public Guid IdPerfil { get; set; }
        public string Permissao { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
