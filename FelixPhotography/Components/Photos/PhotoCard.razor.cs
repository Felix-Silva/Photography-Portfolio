using Microsoft.AspNetCore.Components;

namespace FelixPhotography.Components.Photos;

public partial class PhotoCard
{
    [Parameter, EditorRequired]
    public string Src { get; set; } = string.Empty;
    [Parameter]
    public EventCallback<string> OnClick { get; set; }
}