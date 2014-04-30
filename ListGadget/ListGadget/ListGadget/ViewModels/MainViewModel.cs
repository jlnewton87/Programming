using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using ListGadget.Resources;
using System.Collections.Generic;
using ListGadget.Data;
using System.Collections.Specialized;

namespace ListGadget.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {

        private List<ItemViewModel> cartItems = new List<ItemViewModel>();
        private List<ItemViewModel> shelfItems = new List<ItemViewModel>();
        private List<ItemViewModel> allItems = new List<ItemViewModel>();
        private ObservableCollection<ItemViewModel> items = new ObservableCollection<ItemViewModel>();

        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
            Items.CollectionChanged += Items_CollectionChanged;
        }

        void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Items");
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
                NotifyPropertyChanged("Items");
                NotifyCollectionChanged("Items");
            }
        }
        public List<ItemViewModel> AllItems
        {
            get
            {
                return this.Items.ToList();
            }
        }
        public List<ItemViewModel> CartItems
        { 
            get 
            {
                return this.Items.Where(x => x.ItemComplete == true).ToList();
            }
        }
        public List<ItemViewModel> ShelfItems
        { 
            get 
            {
                return this.Items.Where(x => x.ItemComplete == false).ToList();
            } 
        }


        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel("Milk", 1, Data.ItemStatus.Pending, new Category(){Title = "Dairy", DisplayOrder = 1}));

            this.IsDataLoaded = true;
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

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        private void NotifyCollectionChanged(String collectionName)
        {
            NotifyCollectionChangedEventHandler handler = CollectionChanged;
            if(null != handler)
            {
                handler(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
            }
        }
    }
}