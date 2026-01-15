using Microsoft.AspNetCore.Components;

namespace FelixPhotography.Components.Flex;

public partial class Flex
{
    [Parameter] public RenderFragment? ChildContent { get; set; }

    [Parameter] public string Direction { get; set; } = "row";
    [Parameter] public string Align { get; set; } = "stretch";
    [Parameter] public string Justify { get; set; } = "flex-start";
    [Parameter] public string Gap { get; set; } = "0";
    [Parameter] public string? Margin {get; set;}
    [Parameter] public bool Wrap { get; set; }
    [Parameter] public string? Width { get; set; }
    [Parameter] public string? Height { get; set; }
    [Parameter] public string? MinWidth { get; set; }
    [Parameter] public string? MinHeight { get; set; }
    [Parameter] public string? MaxWidth { get; set; }
    [Parameter] public string? MaxHeight { get; set; }
    [Parameter] public string Color { get; set; } = "";

    private string CssClass => "flex";
    
    private string Style =>
        $"display:flex;" +
        $"flex-direction:{Direction};" +
        $"align-items:{Align};" +
        $"justify-content:{Justify};" +
        $"gap:{Gap};" +
        (Wrap ? "flex-wrap:wrap;" : "") +
        (!string.IsNullOrWhiteSpace(Width) ? $"width:{Width};" : "") +
        (!string.IsNullOrWhiteSpace(Height) ? $"height:{Height};" : "") +
        (!string.IsNullOrWhiteSpace(MinWidth) ? $"min-width:{MinWidth};" : "") +
        (!string.IsNullOrWhiteSpace(MinHeight) ? $"min-height:{MinHeight};" : "") +
        (!string.IsNullOrWhiteSpace(MaxWidth) ? $"max-width:{MaxWidth};" : "") +
        (!string.IsNullOrWhiteSpace(MaxHeight) ? $"max-height:{MaxHeight};" : "") +
        (!string.IsNullOrWhiteSpace(Margin) ? $"margin:{Margin};" : "") +
        (!string.IsNullOrWhiteSpace(Color) ? $"background-color:{Color};" : "");

}