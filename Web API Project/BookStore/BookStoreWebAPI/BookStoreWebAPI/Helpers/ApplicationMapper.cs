﻿using AutoMapper;
using BookStoreWebAPI.Data;
using BookStoreWebAPI.Models;

namespace BookStoreWebAPI.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
