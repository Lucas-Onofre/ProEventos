using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventosController : ControllerBase
  {
    private readonly ProEventosContext _context;
    public EventosController(ProEventosContext context)
    {
      //inicialização do construtor => atribuindo valor do param context para o campo _context.
      _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      //retornando um array de eventos :)
      return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
      //retornando um elemento específico --- FirstOrDefault -> retorna o primeiro elemento encontrado ou um valor default.
      return _context.Eventos.FirstOrDefault(evento => evento.Id == id);
    }

    [HttpPost]
    public string Post()
    {
      return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
      return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
      return $"Exemplo de Delete com id = {id}";
    }
  }
}
