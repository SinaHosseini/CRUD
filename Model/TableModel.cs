using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Collections.Generic;
using System.Data;

[Dapper.Contrib.Extensions.Table("dbo.Table_1")]
public class TableModel
{
    [Dapper.Contrib.Extensions.Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage ="لطفا نام محصول را وارد کنید.")]
    public string? Name { get; set; }
    [Range(1, int.MaxValue, ErrorMessage ="لطفا قیمت محصول را وارد کنید.")]
    public int Price { get; set; }
    [Range(1, int.MaxValue, ErrorMessage ="لطفا نوع محصول را تعیین کنید.")]
    public int? IdType { get; set; }
    public DateTime TimeAdd { get; set; }
    public DateTime? TimeUpdate { get; set; }
}

