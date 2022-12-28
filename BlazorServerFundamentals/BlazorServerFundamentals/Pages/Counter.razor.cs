using Microsoft.AspNetCore.Components;

namespace BlazorServerFundamentals.Pages;

public partial class Counter : ComponentBase
{
    private int currentCount = 0;
    [Parameter] public int IncrementAmount { get; set; } = 1;

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
    }
}