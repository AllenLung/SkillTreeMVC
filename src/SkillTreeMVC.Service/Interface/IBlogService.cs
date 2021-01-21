using SkillTreeMVC.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkillTreeMVC.Service.Interface
{
    public interface IBlogService
    {
        public Task<List<Articles>> FindAsync(int pageIndex, int pageSize);
    }
}
