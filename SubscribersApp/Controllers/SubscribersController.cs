using SubscribersApp.Core.Contracts.Services;
using SubscribersApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubscribersApp.Controllers
{
    public class SubscribersController : Controller
    {
        private readonly ISubscriberService _subscriberService;

        public SubscribersController(ISubscriberService subscriberService)
        {
            this._subscriberService = subscriberService;
        }

        // GET: Subscribers
        public ActionResult Index()
        {
            var model = this._subscriberService.GetAll();


            return View(model);
        }

        // GET: Subscribers/Details/5
        public ActionResult Details(int id)
        {
            var model = this._subscriberService.GetById(id);
            return View(model);
        }

        // GET: Subscribers/Create
        public ActionResult Create()
        {
            var model = new Subscriber();
            return View(model);
        }

        // POST: Subscribers/Create
        [HttpPost]
        public ActionResult Create(Subscriber subscriber)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _subscriberService.Insert(subscriber);
                    return RedirectToAction("Index");
                }

                return View(subscriber);
            }
            catch
            {
                return View();
            }
        }

        // GET: Subscribers/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _subscriberService.GetById(id);
            return View(model);
        }

        // POST: Subscribers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Subscriber subscriber)
        {
            try
            {
                var editedSubscriber = _subscriberService.GetById(id);

                editedSubscriber.Name = subscriber.Name;
                editedSubscriber.HomeAddress = subscriber.HomeAddress;

                _subscriberService.Update(editedSubscriber);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Subscribers/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _subscriberService.GetById(id);
            return View(model);
        }

        // POST: Subscribers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Subscriber subscriber)
        {
            try
            {
                var subscriberToDelete = _subscriberService.GetById(id);
                _subscriberService.Delete(subscriber);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
