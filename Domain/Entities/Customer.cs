using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Customer:Entity<Guid>
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Address {  get; set; }
    public string Email {  get; set; }
    public string Phone { get; set; }
}
