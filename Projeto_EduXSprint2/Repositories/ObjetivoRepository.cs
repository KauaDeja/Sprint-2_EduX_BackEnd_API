using Projeto_EduXSprint2.Contexts;
using Projeto_EduXSprint2.Domains;
using Projeto_EduXSprint2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_EduXSprint2.Repositories
{
    public class ObjetivoRepository : IObjetivoRepository
    {
        private readonly EduXContext context;
        public ObjetivoRepository()
        {
            context = new EduXContext();
        }

        #region Leitura
        public List<Objetivo> Listar()
        {
            try
            {
                return context.Objetivo.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Objetivo Buscar(Guid id)
        {
            try
            {
                return context.Objetivo.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Gravação
        public void AdicionarObjetivo(Objetivo obj)
        {
            try
            {
                context.Objetivo.Add(obj);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Editar(Objetivo obj)
        {
            try
            {
                Objetivo newObjetivo = Buscar(obj.IdObjetivo);
                if (newObjetivo == null)
                {
                    throw new Exception("O objetivo procurado não corresponde a nenhum dos objetivos cadastrados");
                }
                newObjetivo.IdObjetivo = obj.IdObjetivo;
                newObjetivo.Descricao = obj.Descricao;
                newObjetivo.IdCategoria = obj.IdCategoria;

                context.Objetivo.Update(newObjetivo);
                context.SaveChanges();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remover(Guid id)
        {
            try
            {
                Objetivo newObjetivo = Buscar(id);
                if (newObjetivo == null)
                {
                    throw new Exception("O objetivo procurado não corresponde a nenhum dos objetivos cadastrados");
                }

                context.Objetivo.Remove(newObjetivo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
