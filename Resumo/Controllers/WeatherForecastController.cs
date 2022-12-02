using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Resumo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]        
        public Pessoa Post(Pessoa usuario)
        {  


            usuario.nasc.AddYears(1);
            /*

            PESSOA GET

            Pessoa p = new Pessoa();
            p.nome = "Felpo";
            p.nasc = new DateTime(2022,08,04);
            return p;   

            */

            return usuario;
          
           
        }
    }
}
