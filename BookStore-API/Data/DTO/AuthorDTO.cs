using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Data.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthorDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Bio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IList<BookDTO> Books { get; set; }
    }
}

