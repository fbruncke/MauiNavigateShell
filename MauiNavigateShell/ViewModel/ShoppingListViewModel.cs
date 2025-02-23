﻿using MauiNavigateShell.Model;
using MauiNavigateShell.View;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiNavigateShell.ViewModel
{
    [QueryProperty(nameof(Simpel),nameof(Simpel))]
    [QueryProperty(nameof(ItemProp), nameof(ItemProp))]
    public class ShoppingListViewModel : BindableObject
    {
        #region getters/setters
        private String testString = "Test Value";

        public String TestString
        {
            get { return testString; }
            set { testString = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Item> items = new ObservableCollection<Item>();

        public ObservableCollection<Item> Items
        {
            get { return items; }
            set { items = value; OnPropertyChanged(); }
        }

        private int simpel;

        public int Simpel
        {
            get { return simpel; }
            set { simpel = value; OnPropertyChanged(); }
        }

        private Item item;

        public Item ItemProp
        {
            get { return item; }
            set { item = value;
                if (value != null)
                    this.Items.Add(new Item
                    {
                        Description = item.Description,
                        Price = item.Price,
                        Quantity = item.Quantity
                    });


            }
        }


        #endregion

        public ShoppingListViewModel()
        {
            this.Items.Add(new Item {Description="Radio", Price=99, Quantity=1 });
        }

        public ICommand AddItem => new Command(async () =>
        {
            //await App.Current.MainPage.Navigation.PushAsync(new ItemView(ref this.items));
            //await Shell.Current.GoToAsync("//View/ItemView");
            await Shell.Current.GoToAsync($"ItemView", true);
        });

        public ICommand ItemTapCMD => new Command<Item>(async (Item selectedItem) => {
            System.Diagnostics.Debug.WriteLine("selectedItem: " + selectedItem.Description);
            
        });

        public ICommand NavigatedTooCMD => new Command( () =>
        {
            System.Diagnostics.Debug.WriteLine("NavigatedTooCMD: " );

        });

        

    }
}
