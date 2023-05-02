using DomainLib.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Service
{
    class JobService : Service
    {
        public async Task<IEnumerable<Job>> FindJobs(string word,string cityState,int numberOfPages = 1)
        {
          HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}/api/Jobs?word={word}&cityState={cityState}&numberOfPages={numberOfPages}");

            List<Job> list = null;
            if (response.IsSuccessStatusCode)
            {
                 list = await response.Content.ReadAsAsync<List<Job>>();
            }
            return list;
        }

        public async Task<Job> GetJob(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"{BaseApiUrl}/api/Jobs/{id}");

            Job job = null;
            if (response.IsSuccessStatusCode)
            {
                job = await response.Content.ReadAsAsync<Job>();
            }
            return job;
            
        }

        public async Task<Job> AddJob(Job job)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync($"{BaseApiUrl}/api/Jobs", job);

            if (response.IsSuccessStatusCode)
            {
                job = await response.Content.ReadAsAsync<Job>();
            }
            else
            {
                job = null;
            }

            return job;
        }
    }
}
