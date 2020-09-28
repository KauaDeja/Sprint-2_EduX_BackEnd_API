using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Curtida
    {
        [Key]
        public Guid Id { get; set; }
        public Curtida()
        {
            Id = Guid.NewGuid();
        }
        public Guid IdCurtida { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdDica { get; set; }

        public virtual Dica IdDicaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
