using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TachyDev1.ViewModel;

internal class NavigationVM: BaseViewModel
{
	private string? _ActivePage;


	public string? ActivePage
	{
		get { return _ActivePage; }
		set { _ActivePage = value; OnPropertyChanged(); }
	}

}
