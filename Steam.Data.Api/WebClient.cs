namespace Steam
{
    using System;
    using System.IO;
    using System.Net;
    using Steam.Data.Api;

    public class WebClient : IWebClient
    {
        public string Get(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

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

        public string Post(string url, object postData)
        {
            throw new NotImplementedException();
        }
    }
}