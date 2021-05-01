using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Data.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class BookDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [Table("Books")]
        public partial class Book
        {
            /// <summary>
            /// 
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// 
            /// </summary>

            public string Title { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int? Year { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string Isbn { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string Summary { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string Image { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public double? Price { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int? AuthorId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public virtual AuthorDTO Author { get; set; }

        }
    }
}
