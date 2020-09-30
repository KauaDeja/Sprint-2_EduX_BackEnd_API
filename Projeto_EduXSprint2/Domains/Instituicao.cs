using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_EduXSprint2.Domains
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            Curso = new HashSet<Curso>();
<<<<<<< HEAD
            IdInstituicao = Guid.NewGuid();
=======
>>>>>>> 3c07407f424fc1cb164ca7023d52b74aabe965ab
        }

        public Guid IdInstituicao { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}
