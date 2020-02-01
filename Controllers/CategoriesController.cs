using Microsoft.AspNetCore.Mvc;
using BugTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Controllers
{
  public class CategoriesController : Controller
  {
    private readonly BugTrackerContext _db;

    public CategoriesController(BugTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Category> model = _db.Categories.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Category category)
    {
      _db.Categories.Add(category);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // public ActionResult Details(int id)
    // {
    //   Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   // ViewBag.Items = _db.Items.Where(item => item.CategoryId == id);
    //   List<Issue> foundIssues = new List<Issue>(_db.Issues.Where(item => item.CategoryId == id));
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   model.Add("Category", thisCategory);
    //   model.Add("Issues", foundIssues);
    //   return View(model);
    // }

    // public ActionResult Edit(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // [HttpPost]
    // public ActionResult Edit(Category category)
    // {
    //   _db.Entry(category).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   _db.Categories.Remove(thisCategory);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}