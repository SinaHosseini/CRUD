using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

[Dapper.Contrib.Extensions.Table("dbo.Table_1")]
public class TableModel
{
    [Dapper.Contrib.Extensions.Key]
    public int Id { get; set; }
    //[Required]
    public string? Name { get; set; }

    public float Price { get; set; }

    public string? Type { get; set; }
  
}

