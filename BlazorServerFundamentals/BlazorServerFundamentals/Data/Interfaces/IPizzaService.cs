namespace BlazorServerFundamentals.Data.Interfaces;

public interface IPizzaService
{
    public Task<List<PizzaSpecial>> GetListSpecial();
}