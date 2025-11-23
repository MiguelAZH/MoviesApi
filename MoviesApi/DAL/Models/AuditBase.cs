using System.ComponentModel.DataAnnotations;

namespace MoviesApi.DAL.Models
{
    public class AuditBase
    {
        [Key] // Primary Key
        public virtual int Id { get; set; }

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
