using Microsoft.AspNetCore.Components;

namespace FelixPhotography.Components.Flex;

public partial class Flex
{
    [Parameter] public RenderFragment ChildContent { get; set; }

    [Parameter] public string Direction { get; set; } = "row";
    [Parameter] public string Align { get; set; } = "stretch";
    [Parameter] public string Justify { get; set; } = "flex-start";
    [Parameter] public string Gap { get; set; } = "0";
    [Parameter] public string? Margin {get; set;}
    [Parameter] public bool Wrap { get; set; }
    [Parameter] public bool FullWidth { get; set; } = false;
    [Parameter] public bool FullHeight { get; set; } = false;
    
    private string CssClass => "flex";
    
    private string Style =>
        $"display:flex;" + 
        $"flex-direction:{Direction};" +
        $"align-items:{Align};" +
        $"justify-content:{Justify};" +
        $"gap:{Gap};" +
        (Wrap ? "flex-wrap:wrap;" : "") +
        (FullWidth ? "width:full-width;" : "") +
        (FullHeight ? "height:full-height;" : "") +
        (!string.IsNullOrWhiteSpace(Margin) ? $"margin:{Margin};" : "");
}