using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using escola.api.Models;

namespace escola.api.Controllers
{

    [ApiController]
    [Route("api/[controller]")] 
        public class AlunoController : ControllerBase
        {
        public List<Aluno> Alunos = new List<Aluno>() {

                new Aluno() {
                    Id = 1,
                    Nome = "André",
                    Telefone = "884849494"
                    },
                new Aluno() {
                    Id = 2,
                    Nome = "Pedro",
                    Telefone = "884849494"
                    },
                new Aluno() {
                    Id = 3,
                    Nome = "Graça",
                    Telefone = "884849494"
                    },
               };
        public AlunoController(){ }

                [HttpGet]
                public IActionResult Get(){

                    return Ok(Alunos);
                }
            }
    }
        
