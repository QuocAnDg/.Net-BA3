using Exam2023Janvier.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication1.ViewModels;

namespace Exam2023Janvier.ViewModel
{
    internal class ProductVM
    {

        private NorthwindContext dc = new NorthwindContext();
        private ObservableCollection<ProductModel> _ProductList;
        private ProductModel _selectedProduct;

        private DelegateCommand _deleteProduct;

        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; }
        }


        public ObservableCollection<ProductModel> ProductsList
        {
            get
            {
                if (_ProductList == null)
                {
                    _ProductList = LoadProducts();
                }
                return _ProductList;
            }
        }

        private ObservableCollection<ProductModel> LoadProducts()
        {
            ObservableCollection<ProductModel> localCollection = new ObservableCollection<ProductModel>();
            foreach (var item in dc.Products)
            {
                if (item.Discontinued == false)
                {
                    localCollection.Add(new ProductModel(item));
                }
              
            }

            return localCollection;
        }
        public DelegateCommand DeleteProduct
        {
            get { return _deleteProduct = _deleteProduct ?? new DelegateCommand(DeleteSelectedProduct); }
        }
        private void DeleteSelectedProduct()
        {
            if (_selectedProduct != null)
            {
                // Supprimer le produit sélectionné de la base de données
                var productToDelete = dc.Products.SingleOrDefault(p => p.ProductId == _selectedProduct.ProductId);

                if (productToDelete != null)
                {
                    if (productToDelete.Discontinued == false)
                    {
                        productToDelete.Discontinued = true;
                        _ProductList.Remove(_selectedProduct);
                        dc.SaveChanges();
                       
                        MessageBox.Show("Product abandonné");
                    }
             
                }
              
            }
        }
    }
}
