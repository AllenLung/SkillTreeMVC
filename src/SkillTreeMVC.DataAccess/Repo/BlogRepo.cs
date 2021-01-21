using Microsoft.EntityFrameworkCore;
using SkillTreeMVC.DataAccess.Data;
using SkillTreeMVC.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTreeMVC.DataAccess.Repo
{
    public class BlogRepo : IBlogRepo
    {
        private readonly BlogDbContext _context;

        public BlogRepo(BlogDbContext context)
        {
            _context = context;
        }

        public List<Articles> Find(int pageIndex, int pageSize)
        {
            var article = _context.Articles.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            return article;
        }

        public async Task<List<Articles>> FindAsync(int pageIndex, int pageSize)
        {
            var article = await _context.Articles.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
            return article;
        }

        public Articles Find(Guid id)
        {
            var article = _context.Articles.Find(id);
            return article;
        }

        public async Task<Articles> FindAsync(Guid id)
        {
            var article = await _context.Articles.FindAsync(id);
            return article;
        }
    }
}
