using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Irepo
{
    public interface IOrders
    {
        // Insertt ops on AddOrders
        // asyn await task--> async programming

        Task AddOrders(Orders data);

        Task<IList<Orders>> OrdersList();
    }
}
