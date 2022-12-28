using BlazorServerFundamentals.Data.Contexts;
using BlazorServerFundamentals.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerFundamentals.Data.Services;

public class PizzaService : IPizzaService
{
    private readonly PizzaStoreContext _db;

    public PizzaService(PizzaStoreContext db)
    {
        _db = db;
    }
    
    public async Task<List<PizzaSpecial>> GetListSpecial()
    {
        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}