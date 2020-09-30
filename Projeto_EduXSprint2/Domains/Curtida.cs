using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Curtida
    {
<<<<<<< HEAD
        public Curtida()
        {
            IdCurtida = Guid.NewGuid();
        }
=======
>>>>>>> 58901c01bfdd9c77c5cc47609c125d6a3789230b
        public Guid IdCurtida { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdDica { get; set; }

        public virtual Dica IdDicaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
