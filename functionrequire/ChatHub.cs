using System;
using System.Web;
using functionrequire.Helper;
using functionrequire.Models;
using Microsoft.AspNet.SignalR;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        DataContext db;
        public ChatHub()
        {
            db = new DataContext();
        }

        public void Send(string name, string id, string request)
        {

            // Call the addNewMessageToPage method to update clients.

            Clients.Others.addNewMessageToPage(name, id, request);

        }
        public void Update(string id, string name)
        {
            SessionHelper.UserId = id;
            Clients.Others.addNewMessageToPage2(id, name);
        }
        public void Data(string name, string request, int time)
        {
            Clients.Caller.addNewMessageToPage3(name, request, time);
        }
        public void Chatmess(string name, string mess)
        {
            Clients.All.addNewMessageToPage4(name, mess);
        }
        public void Addgrade(string name, string id)
        {
            var harkwork = db.HarkWorks.Find(id);
            if (harkwork == null)
            {
                HarkWork h = new HarkWork()
                {
                    Id = id,
                    Name = name,
                    Grade = 1
                };
                db.HarkWorks.Add(h);
                db.SaveChanges();
            }
            else
            {
                harkwork.Grade += 1;
                db.SaveChanges();
            }

        }
    }
}