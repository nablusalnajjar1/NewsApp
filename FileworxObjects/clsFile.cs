using FileworxObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    public class clsFile : clsBusinessObject
    {
        public string Body { get; set; }

        public override void Read()
        {
            base.Read();
            using (FileworxAppEntities1 entities = new FileworxAppEntities1())
            {
                var obj2 = (from p in entities.FXFiles
                           where p.ID == ID
                           select p).FirstOrDefault();

                Body = obj2.Body;
            }

        }

        public override bool Create()
        {
         //   var isSuccess= base.Create();
            if (base.Create())
            {
                try
                {
                    using (FileworxAppEntities1 context = new FileworxAppEntities1())
                    {
                        context.FXFiles.Add(new FXFile { ID = ID, Body = Body });
                        context.SaveChanges();

                    }
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }else return false;

        }

        //public override void Delete()
        //{
        //    base.Delete();
        //    using (var db = new FileworxAppEntities1())
        //    {
        //        var obj = (from p in db.FXFiles
        //                   where p.ID == ID
        //                   select p).FirstOrDefault();

        //        db.FXFiles.Remove(obj);
        //        db.SaveChanges();

        //    }

        //}

        public override void Update()
        {
            base.Update();
           
                using (var context = new FileworxAppEntities1())
                {

                    (from p in context.FXFiles where p.ID == ID select p).ToList().ForEach(x => x.Body = Body);
                    context.SaveChanges();
                }
            

        }

    }
}
