using MauiNavigateShell.Model;
using MauiNavigateShell.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiNavigateShell.ViewModel
{
    public class ItemViewModel : BindableObject
    {

        public ItemViewModel()
        {
            
        }


        public ObservableCollection<Item> items = null;

        //public ObservableCollection<Item> Items
        //{
        //    get { return items; }
        //    set { items = value; OnPropertyChanged(); }
        //}

        private int Simpel = 42;

        private Item item = new Item();

        public Item ItemProp
        {
            get { return item; }
            set { item = value; OnPropertyChanged(); }
        }

        public ICommand AddItem => new Command(async () =>
        {            
            var navigationParameter = new Dictionary<string, object>
            {
                { "ItemProp", ItemProp}
            };
            await Shell.Current.GoToAsync(nameof(ShoppingListView), navigationParameter);
            
        });

        public ICommand AddSimpleItem => new Command(async () =>
        {
            //items.Add(item);    
            //await App.Current.MainPage.Navigation.PopAsync(true);

            
            await Shell.Current.GoToAsync($"{nameof(ShoppingListView)}?Simpel={Simpel}");

        });


        public ICommand BackToList => new Command(async () =>
        {

            await Shell.Current.GoToAsync($"{nameof(ShoppingListView)}");

        });
    }
}
