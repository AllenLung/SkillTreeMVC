using SkillTreeMVC.DataAccess.Data;
using SkillTreeMVC.DataAccess.Interface;
using SkillTreeMVC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkillTreeMVC.Service
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepo _repository;

        public BlogService(IBlogRepo repository)
        {
            _repository = repository;
        }

        public async Task<List<Articles>> FindAsync(int pageIndex, int pageSize)
        {
            var article = await _repository.FindAsync(pageIndex, pageSize);
            return article;
        }
    }
}
