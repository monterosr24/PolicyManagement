﻿using AutoMapper;
using PolicyManagement.Models.Mapper;
using System.Data.Entity;
using System.Web.Mvc;

namespace PolicyManagement.Utilis
{
    public static class ServicesResolver
    {
        public static void RegistreServices<T>(NinjectResolver<T> ninjectResolver) 
            where T: DbContext
        {
            DependencyResolver.SetResolver(ninjectResolver);
            Map();
        }

        private static void Map()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
        }
    }
}