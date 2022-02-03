using ApplicationCore.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Models
{
    [Table("Makes")]
    public class Make : BaseEntity
    {
        public Make( string name)
        {

            Name = name;
            
        }

        [Required]
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; private set; }

        internal void UpdateData(string name)
        {
            throw new NotImplementedException();
        }
    }
}
