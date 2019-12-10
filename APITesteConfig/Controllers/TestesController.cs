using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace APITesteConfig.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestesController : ControllerBase
    {
        private static Guid _VALOR_REFERENCIA = Guid.NewGuid();

        [HttpGet]
        public object Get([FromServices]IConfiguration configuration)
        {
            return new
            {
                Horario = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                ValorReferencia = _VALOR_REFERENCIA.ToString(),
                ValorTesteConfig = configuration["ValorTesteConfig"]
            };
        }
    }
}