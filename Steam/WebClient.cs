namespace Steam
{
    using System;
    using System.IO;
    using System.Net;
    using Steam.Models;

    public class WebClient
    {
        public string ApiKey = "8D8B2DAFA0C7A5F0DA2B4FA32548A006";

        public string QueryApi(ApiInterfaces apiInterface, ApiMethods method, Enums game, string steamId)
        {
            var url = String.Format("{0}/{1}/{2}?appid={3}&key={4}&steamid={5}",
                Constants.ApiBaseUrl,
                EnumAdapters.AdaptApiInterface(apiInterface),
                EnumAdapters.AdaptApiMethod(method),
                (int)game,
                this.ApiKey,
                steamId);

            return this.GetResponse(url);
        }

        private string GetResponse(string url)
        {
            var request = (HttpWebRequest) WebRequest.Create(url);

            request.Method = "GET";
            request.ContentLength = 0;
            request.ContentType = "application/json";

            StreamReader streamReader = null;
            Stream responseStream = null;

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    streamReader = new StreamReader(responseStream);
                }

                if (streamReader != null)
                {
                    return streamReader.ReadToEnd();
                }

                return "";
            }
            catch (WebException exception)
            {
                HttpWebResponse errorResponse = (HttpWebResponse)exception.Response;

                if (null == errorResponse)
                {
                    throw;
                }

                responseStream = errorResponse.GetResponseStream();
                streamReader = new StreamReader(responseStream);

                throw new WebException(streamReader.ReadToEnd(), exception);
            }
        }
    }
}