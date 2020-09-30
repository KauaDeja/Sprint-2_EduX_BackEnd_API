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
=======
        public Curtida()
        {
            IdCurtida = Guid.NewGuid();
>>>>>>> 13736be80c8b2c4180a7339713c8164335ef1281
        }
        public Guid IdCurtida { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdDica { get; set; }

        public virtual Dica IdDicaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
