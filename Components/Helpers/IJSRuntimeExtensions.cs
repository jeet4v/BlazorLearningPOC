using Microsoft.JSInterop;

namespace BlazorLearningPOC.Components.Helpers
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime jsRuntime, string strMessage)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "success", strMessage);
        }

        public static async Task ToastrError(this IJSRuntime jsRuntime, string strMessage)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "error", strMessage);
        }

    }
}
