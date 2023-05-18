using adstra_task.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace adstra_task.Data.SqlServerEF
{
   public  class AuthorsEntity : IDataHelper<Authors>
    {
        private EDbContext db;
        private Authors _table;
        public AuthorsEntity()
        {
            db = new EDbContext();


        }
        public int Add(Authors table)
        {
            if(db.Database.CanConnect())
            {
                db.Authors.Add(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Delete(int Id)
        {

            if (db.Database.CanConnect())
            {
                _table = Find(Id);
                db.Authors.Remove(_table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(int Id, Authors table)
        {
            db = new EDbContext();

            if (db.Database.CanConnect())
            {
                db.Authors.Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Authors Find(int Id)
        {
            if (db.Database.CanConnect())
            {
                return db.Authors.Where(x => x.Id == Id).First();
            }
            else
            {
                return null;
            }
        }

        public List<Authors> GetAllData()
        {
            if (db.Database.CanConnect())
            {
                return db.Authors.ToList();
            }
            else
            {
                return null;
            }
        }

        public List<Authors> GetDataByUser(string UserId)
        {
            throw new NotImplementedException();
        }

        public List<Authors> Search(string SearchItem)
        {
            if (db.Database.CanConnect())
            {
                return db.Authors.Where(x => x.FullName.Contains(SearchItem)
              || x.UserId.ToString().Contains(SearchItem)
              || x.Bio.Contains(SearchItem)
              || x.FaceBook.Contains(SearchItem)
              || x.Instgram.Contains(SearchItem)
              || x.Twitter.Contains(SearchItem)
              || x.Id.ToString().Contains(SearchItem)).ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
