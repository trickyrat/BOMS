using BOMS.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace BOMS.Views;

public sealed partial class BankOrderListDetailsPage : Page
{
    public BankOrderListDetailsViewModel ViewModel
    {
        get;
    }

    public BankOrderListDetailsPage()
    {
        ViewModel = App.GetService<BankOrderListDetailsViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
