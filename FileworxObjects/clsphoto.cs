using FileworxObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    public class clsphoto : clsFile
    {
        public string PhotoPath { get; set; }

        public override void Read()
        {
            base.Read();
            using (FileworxAppEntities1 entities = new FileworxAppEntities1())
            {
                var obj2 = (from p in entities.FXPhotoes
                            where p.ID == ID
                            select p).FirstOrDefault();

                PhotoPath = obj2.PhotoPath;
            }
        }

        public override bool Create()
        {
           // base.Create();

            if (base.Create())
            {
                try
                {
                    using (var context = new FileworxAppEntities1())
                {
                    context.FXPhotoes.Add(new FXPhoto {ID = ID, PhotoPath = PhotoPath });
                    context.SaveChanges();
                    }
                    return true;
                }
                catch { return false; }
            }
            else { return false; }


        }

        public override void Update()
        {
           base.Update();
                using (var context = new FileworxAppEntities1())
                {
                    (from p in context.FXPhotoes where p.ID == ID select p).ToList().ForEach(x => x.PhotoPath = PhotoPath);
                    context.SaveChanges();
                }
            

        }

        //public override void Delete()
        //{
        //    base.Delete();
        //    using (var db = new FileworxAppEntities1())
        //    {
        //        var obj = (from p in db.FXPhotoes
        //                   where p.ID == ID
        //                   select p).FirstOrDefault();

        //        db.FXPhotoes.Remove(obj);
        //        db.SaveChanges();

        //    }

        //}

    }
}
