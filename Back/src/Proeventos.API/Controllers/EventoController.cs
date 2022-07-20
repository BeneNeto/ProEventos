using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back.src.Proeventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Proeventos.APi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      public IEnumerable<Evento> _Evento = new Evento[]
      {
         new Evento()
         {
            EventoID = 1,
            Local = "SP",
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
            Tema = "Curso C#",
            QtdPessoas = 250,
            Lote = "1",
            ImagemURL = "foto"
         },
         new Evento()
         {
            EventoID = 2,
            Local = "SP",
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyy"),
            Tema = "Curso C# 2",
            QtdPessoas = 150,
            Lote = "2",
            ImagemURL = "foto2"
         }
      };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
         {
           return _Evento;
         }
         
         [HttpGet("{ID}")]
        public IEnumerable<Evento> Get(int ID)
         {
           return _Evento.Where(Evento => Evento.EventoID == ID);
         }

        [HttpPost]
        public string Post()
        {
           return "Exemplo Post";
        }
        
        [HttpPut("id")]
        public string Put(int id)
        {
           return $"Exemplo Put com id = {id}";
        }
                
        [HttpDelete("id")]
        public string Delete(int id)
        {
           return $"Exemplo Put com id = {id}";
        }
    }
}
