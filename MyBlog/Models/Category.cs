using System;
using System.Collections.Generic;

namespace MyBlog.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? DisplayIndex { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
