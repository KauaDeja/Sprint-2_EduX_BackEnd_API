using Projeto_EduXSprint2.Contexts;
using Projeto_EduXSprint2.Domains;
using Projeto_EduXSprint2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_EduXSprint2.Repositories
{
    public class DicaRepository : IDicaRepository
    {
        private readonly EduXContext context = new EduXContext();
        public DicaRepository()
        {
            context= new EduXContext();
        }
        public void Adicionar(Dica dica)
        {
            try
            {
                //adiciona objeto do tipo dica ao dbset do context
                context.Dica.Update(dica);
                //context.Set<Dica>().Update(dica);
                //context.Entry(dica).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                //salva as alterações do context
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Dica BuscarPorId(Guid id)
        {
            try
            {
                return context.Dica.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Editar(Dica dica)
        {
            try
            {
                Dica dicatemp = BuscarPorId(dica.IdDica);

                if (dicatemp == null)
                    throw new Exception("Dica não encontrada.");

                dicatemp.Texto = dica.Texto;
                dicatemp.Imagem = dica.Imagem;

                context.Update(dicatemp);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                Dica dicatempo = BuscarPorId(id);

                if (dicatempo == null)
                    throw new Exception("Dica não encontrada");

                context.Dica.Remove(dicatempo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Dica> LerTodos()
        {
            try
            {
                return context.Dica.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
