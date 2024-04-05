using MauiNavigateShell.Model;
using MauiNavigateShell.ViewModel;
using System.ComponentModel;


namespace MauiNavigateShell.View;


[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ShoppingListView : ContentPage, INotifyPropertyChanged
{ 
    
    public ShoppingListView(ShoppingListViewModel slvm)
	{
        
		
		InitializeComponent();
        
        BindingContext = slvm;



    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        ((ShoppingListViewModel)BindingContext).NavigatedTooCMD.Execute(null);
    }




}