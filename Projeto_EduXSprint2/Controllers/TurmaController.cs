using System;
using Microsoft.AspNetCore.Mvc;
using Projeto_EduXSprint2.Domains;
using Projeto_EduXSprint2.Repositories;
namespace Projeto_EduXSprint2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase {
        private readonly TurmaRepository _turmaRepository;

        public TurmaController() {
            _turmaRepository = new TurmaRepository();
        }

        [HttpGet]
        public IActionResult Get() {
            try {
                var turma = _turmaRepository.Listar();


                if (turma.Count == 0)
                    return NoContent();

                return Ok(new {
                    totalCount = turma.Count,
                    data = turma
                });
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
        
        /// <summary>
        /// Fazendo Get
        /// </summary>
        /// <returns></returns>

        [HttpGet("{id}")]
        public IActionResult Get(Guid id) {
            try {
                Turma turma = _turmaRepository.BuscarPorId(id);


                if (turma == null)
                    return NotFound();


                return Ok(turma);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        //fazendo Post
        [HttpPost]
        public IActionResult Post([FromForm] Turma turma) {
            try {

                _turmaRepository.Adicionar(turma);

                return Ok(turma);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        //Fazendo o Put
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Turma turma) {
            try {
                _turmaRepository.Editar(turma);

                return Ok(turma);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        //Fazendo Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) {
            try {
                var turma = _turmaRepository.BuscarPorId(id);


                if (turma == null)
                    return NotFound();

                _turmaRepository.Remover(id);

                return Ok(id);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
