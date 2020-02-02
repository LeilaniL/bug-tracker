using Microsoft.AspNetCore.Mvc;
using BugTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BugTracker.Controllers
{
  public class IssuesController : Controller
  {
    private readonly BugTrackerContext _db;

    public IssuesController(BugTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Issue> model = _db.Issues.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.tagList = _db.Tags.ToList();
      return View();
    }

    [HttpPost]
    public ActionResult Create(Issue issue, int tagId)
    {
      _db.Issues.Add(issue);
      if (tagId != 0)
      {
        _db.TagIssue.Add(new TagIssue() { TagId = tagId, IssueId = issue.IssueId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Issue thisIssue = _db.Issues.FirstOrDefault(Issues => Issues.IssueId == id);
      return View(thisIssue);
    }

    // public ActionResult Edit(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
    //   ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
    //   return View(thisItem);
    // }

    // [HttpPost]
    // public ActionResult Edit(Item item)
    // {
    //   _db.Entry(item).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
    //   return View(thisItem);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
    //   _db.Items.Remove(thisItem);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}