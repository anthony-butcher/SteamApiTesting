namespace Steam.Data.Api
{
    public interface IWebClient
    {
        string Get(string url);
        string Post(string url, object postData);
    }
}