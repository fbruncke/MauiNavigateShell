using MauiNavigateShell.Model;
using MauiNavigateShell.ViewModel;
using System.Collections.ObjectModel;

namespace MauiNavigateShell.View;

public partial class ItemView : ContentPage
{
   
    public ItemView(ItemViewModel ivm)
	{
        InitializeComponent();

        
        BindingContext = ivm;
        

    }
}