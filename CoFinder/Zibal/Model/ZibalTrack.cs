namespace CoFinder.Zibal.Model
{
    public class ZibalTrack
    {
        public string merchant { get; set; } = "zibal";
        public string callbackUrl { get; set; } = "https://localhost:7172/ZibalCallBack";
        public string description { get; set; } = "desc";
        public string orderId { get; set; } = "0000";
        public string mobile { get; set; } = "09121111111";
        public int amount { get; set; } = 100000;
    }
}
