using FileworxObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    public class clsNews : clsFile
    {
       
        public string Category { get; set; }

        public override void Read()
        {
            base.Read();
            using (FileworxAppEntities1 entities = new FileworxAppEntities1())
            {
                var obj2 = (from p in entities.FXnews
                            where p.ID == ID
                            select p).FirstOrDefault();
                var obj3 = (from p in entities.FXCategories
                            where p.ID == obj2.Category
                            select p).FirstOrDefault();
                Category = obj3.Category;
            }

        }

        public override bool Create()
        {
            if (base.Create())
            {
                try
                {
                    using (FileworxAppEntities1 context = new FileworxAppEntities1())
                    {
                        var obj3 = (from p in context.FXCategories
                                    where p.Category == Category
                                    select p).FirstOrDefault();
                        context.FXnews.Add(new FXnew { ID = ID, Category = obj3.ID });
                        context.SaveChanges();

                    }
                    return true;
                }
                catch { return false; }
            }else { return false; }

        }

        //public override void Delete()
        //{
        //    base.Delete();
        //    using (var db = new FileworxAppEntities1())
        //    {
        //        var obj = (from p in db.FXnews
        //                   where p.ID == ID
        //                   select p).FirstOrDefault();

        //        db.FXnews.Remove(obj);
        //        db.SaveChanges();

        //    }

        //}

        public override void Update()
        {
            base.Update();

            using (var context = new FileworxAppEntities1())
            {
                var obj3 = (from p in context.FXCategories
                            where p.Category == Category
                            select p).FirstOrDefault();
                (from p in context.FXnews where p.ID == ID select p).ToList().ForEach(x => x.Category = obj3.ID);
                context.SaveChanges();
            }


        }

    }
}
