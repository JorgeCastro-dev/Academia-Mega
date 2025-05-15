
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class SaludoController : ControllerBase
{
    // GET --> /saludo
    [HttpGet]
    public IActionResult Get() 
    {
        return Ok(new { mensaje = "Hola desde el SaludoController" });
    }

    // GET /saludo/personalizado{name}
    [HttpGet("personalizado/{name}")]
    public IActionResult GetPersonalizado(string name)
    {
        var respuesta = new {
            mensaje = $"Holaa {name}",
        };

        
    return Ok(respuesta);

    }
}