using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repo
{
    public class OrdersOps : IOrders
    {
        public AppDb _db;
        public OrdersOps(AppDb db)
        {
            _db = db;
        }

        public async Task AddOrders(Orders data)
        {
            await _db.Orders.AddAsync(data);  // taking to add 
            await _db.SaveChangesAsync(); // keeps on executing
        }

        public async Task<IList<Orders>> OrdersList()
        {
            return await _db.Orders.ToListAsync();
        }
    }
}
