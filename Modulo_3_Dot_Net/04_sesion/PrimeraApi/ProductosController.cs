using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")] // api/productos
public class ProductosController : ControllerBase
{

    //Aqui es la lectura de datos desde la DB
    public static readonly List<Producto> _datos = new()
    { 
        new Producto {id = 1, nombre = "PS5", precio = 10500.0m},
        new Producto {id = 2, nombre = "Silla Gamer", precio = 5300.0m}
    };

    /*  DELETE */ // DELETE /api/productos/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id){
        var product = _datos.FirstOrDefault(x => x.id == id);
        if(product == null) return NotFound();

        _datos.Remove(product);
        return NoContent();
    }


    /*  UPDATE */ // PUT    --> api/productos/{id}
    [HttpPut("{id}")]
    public IActionResult Update(int id,Producto producto){

        var product = _datos.FirstOrDefault(x => x.id == id);
        if(product == null) return NotFound();

        product.nombre = producto.nombre;
        product.precio = producto.precio;

        return NoContent();
    }


    /*  CREATE */
    [HttpPost] //POST   --> api/productos
    public ActionResult <Producto> Create(Producto producto){
        producto.id = _datos.Max(x => x.id) + 1;
        _datos.Add(producto);
        return CreatedAtAction(nameof(GetById), new {id = producto.id}, producto);
    }

    /*  READ */
    [HttpGet] //GET  --> api/productos
    public ActionResult <IEnumerable<Producto>> GetAll(){
        return Ok(_datos);
    }

    [HttpGet("{id}")] // GET    --> api/productos/{id}
    public ActionResult <Producto> GetById(int id){
        var product = _datos.FirstOrDefault(x => x.id == id);
        if (product == null) return NotFound();
        return Ok(product);
    }

}

// Modelo producto
public class Producto{
    public int id { get; set; }
    public string nombre { get; set; } = string.Empty;
    public decimal precio { get; set; }

}