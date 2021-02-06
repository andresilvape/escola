using System.Collections.Generic;
namespace escola.api.Models

{
    public class Aluno
    {   
        public Aluno(){}

        public Aluno(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Telefone { get; internal set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas{get; set;}
       
    }
}