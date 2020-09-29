using Projeto_EduXSprint2.Contexts;
using Projeto_EduXSprint2.Domains;
using Projeto_EduXSprint2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_EduXSprint2.Repositories
{
    public class ObjetivoAlunoRepository : IObjetivoAlunoRepository
    {
        private readonly EduXContext context;
        public ObjetivoAlunoRepository()
        {
            context = new EduXContext();
        }

        #region Leitura
        public List<ObjetivoAluno> Listar()
        {
            try
            {
                return context.ObjetivoAluno.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ObjetivoAluno Buscar(Guid id)
        {
            try
            {
                return context.ObjetivoAluno.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Gravação

        public void Adicionar(ObjetivoAluno objAluno)
        {
            try
            {
                if(objAluno.Nota > 100)
                {
                    throw new Exception("O valor inserido para nota é invalido, por favor insira alguma nota entre 0 e 100");
                }
                else if (objAluno.Nota < 0)
                {
                    throw new Exception("O valor inserido para nota é invalido, por favor insira alguma nota entre 0 e 100");
                }
                context.ObjetivoAluno.Add(objAluno);
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
                ObjetivoAluno objetivoAl = Buscar(id);
                if (objetivoAl == null)
                {
                    throw new Exception("ID não encontrado");
                }
                context.ObjetivoAluno.Remove(objetivoAl);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Editar(ObjetivoAluno objAluno)
        {
            try
            {
                ObjetivoAluno objetivoAl = Buscar(objAluno.IdObjetivoAluno);
                if(objetivoAl == null)
                {
                    throw new Exception("ID não encontrado");
                }
                objetivoAl.Nota = objAluno.Nota;
                objetivoAl.DataAlcancado = objAluno.DataAlcancado;
                objetivoAl.IdAlunoTurma = objAluno.IdAlunoTurma;
                objetivoAl.IdObjetivo = objAluno.IdObjetivo;

                context.ObjetivoAluno.Update(objetivoAl);
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
