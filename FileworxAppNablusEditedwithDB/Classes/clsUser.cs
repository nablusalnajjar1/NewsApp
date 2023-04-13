using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FileworxApp.Classes
{
    internal class clsUser : clsBusinessObject
    {
        public string FullName { get; set; }
        public string Password { get; set; }

        public override void Read()
        {
            base.Read();
            using (FileworxAppEntities1 entities = new FileworxAppEntities1())
            {
                var obj2 = (from p in entities.FXUsers
                            where p.ID == ID
                            select p).FirstOrDefault();

                FullName = obj2.FullName;
                Password= obj2.Password;
            }

        }

        public override bool Create()
        {
            //base.Create();
            if (base.Create())
            {
                try
                {
                    using (FileworxAppEntities1 context = new FileworxAppEntities1())
                     {
                        context.FXUsers.Add(new FXUser { ID = ID, FullName = FullName,Password = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Password)) });
                        context.SaveChanges();
                     }
                    return true;
                }
                catch { return false; }
            }
            else { return false; }

        }

        //public override void Delete()
        //{
        //    base.Delete();
        //    using (var db = new FileworxAppEntities1())
        //    {
        //        var obj = (from p in db.FXUsers
        //                   where p.ID == ID
        //                   select p).FirstOrDefault();

        //        db.FXUsers.Remove(obj);
        //        db.SaveChanges();

        //    }
        //}

        public override void Update()
        {
            base.Update();

            using (var context = new FileworxAppEntities1())
            {
                (from p in context.FXUsers where p.ID == ID select p).ToList().ForEach(x => x.FullName = FullName);
                (from p in context.FXUsers where p.ID == ID select p).ToList().ForEach(x => x.Password = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Password)));
                context.SaveChanges();
            }
        }
    }
}
