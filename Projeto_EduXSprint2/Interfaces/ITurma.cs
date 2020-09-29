using Projeto_EduXSprint2.Domains;
using System;
using System.Collections.Generic;

namespace Projeto_EduXSprint2.Interfaces {
    interface ITurma {
        interface ITurma {
            List<Turma> Listar();
            Turma BuscarPorId(Guid id);
            List<Turma> BuscarPorNome(string nome);
            void Adicionar(Turma turma);
            void Editar(Turma turma);
            void Remover(Guid id);
        }
    }
}
