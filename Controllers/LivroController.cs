using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Data;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers 
{
  [ApiController]
  [Route("api/livro")]

  public class LivroController : ControllerBase
  { 
    private readonly DataContext _context;
    public LivroController(DataContext context)
    {
      _context = context;
    }

    // POST: api/livro
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateAsync([FromBody] Livro livro)
    {
      await _context.Livros.AddAsync(livro);
      await _context.SaveChangesAsync(); 
      return Created("", livro);
    }

    // GET: api/livro
    [HttpGet]
    [Route("list")]
    public async Task<IActionResult> ListAsync()
    {
      return Ok(await _context.Livros.ToListAsync());
    }
  }
}