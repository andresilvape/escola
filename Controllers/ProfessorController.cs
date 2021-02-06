using Microsoft.AspNetCore.Mvc;

namespace escola.api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
        public class ProfessorController : ControllerBase{

            public ProfessorController(){}

                [HttpGet]
                public IActionResult Get(){

                    return Ok("Professores: Maria, Adriano, Socorro");
                }
            }
    }
        
