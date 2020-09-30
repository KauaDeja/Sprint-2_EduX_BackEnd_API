using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Threading;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Dica
    {

        public Dica()
        {
            Curtida = new HashSet<Curtida>();
<<<<<<< HEAD
        
=======
            IdDica = Guid.NewGuid();
>>>>>>> 13736be80c8b2c4180a7339713c8164335ef1281
        }

        public Guid IdDica { get; set; }
        public string Texto { get; set; }
        public string UrlImagem { get; set; }
        public Guid? IdUsuario { get; set; }

        [JsonIgnore] // nao mapeia a propriedade no banco de dados
        [NotMapped] //ignora a propriedade no retorno no json 
        public IFormFile Imagem { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Curtida> Curtida { get; set; }
    }
}
