using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AstronomyMasterPage : ContentPage
	{
        public NavigationPage Detail { get; private set; }
        public bool IsPresented { get; private set; }

        public event EventHandler<Enum.PageType> PageSelected;

        public AstronomyMasterPage ()
		{
			InitializeComponent ();
            btnMoonPhase.Clicked += (s, e) => PageSelected?.Invoke(this, Enum.PageType.MoonPhase);
            btnSunRise.Clicked += (s, e) => PageSelected?.Invoke(this, Enum.PageType.SunRise);
            btnAbout.Clicked += (s, e) => PageSelected?.Invoke(this, Enum.PageType.About);

            btnEarth.Clicked += (s, e) => PageSelected?.Invoke(this, Enum.PageType.Earth);
            btnMoon.Clicked += (s, e) => PageSelected?.Invoke(this, Enum.PageType.Moon);
            btnSun.Clicked += (s, e) => PageSelected?.Invoke(this, Enum.PageType.Sun);
        }

       
    }
}