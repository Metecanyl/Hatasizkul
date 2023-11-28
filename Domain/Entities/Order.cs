using Core.Persistence.Repositories;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Order:Entity<Guid>
{
    public string DeliveryAddress { get; set; }
    public DateTime OrderDate { get; set; }
    public string  Items { get; set; }
    public string TotalAmount { get; set; }
    public OrderState Status { get; set; }

}
