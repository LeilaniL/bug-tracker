using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

namespace BugTracker.Controllers
{
  [Route("api/[controller]")]
  public class IssuesController : Controller
  {
    private readonly BugTrackerContext _db;

    public IssuesController(BugTrackerContext db)
    {
      _db = db;
    }

    [HttpGet("[action]")]
    public IEnumerable<Issue> IssueIndex()
    {
      List<Issue> model = _db.Issues.ToList();
      return model;
    }
  }
}
