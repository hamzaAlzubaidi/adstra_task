using adstra_task.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace adstra_task.Data.SqlServerEF
{
    public class AuthorPostEntity : IDataHelper<AuthorPost>
    {
        private EDbContext db;
        private AuthorPost _table;

        public AuthorPostEntity()
        {
            db = new EDbContext();
        }
        public int Add(AuthorPost table)
        {
            if (db.Database.CanConnect())
            {
                db.authorPosts.Add(table);
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
                db.authorPosts.Remove(_table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(int Id, AuthorPost table)
        {
            db = new EDbContext();

            if (db.Database.CanConnect())
            {
                db.authorPosts.Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public AuthorPost Find(int Id)
        {
            if (db.Database.CanConnect())
            {
                return db.authorPosts.Where(x => x.Id == Id).First();
            }
            else
            {
                return null;
            }
        }

        public List<AuthorPost> GetAllData()
        {
            if (db.Database.CanConnect())
            {
                return db.authorPosts.ToList();
            }
            else
            {
                return null;
            }
        }

        public List<AuthorPost> GetDataByUser(string UserId)
        {
            if (db.Database.CanConnect())
            {
                return db.authorPosts.Where(x => x.UserId == UserId).ToList();
            }
            else
            {
                return null;
            }
        }

        public List<AuthorPost> Search(string SearchItem)
        {
            if (db.Database.CanConnect())
            {
                return db.authorPosts.Where(x => x.FullName.Contains(SearchItem) || x.Id.ToString().Contains(SearchItem)
                ||x.UserId.Contains(SearchItem)
                ||x.UserName.Contains(SearchItem)
                ||x.PostTitle.Contains(SearchItem)
                ||x.PostDescraption.Contains(SearchItem)
                ||x.AuthorId.ToString().Contains(SearchItem)
                ||x.CategoryId.ToString().Contains(SearchItem)
                ||x.postCategory.Contains(SearchItem)
                ||x.PostImageUrl.Contains(SearchItem)
                ||x.AddedDate.ToString().Contains(SearchItem)

                ).ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
