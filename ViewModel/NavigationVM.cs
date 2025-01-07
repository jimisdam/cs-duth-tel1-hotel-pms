using WPF = System.Windows;

namespace TachyDev1.ViewModel;

internal class NavigationVM: BaseViewModel
{
	private WPF.Controls.ListViewItem? _PageSelection;
	public WPF.Controls.ListViewItem? PageSelection
	{
		get { return _PageSelection; }
		set { _PageSelection= value; OnPropertyChanged(); }
	}

    public string? SelectedPageName
    {
        get => this.PageSelection?.Content.ToString();
    }
}
