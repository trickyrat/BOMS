using BOMS.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace BOMS.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class OrderDataGridPage : Page
{
    public OrderDataGridViewModel ViewModel
    {
        get;
    }

    public OrderDataGridPage()
    {
        ViewModel = App.GetService<OrderDataGridViewModel>();
        InitializeComponent();
    }

    private void CommandBarEditButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void CommandBarDeleteButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}
