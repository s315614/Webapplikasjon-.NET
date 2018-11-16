using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndividuellOppgave4.Models
{
    public class FAQuestions
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
    public class DBContxt : DbContext
    {
      /*  public DBContxt() :
            base("name=DatabaseEntities1")
        {
            Database.CreateIfNotExists();
         //   Database.SetInitializer(new DBInit());
        }
        public DbSet<FAQuestions> FAQuestions { get; set; } */
    } 
}