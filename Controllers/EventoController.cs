using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() {
                    EventoId = 1, Tema = "Angular 11 e .NET 5", Local = "Belo Horizonte", Lote = "1º Lote", QtdPessoas = 250, DataEvento = DateTime.Now.AddDays(2).ToString(), ImagemURL = "imagem.png"
                },
                new Evento() {
                    EventoId = 2, Tema = "Angular e suas novidades", Local = "São Paulo", Lote = "2º Lote", QtdPessoas = 300, DataEvento = DateTime.Now.AddDays(7).ToString(), ImagemURL = "imagem.png"
                },
            };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo de Put, id = "+id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Exemplo de Delete, id = " + id;
        }
    }
}
