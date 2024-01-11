using Nortwind_API.Models;
using Nortwind_API.Repositories;

namespace Northwind_API.Repositories
{
    interface IUnitOfWorkNorthwind
    {
        IRepository<Employee> EmployeesRepository { get; }

        IRepository<Order> OrdersRepository { get; }
    }
}

