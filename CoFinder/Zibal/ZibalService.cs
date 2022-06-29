using CoFinder.Zibal.Model;
using Flurl;
using Flurl.Http;

namespace CoFinder.Zibal
{
    public class ZibalService
    {
        public string GetZibalTrackId(string price)
        {
            var zibal = new ZibalTrack()
            {
                amount = Convert.ToInt32(price),
                callbackUrl = "https://localhost:7172/ZibalCallBack",
                merchant = "zibal",
                description = "desc",
                mobile = "09121111111",
                orderId = "2020"

            };

            var flurlResponse = "https://gateway.zibal.ir/v1/request".PostJsonAsync(zibal).ReceiveJson<ZibalTrackResponse>();
            var res = flurlResponse.Result.trackId.ToString();
            return res;

        }

    }
}
