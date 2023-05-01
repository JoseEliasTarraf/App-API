using Api.Database;
using DomainLib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private int numberOfRegistryByPage = 5;

        private JobSearchContext _data;

        public JobsController(JobSearchContext data)
        {
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Job> FindJobs(string word, string cityState,int numberOfPages = 1)
        {

            if(word == null)
            {
                word = "";
            }
            if(cityState == null)
            {
                cityState = "";
            }

             return _data.Jobs
                .Where(a =>
                    a.PubDate >= DateTime.Now.AddDays(-15) &&
                    a.CityState.ToLower().Contains(cityState.ToLower()) &&
                    (
                        a.JobTitle.ToLower().Contains(word.ToLower()) ||
                        a.TecnologyTools.ToLower().Contains(word.ToLower()) ||
                        a.Company.ToLower().Contains(word.ToLower())
                    )
                )
                .Skip(numberOfRegistryByPage * (numberOfPages - 1))
                .Take(numberOfRegistryByPage)
                .ToList();
        }

        [HttpGet ("{id}")]
        public IActionResult GetJob(int id)
        {
            Job Jobdb = _data.Jobs.Find(id);

            if(Jobdb == null)
            {
                return NotFound();
            }
            return new JsonResult(Jobdb);
        }

        [HttpPost]
        public IActionResult AddJob(Job job)
        {
            job.PubDate = DateTime.Now;
            _data.Jobs.Add(job);
            _data.SaveChanges();

            return CreatedAtAction("GetJob", new { id = job.Id }, job);
        }
    }
}
