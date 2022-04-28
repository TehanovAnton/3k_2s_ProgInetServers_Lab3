using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace lab3_mvc.Controllers
{
    public class DictController : Controller
    {
        IPhoneDictionary<DictRecord> phoneDictionary;

        public DictController(IPhoneDictionary<DictRecord> phoneDictionary)
        {
            this.phoneDictionary = phoneDictionary;
        }

        [HttpGet]
        public ActionResult Index()
        {
            //DB db = new DB();            
            ViewBag.dicts = phoneDictionary.GetAll();
            return View();
        }



        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSave(string lastName, string number)
        {
            phoneDictionary.AddRecord(new DictRecord(lastName, number));
            return Redirect("/Dict/Index");
        }



        [HttpGet]
        public ActionResult Update(int id)
        {
            DB db = new DB();
            ViewBag.record = db.Find(id);
            return View();
        }
        public ActionResult UpdateSave(int id, string lastName, string number)
        {
            DictRecord dictRecord = phoneDictionary.Find(id);
            phoneDictionary.UpdateRecord(dictRecord, lastName, number);
            //db.Update(id, lastName, number);
            return Redirect("/Dict/Index");
        }



        [HttpGet]
        public ActionResult Delete(int id)
        {
            DB db = new DB();
            ViewBag.record = db.Find(id);
            return View();
        }
        public ActionResult DeleteSave(int id)
        {
            phoneDictionary.DeleteElement(id);
            //db.Delete(id);
            return Redirect("/Dict/Index");
        }


        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}