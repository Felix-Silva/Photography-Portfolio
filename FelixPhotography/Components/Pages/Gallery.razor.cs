namespace FelixPhotography.Components.Pages;

public partial class Gallery
{
    private List<string> _photoUrls = new();

    protected override async Task OnInitializedAsync()
    {
        var container = BlobServiceClient.GetBlobContainerClient("photos");
        await foreach (var blob in container.GetBlobsAsync())
        {
            _photoUrls.Add(container.GetBlobClient(blob.Name).Uri.ToString());
        }
    }

    private IEnumerable<string> GetColumn(int col) =>
        _photoUrls.Where((_, i) => i % 3 == col);

    private void OnPhotoClicked() { }
}