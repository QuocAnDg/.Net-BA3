using Seance6_recap.Entities;
using Seance6_recap.Repositories;

namespace Seance6_recap.UnitOfWorks
{
    interface IUnitOfWorkNorthwind
    {
        IRepository<Employee> EmployeesRepository { get; }

        IRepository<Order> OrdersRepository { get; }
    }
}