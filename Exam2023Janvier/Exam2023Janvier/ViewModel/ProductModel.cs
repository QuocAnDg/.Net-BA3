using Exam2023Janvier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exam2023Janvier.ViewModel
{
    public class ProductModel
    {
        
    
        private readonly Product _monProduct;
        private int? _countProduct;
        private string? _country;
        public ProductModel()
        {
        }
        public ProductModel(int count, string country)
        {
            _countProduct = count;
            _country = country;
        }
        public ProductModel(Product product)
        {
            _monProduct = product;
        }
 
        public int ProductId
        {
            get { return _monProduct.ProductId; }
            set
            {
                if (_monProduct.ProductId != value)
                {
                    _monProduct.ProductId = value;
   
                }
            }
        }

        public string ProductName
        {
            get { return _monProduct.ProductName; }
            set
            {
                if (_monProduct.ProductName != value)
                {
                    _monProduct.ProductName = value;
            
                }
            }
        }
       

        public string Category
        {
            get { return _monProduct.Category.CategoryName; }
            set
            {
                if (_monProduct.ProductName != value)
                {
                    _monProduct.ProductName = value;
        
                }
            }
        }

        public string Supplier
        {
            get { return _monProduct.Supplier.ContactName; }
            set
            {
                if (_monProduct.Supplier.ContactName != value)
                {
                    _monProduct.Supplier.ContactName = value;
         
                }
            }
        }

        public string? Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;

                }
            }
        }
        public int? CountProduct
        {
            get { return _countProduct; }
            set
            {
                if (_countProduct != value)
                {
                    _countProduct = value;

                }
            }
        }


    }
}
