using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using ProAgil.WEB.API.Model;

namespace ProAgil.WEB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Events>> Get()
        {
            return new Events[] {
                new Events()
                {
                    EventsId = 1,
                    Tema = "Curso Angular e .NET Core",
                    Local = "Lages - Santa Catarina",
                    Lote = "1º Lote",
                    QuantidadePessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Events()
                {
                    EventsId = 2,
                    Tema = "Curso Angular e suas Novidades",
                    Local = "Florianópolis - Santa Catarina",
                    Lote = "2º Lote",
                    QuantidadePessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }


            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
