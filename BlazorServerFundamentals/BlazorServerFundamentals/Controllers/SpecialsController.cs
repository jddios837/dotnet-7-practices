using BlazorServerFundamentals.Data;
using BlazorServerFundamentals.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServerFundamentals.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly IPizzaService _pizzaService;

    public SpecialsController(IPizzaService pizzaService)
    {
        _pizzaService = pizzaService;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return await _pizzaService.GetListSpecial();
    }
}