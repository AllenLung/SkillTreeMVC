using SkillTreeMVC.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkillTreeMVC.DataAccess.Interface
{
    public interface IBlogRepo
    {
        public List<Articles> Find(int pageIndex, int pageSize);
        public Task<List<Articles>> FindAsync(int pageIndex, int pageSize);
        public Articles Find(Guid id);
        public Task<Articles> FindAsync(Guid id);
    }
}
