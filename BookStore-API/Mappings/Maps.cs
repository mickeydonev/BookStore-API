using AutoMapper;
using BookStore_API.Data;
using BookStore_API.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Mappings
{
    /// <summary>
    /// 
    /// </summary>
    public class Maps :Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public Maps()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();

        }
    }
}
