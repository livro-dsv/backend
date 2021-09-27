using System;

namespace API.Models
{
  public class Livro 
  {
    public Livro() => CriadoEm = DateTime.Now;

    public int Id { get; set; }
    public string Titulo { get; set; }
    public double Preco { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; } 
    public DateTime CriadoEm { get; set; }

  }
}