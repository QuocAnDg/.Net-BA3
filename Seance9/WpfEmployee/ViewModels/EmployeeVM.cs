using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using WpfApplication1.ViewModels;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    public class EmployeeVM : INotifyPropertyChanged
    {
        private NorthwindContext dc = new NorthwindContext();
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private EmployeeModel _selectedEmployee;
        private ObservableCollection<EmployeeModel> _employeesList;
        private List<string> _listTitle;
        private ObservableCollection<OrderModel> _LastThreeOrders;

        private DelegateCommand _addCommand;
        private DelegateCommand _saveCommand;

        public EmployeeModel SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { _selectedEmployee = value; OnPropertyChanged("LastThreeOrders"); }
        }

     

        public DelegateCommand AddCommand
        {
            get { return _addCommand = _addCommand ?? new DelegateCommand(AddEmployee); }
        }

        public DelegateCommand SaveCommand
        {
            get { return _saveCommand = _saveCommand ?? new DelegateCommand(SaveEmployee); }
        }
        public ObservableCollection<OrderModel> LastThreeOrders
        {
            get
            {
                if (SelectedEmployee != null)
                {
                    _LastThreeOrders = loadOrders();
                    
                }
                return _LastThreeOrders;
            }

        }

        public ObservableCollection<EmployeeModel> EmployeesList
        {
            get
            {
                if (_employeesList == null)
                {
                    _employeesList = LoadEmployee();
                   
                }

                return _employeesList;
            }
        }

        private void AddEmployee()
        {
            Employee globalEmployee = new Employee();
            EmployeeModel employeeModel = new EmployeeModel(globalEmployee);
            EmployeesList.Add(employeeModel);
            SelectedEmployee = employeeModel;
        }

        private void SaveEmployee()
        {
            Employee verification = dc.Employees
                .Where(e => e.EmployeeId == SelectedEmployee.MonEmployee.EmployeeId)
                .SingleOrDefault();

            if (verification == null)
            {
                dc.Employees.Add(SelectedEmployee.MonEmployee);
            }

            dc.SaveChanges();
            MessageBox.Show("Enregistrement en base de données fait");
        }

        private ObservableCollection<EmployeeModel> LoadEmployee()
        {
            ObservableCollection<EmployeeModel> localCollection = new ObservableCollection<EmployeeModel>();
            foreach (var item in dc.Employees)
            {
                localCollection.Add(new EmployeeModel(item));
            }

            return localCollection;
        }

        private ObservableCollection<OrderModel> loadOrders()
        {
            ObservableCollection<OrderModel> localCollection = new ObservableCollection<OrderModel>();
            var query = (from Order o in dc.Orders
                         where (o.EmployeeId == SelectedEmployee.MonEmployee.EmployeeId)
                         orderby o.OrderDate descending
                         select o).ToList();



            int i = 0;
            foreach (var item in query)
            {
                decimal total = dc.OrderDetails.Where(od => od.OrderId == item.OrderId).Sum(od => od.UnitPrice);
                localCollection.Add(new OrderModel(item, total));
                i++;
                if (i == 3) break;
            }

            return localCollection;

        }
        private List<string> LoadTitleOfCourtesy()
        {
            return dc.Employees.Select(e => e.TitleOfCourtesy).Distinct().ToList();
        }

        public List<string> ListTitle
        {
            get
            {
                if (this._listTitle == null)
                {
                    _listTitle = LoadTitleOfCourtesy();
                }
                return _listTitle;
            }
        }


    }


}
