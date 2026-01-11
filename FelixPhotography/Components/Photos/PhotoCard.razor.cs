using Microsoft.AspNetCore.Components;

namespace FelixPhotography.Components.Photos;

public partial class PhotoCard
{
    [Parameter, EditorRequired]
    public string Src { get; set; } = string.Empty;
}