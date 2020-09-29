using Projeto_EduXSprint2.Contexts;
using Projeto_EduXSprint2.Domains;
using Projeto_EduXSprint2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_EduXSprint2.Repositories
{
    public class ProfessorTurmaRepository : IProfessorTurmaRepository
    {
        private readonly EduXContext cont;
        public ProfessorTurmaRepository()
        {
            cont = new EduXContext();
        }
        #region Gravacao
        /// <summary>
        /// Cadastra um professor
        /// </summary>
        /// <param name="professorturma">Objeto do tipo professor</param>
        public void Cadastrar(ProfessorTurma professorturma)
        {
            try
            {
                // Adiciona o professor
                cont.ProfessorTurma.Add(professorturma);

                // Salva as alterações no DbContext
                cont.SaveChanges();
            }
            // Caso n seja possiveç cadastrar gera uma excessao
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Altera um professor da turma
        /// </summary>
        /// <param name="professorturma">Objeto do tipo ProfessorTurma</param>
        public void Alterar(ProfessorTurma professorturma)
        {
            try
            {
                // Busca um professorturma
                ProfessorTurma professorTemp = BuscarPorId(professorturma.IdProfessorTurma);

                // Faz uma tratativa para ver se existe
                if (professorTemp == null)
                {
                    throw new Exception("Essa Turma não foi encontrada. Tente novamente");

                }

                professorTemp.Descricao = professorTemp.Descricao;


                //Altera a turma no contexto
                cont.ProfessorTurma.Update(professorTemp);
                // Salva as alteraçõe no contexto
                cont.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Exclui uma Turma
        /// </summary>
        /// <param name="id">Id do Professor Turma</param>
        public void Excluir(Guid id)
        {
            ProfessorTurma professorTemp = BuscarPorId(id);

            if (professorTemp == null)
            {
                throw new Exception("Essa Turma não foi encontrada");

            }

            // Chama o metodo para remover
            cont.ProfessorTurma.Remove(professorTemp);
            // Salva as alterações feita no DbContext
            cont.SaveChanges();

        }
        #endregion
        #region Leitura
        /// <summary>
        ///  Busca um professor pela sua id
        /// </summary>
        /// <param name="id">Id do professor</param>
        /// <returns>Retorna o professor buscado</returns>
        public ProfessorTurma BuscarPorId(Guid id)
        {
            try
            {
                // Faz a busca pelo id
                return cont.ProfessorTurma.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Lista os professores cadastrados
        /// </summary>
        /// <returns>Retorna uma lista de professor</returns>
        public List<ProfessorTurma> LerTodos()
        {
            try
            {
                // Chama o metodo de lista
                return cont.ProfessorTurma.ToList();
            }
            // Caso aconteça algum imprevisto gera uma excessao
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
