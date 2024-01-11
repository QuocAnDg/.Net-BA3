using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    public class OrderModel
    {
        private readonly Order _monOrder;
        private decimal total = 0;
        public OrderModel(Order monOrder, decimal total)
        {
            _monOrder = monOrder;
            this.total = total;
        }
        public Order MonOrder
        {
            get { return _monOrder; }
        }
        public int OrderId
        {
            get { return _monOrder.OrderId; }
        }
        public DateTime? DateOrder
        {
            get { return _monOrder.OrderDate; }
        }
        public String DisplayDateOrder
        {
            get
            {
                if (_monOrder.OrderDate.HasValue)
                {
                    return _monOrder.OrderDate.Value.ToShortDateString();
                }

                return "";
            }
        }
        public String OrderTotal
        {
            get
            {
                return total.ToString();

            }
        }

    }
}
