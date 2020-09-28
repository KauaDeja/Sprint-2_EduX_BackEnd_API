using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_EduXSprint2.Domains;
using Projeto_EduXSprint2.Repositories;

namespace Projeto_EduXSprint2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly CursoRepository _cursoRepository;

        public CursoController()
        {
            _cursoRepository = new CursoRepository();
        }
        /// <summary>
        /// Lista todos os cursos cadastrados
        /// </summary>
        /// <returns>Retorna a lista de cursos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var curso = _cursoRepository.LerTodos();


                if (curso.Count == 0)
                    return NoContent();

                return Ok(new
                {
                    totalCount = curso.Count,
                    data = curso
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Busca um curso pelo seu id
        /// </summary>
        /// <param name="id">id do curso</param>
        /// <returns>Retorna o curso buscado</returns>
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            try
            {
                // Busco o curso pelo id lá no repositorio
                var curso = _cursoRepository.BuscarPorId(id);

                // Aqui nós fazemos uma verificação para saber se esse curso buscado existe. Caso n exista retorna
                // Retorna Notfound- Produto n encontrado
                if (curso == null)

                    return NotFound();

                return Ok(curso);
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro retorna BadRequest e a msg de erro
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Cadastra um curso
        /// </summary>
        /// <param name="curso">Objeto do tipo curso</param>
        /// <returns>Retorna o curso cadastrado</returns>
        [HttpPost]
        public IActionResult Post([FromForm] Curso curso)// passou como parametro um formulario
        {
            try
            {

                // Adiciona um curso
                _cursoRepository.Cadastrar(curso);

                // retorna ok com os dados do curso cadastrado
                return Ok(curso);
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro retorna BadRequest e a msg de erro
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Altera o curso 
        /// </summary>
        /// <param name="id">Id do curso</param>
        /// <param name="curso">Objeto do tipo  curso</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Curso curso)
        {
            try
            {
                //certamente se ele passou pelo buscar Id ele existe
                var cursoTemp = _cursoRepository.BuscarPorId(id);

                // fAZ A verificação do curso
                if (cursoTemp == null)
                    return NotFound();

                // retorna ok com os dados do produto alterado
                return Ok(curso);
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro retorna BadRequest e a msg de erro
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Exclui um curso
        /// </summary>
        /// <param name="id">id do curso</param>
        /// <returns>Retorna o curso deletado</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                // Remove o curso pelo id
                _cursoRepository.Excluir(id);

                // em caso de sucesso de sua remoção
                //retorna um ok e mostra o Id 
                return Ok(id);


            }
            catch (Exception ex)
            {

                // Caso ocorra algum erro retorna BadRequest e a msg de erro
                return BadRequest(ex.Message);
            }
        }
    }
}
