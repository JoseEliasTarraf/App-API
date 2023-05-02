using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace JobSearch.Service
{
    public abstract class Service
    {
        protected HttpClient _client;
        protected string BaseApiUrl = "https://apijobsearch.azurewebsites.net/";

        public Service()
        {
            _client = new HttpClient();
        }
    }
}
