using Microsoft.AspNetCore.Mvc;
using DemoEFCoreWebApi.Models;

namespace DemoEFCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogoController : ControllerBase
{


    private readonly ILogger<CatalogoController> _logger;

    public CatalogoController(ILogger<CatalogoController> logger)
    {
        _logger = logger;
    }

}
