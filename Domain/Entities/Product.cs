using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Product:Entity<Guid>
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } 
    public int Price { get; set; }
    public string Category { get; set; }
    public string ImageUrl { get; set; }
}
