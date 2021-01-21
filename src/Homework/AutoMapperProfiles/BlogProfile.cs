using AutoMapper;
using SkillTreeMVC.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.AutoMapperProfiles
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Articles, SkillTreeMVC.Domain.ViewModels.Blog.Articles>();
            CreateMap<SkillTreeMVC.Domain.ViewModels.Blog.Articles, Articles>();
        }
    }
}
