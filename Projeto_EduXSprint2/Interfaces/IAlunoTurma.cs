using Projeto_EduXSprint2.Domains;
using System;
using System.Collections.Generic;

namespace Projeto_EduXSprint2.Interfaces {
    interface IAlunoTurma {
        List<AlunoTurma> Listar();
        AlunoTurma BuscarPorId(Guid id);
        List<AlunoTurma> BuscarPorNome(string nome);
        void Adicionar(AlunoTurma alunoturma);
        void Editar(AlunoTurma alunoturma);
        void Remover(Guid id);
    }
}
