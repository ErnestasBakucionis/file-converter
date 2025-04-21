using Microsoft.AspNetCore.Components;

namespace FileConverterApp.Components.Pages;

public partial class Error : ComponentBase
{
    [Parameter] public int Code { get; set; }
}
