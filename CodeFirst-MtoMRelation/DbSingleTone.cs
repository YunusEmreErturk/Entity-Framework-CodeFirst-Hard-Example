using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_MtoMRelation
{
    class DbSingleTone
    {
        private static UniversityContext db;
        public static UniversityContext GetInstance()
        {
            if (db==null)
            {
                db = new UniversityContext();
            }
            return db;
        }
       // UniversityContext db = DbSingleTone.GetInstance();
    }
}
