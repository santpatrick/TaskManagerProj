using API.models;
using Microsoft.AspNetCore.Mvc;

namespace Api.controllers
{
    [ApiController]
    [Route("api/status")]
    public class StatusController : ControllerBase
    {
        private readonly DataContext _context;
        public StatusController(DataContext context) =>
        _context = context;
    }

    //GET : api/status/listar
    [HttpGet]
    [Route("listar")]

    public IActionResult Listar => 


}