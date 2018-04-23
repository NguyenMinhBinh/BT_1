using System;
using System.Collections.Generic;
using System.Text;
using B2.Enum;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B2.Class
{
    public class AstronomyMasterDetailPage : MasterDetailPage
    {
        public AstronomyMasterDetailPage()
        {
            //thêm Astronomy. hay Astronomy.Pages... hay Astronomy.Data...là do copy thư mục Data và Pages từ solution Astronomy qua B2

            //page AstronomyMasterPage phải được đặt Title="tên title" mới chạy được
            //this.Master = new View.AstronomyMasterPage();//bài 2

            var master = new View.AstronomyMasterPage();
            

            //this.Detail = new NavigationPage(new View.Login());

            //this.MasterBehavior = MasterBehavior.Popover;

            master.PageSelected += MasterPageSelected;

            PresentDetailPage(Enum.PageType.SunRise);
            this.Master = master;
        }

        private void MasterPageSelected(object sender, PageType e)
        {
            PresentDetailPage(e);
        }

        void PresentDetailPage(Enum.PageType pageType)
        {
            Page page;

            switch (pageType)
            {
                case Enum.PageType.SunRise:
                    page = new Astronomy.Pages.SunrisePage();
                    break;
                case Enum.PageType.MoonPhase:
                    page = new Astronomy.Pages.MoonPhasePage();
                    break;
                case Enum.PageType.Earth:
                    page = new Astronomy.Pages.AstronomicalBodyPage(Astronomy.SolarSystemData.Earth);
                    break;
                case Enum.PageType.Moon:
                    page = new Astronomy.Pages.AstronomicalBodyPage(Astronomy.SolarSystemData.Moon);
                    break;
                case Enum.PageType.Sun:
                    page = new Astronomy.Pages.AstronomicalBodyPage(Astronomy.SolarSystemData.Sun);
                    break;
                case Enum.PageType.About:
                default:
                    page = new Astronomy.Pages.AboutPage();
                    break;
            }

            this.Detail = new NavigationPage(page);

            this.IsPresented = false;
        }
    }
}
