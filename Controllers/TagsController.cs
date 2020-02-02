using Microsoft.AspNetCore.Mvc;
using BugTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Controllers
{
  public class TagsController : Controller
  {
    private readonly BugTrackerContext _db;

    public TagsController(BugTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Tag> model = _db.Tags.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Tag Tag)
    {
      _db.Tags.Add(Tag);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Tag thisTag = _db.Tags.Include(tag => tag.Issues).ThenInclude(join => join.Issue).FirstOrDefault(tag => tag.TagId == id);
      return View(thisTag);
    }

    // public ActionResult Edit(int id)
    // {
    //   var thisTag = _db.Tags.FirstOrDefault(Tag => Tag.TagId == id);
    //   return View(thisTag);
    // }

    // [HttpPost]
    // public ActionResult Edit(Tag Tag)
    // {
    //   _db.Entry(Tag).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisTag = _db.Tags.FirstOrDefault(Tag => Tag.TagId == id);
    //   return View(thisTag);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisTag = _db.Tags.FirstOrDefault(Tag => Tag.TagId == id);
    //   _db.Tags.Remove(thisTag);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}