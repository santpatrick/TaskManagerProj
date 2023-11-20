using API.models;
using Microsoft.AspNetCore.Mvc;

namespace API.controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;
        public UsuarioController(DataContext context) =>
        _context = context;

        // GET: /api/funcionario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Usuarios.ToList());
        
        // POST: /api/usuario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
        }
        // GET: /api/usuario/buscar/{id}
        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            return usuario != null ? Ok(usuario) : NotFound();
        } 
        // DELETE: /api/usuario/deletar/{id}
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
                return Ok(usuario);
            }
            return NotFound();
        }
         // PATCH: /api/usuario/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Usuario usuario)
        {
            try
            {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
                return Ok(usuario);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}