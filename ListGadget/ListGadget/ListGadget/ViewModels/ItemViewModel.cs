using ListGadget.Data;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ListGadget.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private string description;
        private int quant;
        private bool isComplete;
        private ItemStatus status;
        private Category category;

        public ItemViewModel()
        {

        }

        public ItemViewModel(string description, int quantity, ItemStatus status, Category category)
        {
            this.description = description;
            this.quant = quantity;
            this.status = status;
            if (category == null)
            {
                this.category = new Category() { Title = "No Category", DisplayOrder = -1 };
            }
            else
            {
                this.category = category;
            }
        }

        public string Description
        {
            get 
            {
                return description;
            }
            set 
            {
                description = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quant;
            }
            set
            {
                quant = value;
            }
        }
        public ItemStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                NotifyPropertyChanged("Status");
            }
        }
        public bool ItemComplete
        {
            get
            {
                isComplete = (this.Status == ItemStatus.Complete) ? true : false;
                return isComplete;
            }
            set
            {
                isComplete = value;
                this.Status = (isComplete) ? ItemStatus.Complete : ItemStatus.Pending;
            }
        }
        public Category Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
                NotifyPropertyChanged("Category");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}