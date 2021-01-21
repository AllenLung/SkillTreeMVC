using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkillTreeMVC.Domain.ViewModels.Blog;
using SkillTreeMVC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        private readonly IBlogService _service;
        private readonly IMapper _mapper;

        public ArticleViewComponent(IBlogService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int pageIndex, int pageSize)
        {
            var articles = await _service.FindAsync(pageIndex, pageSize);
            return View(_mapper.Map<List<Articles>>(articles));
        }
    }
}
