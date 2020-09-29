using Projeto_EduXSprint2.Contexts;
using Projeto_EduXSprint2.Domains;
using Projeto_EduXSprint2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_EduXSprint2.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        // readonly significa somente leitura, sem alterações
        // uso do encapsulamento
        private readonly EduXContext _context;

        public UsuarioRepository()
        {
            _context = new EduXContext();
        }
        // ctor é um atalho para criar um metodo construtor
        // Region é um comando de organização dos codigos

        #region Leitura
        /// <summary>
        /// Lista todos os Usuarios cadastrados
        /// </summary>
        /// <returns>Lista dos usuarios cadastrados</returns>
        public List<Usuario> LerTodos()
        {
            // Try catch é uma tratativa de erros
            try
            {
                // Aqui chamamos o metodo de listagem
                return _context.Usuario.ToList();
            }
            // Caso de erro retorna uma excessao
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Aqui buscamos um Usuario pelo seu Id
        /// </summary>
        /// <param name="id">Id do Usuario</param>
        /// <returns>retorna o usuario buscado</returns>
        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                // Faz a busca pelo id
                return _context.Usuario.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Aqui buscamos um Usuario pelo seu Nome
        /// </summary>
        /// <param name="nome">Nome do Usuario</param>
        /// <returns>Retorna o Usuario encontrado</returns>
        public List<Usuario> BuscarporNome(string nome)
        {
            // Try catch é uma tratativa de erros
            try
            {
                // Contains == WHERE
                // Aqui fazemos uma expressao lambda para buscar por nome
                return _context.Usuario.Where(c => c.Nome.Contains(nome)).ToList();
            }
            // Caso de erro retorna uma excessao
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Gravacao
        /// <summary>
        /// Aqui cadastramos um usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void Cadastrar(Usuario usuario)
        {
            // try - tente
            // catch - excessão
            // Try catch é um tipo de tratativa para o nosso erro
            try
            {
                // Adiciona objeto do tipo usuario ao dbset do contexto
                // Adiciona o professor
                _context.Usuario.Add(usuario);

                //Salva as alterações no contexto
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Aqui excluimos um Usuario
        /// </summary>
        /// <param name="id">Id do Usuario</param>
        public void Excluir(Guid id)
        {
            try
            {
                // Curso cursoTemp = cont.Curso.Find(produto.Id);
                // Buscar usuario pelo ID
                Usuario usuarioTemp = BuscarPorId(id);

                // verifica se o usuario existe
                // Caso não gera um ex
                if (usuarioTemp == null)
                    throw new Exception("Usuario não encontrado");

                // Remove os usuarios do dbset
                _context.Usuario.Remove(usuarioTemp);
                // salva as alterações do contexto
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// AlTera um usuario
        /// </summary>
        /// <param name="usuario">O objeto do tipo Usuario</param>
        public void Alterar(Usuario usuario)
        {
            try
            {
                // Buscar usuario pelo ID
                Usuario usuarioTemp = BuscarPorId(usuario.IdUsuario);

                // verifica se o usuario existe
                // Caso não gera um ex
                if (usuarioTemp == null)
                    throw new Exception("Usuario não encontrado");

                // Caso exista altera
                usuarioTemp.Nome = usuario.Nome;
                usuarioTemp.Email = usuario.Email;
                usuarioTemp.Senha = usuario.Senha;

                // Altera os usuarios no context
                _context.Usuario.Update(usuarioTemp);
                //Salva o contexto
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
