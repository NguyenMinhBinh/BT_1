using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using Xamarin.Forms;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using B2.Services;
using B2.Droid.Services;

[assembly: Dependency(typeof(EmailserviceAndroid))]
namespace B2.Droid.Services
{
    public class EmailserviceAndroid : IEmailservices
    {
        public void Send(string email, string title, string content)
        {
            //throw new NotImplementedException();
        }
    }
}