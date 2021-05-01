using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_API.Data
{
    /// <summary>
    /// Scaffold-DbContext "Server=.;Database=BookStore;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data
    /// </summary>
    [Table("Authors")]
    public partial class Author
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
        public virtual IList<Book> Books { get; set; }
    }
}