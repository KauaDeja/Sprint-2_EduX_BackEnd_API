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
>>>>>>> 3c07407f424fc1cb164ca7023d52b74aabe965ab
        public Guid IdCurtida { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdDica { get; set; }

        public virtual Dica IdDicaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
