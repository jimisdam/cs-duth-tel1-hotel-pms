using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TachyDev1.ViewModel;

internal class AuthenticationVM: BaseViewModel
{
	private string? _Username;
	private string? _Password;


	public string? Username
	{
		get { return _Username; }
		set { _Username = value; OnPropertyChanged(); }
	}

    public string? Password
    {
        get { return _Password; }
        set { _Password = value; OnPropertyChanged(); }
    }
}
