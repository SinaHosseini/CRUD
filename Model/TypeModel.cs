using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Type.Models
{
    [Dapper.Contrib.Extensions.Table("dbo.Table_2")]
    public class TypeModel
    {
        [Dapper.Contrib.Extensions.Key]
        public int IdType { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string? NameType { get; set; }
    }
}