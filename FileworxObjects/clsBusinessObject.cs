using FileworxObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    public class clsBusinessObject
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string LastModifier { get; set; }
        public int ClassID { get; set; }

       
        public virtual void Read()
        {
            using(var entities = new FileworxAppEntities1())
            {
                var obj = (from p in entities.BusinessObjects
                           where p.ID == ID
                           select p).FirstOrDefault();
                Name = obj.Name;
                Description = obj.Description;
                CreationDate = obj.CreationDate;
                ClassID = obj.ClassID;
                LastModifier = obj.LastModifier;
            }
        }

        public virtual bool Create()
        {
            try
            {
                using (var context = new FileworxAppEntities1())
                {
                    context.BusinessObjects.Add(new BusinessObject
                    {
                        ID = ID,
                        Name = Name,
                        Description = Description,
                        CreationDate = CreationDate,
                        LastModifier = LastModifier,
                        ClassID = ClassID,

                    });
                    context.SaveChanges();

                }
                return true;
            }
            catch
            {
                return false;
            } 

        }

        public virtual void Delete()
        {
         
            using (var db = new FileworxAppEntities1())
            {
                var obj = (from p in db.BusinessObjects
                           where p.ID == ID
                           select p).FirstOrDefault();

                db.BusinessObjects.Remove(obj);
                db.SaveChanges();

            }

        }
        public virtual void Update()
        {
            using (FileworxAppEntities1 entities = new FileworxAppEntities1())
            {

                using (var context = new FileworxAppEntities1())
                {
                    (from p in context.BusinessObjects where p.ID == ID select p).ToList().ForEach(x => x.Name = Name);
                    (from p in context.BusinessObjects where p.ID == ID select p).ToList().ForEach(x => x.Description = Description);
                    (from p in context.BusinessObjects where p.ID == ID select p).ToList().ForEach(x => x.LastModifier = LastModifier);
                    context.SaveChanges();
                }
            }

        }
    }
}
