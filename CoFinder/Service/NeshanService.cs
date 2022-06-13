using CoFinder.Models;
using Flurl;
using Flurl.Http;

namespace CoFinder.Service
{
    public class NeshanService
    {
        public async Task<NeshanResponse> GetLatLongFromAddressAsync(string Address)
        {
            var  url = new Url("https://api.neshan.org/v4/geocoding?address="+ Address);

            NeshanResponse result = await url.WithHeader("Api-Key", "service.ofcWxjIRfyVZ21bsRErYsIX70hVC8TGqWXypn9Go").GetJsonAsync<NeshanResponse>();
            return result;
        }
    }
}
