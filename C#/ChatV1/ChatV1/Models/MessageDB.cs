using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChatV1.Models
{
    public class Message
    {
        public int Id{get;set;}
        public string Text{get;set;}
    }

    public class MessageContext : DbContext
    {
        public DbSet<Message> Messages {get;set;}
    }
}