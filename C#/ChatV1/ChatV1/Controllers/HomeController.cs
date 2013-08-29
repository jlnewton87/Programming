using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChatV1.Models;

namespace ChatV1.Controllers
{
    public class HomeController : Controller
    {

        List<Message> messages;
        int messageIndex = 1;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string AddMessage(string jsonMessage)
        {
            string response = jsonMessage;
            using (MessageContext context = new MessageContext())
            {
                context.Messages.Add(new Message
                {
                    Text = jsonMessage
                });
                context.SaveChanges();
            }
            return response;
        }

    }
}
