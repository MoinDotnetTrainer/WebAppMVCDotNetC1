using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repo
{
    public class OrdersBlSP : IOrders
    {
        public AppDb _db;
        public OrdersBlSP(AppDb db)
        {
            _db = db;
        }

        public async Task AddOrders(Orders data)
        {
            string Exe = "Sp_InsertOrder @Name,@ExpiryDate,@Qty";
            List<SqlParameter> sqlParameters = new List<SqlParameter>() {
            new SqlParameter{ ParameterName="@Name",Value=data.Name},
            new SqlParameter{ ParameterName="@ExpiryDate",Value=data.ExpiryDate},
            new SqlParameter{ ParameterName="@Qty",Value=data.Qty},
            };
            await _db.Database.ExecuteSqlRawAsync(Exe, sqlParameters);
        }

        public async Task<IList<Orders>> OrdersList()
        {
            string Exe = "Sp_GetAllOrders";
            return await _db.Orders.FromSqlRaw(Exe).ToListAsync();
        }

        public async Task<Orders?> GetOrdersByID(int orderID)
        {
            var orders = await _db.Orders
                .FromSqlRaw(
                    "EXEC Sp_GetOrderByID @OrderID",
                    new SqlParameter("@OrderID", orderID))
                .ToListAsync();

            return orders.FirstOrDefault();
        }

        public async Task UpdateOrders(Orders data)
        {
            string Exe = "Sp_UpdateOrder @Name,@ExpiryDate,@Qty,@OrderID";
            List<SqlParameter> sqlParameters = new List<SqlParameter>() {
            new SqlParameter{ ParameterName="@Name",Value=data.Name},
             new SqlParameter{ ParameterName="@ExpiryDate",Value=data.ExpiryDate},
              new SqlParameter{ ParameterName="@Qty",Value=data.Qty},
               new SqlParameter{ ParameterName="@OrderID",Value=data.OrderID},
            };
            await _db.Database.ExecuteSqlRawAsync(Exe, sqlParameters);
        }

        public async Task DeleteOrders(int OrderID)
        {
            string Exe = "Sp_DeleteOrder @OrderID";
            List<SqlParameter> sqlParameters = new List<SqlParameter>() {
               new SqlParameter{ ParameterName="@OrderID",Value=OrderID}
            };
            await _db.Database.ExecuteSqlRawAsync(Exe, sqlParameters);
        }
    }
}
