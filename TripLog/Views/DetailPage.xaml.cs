using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TripLog.Models;
using Xamarin.Forms.Maps;
using TripLog.ViewModels;

namespace TripLog.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
        DetailViewModel _vm
        {
            get { return BindingContext as DetailViewModel; }
        }
        public DetailPage(TripLogEntry entry)
        {
            InitializeComponent();

            BindingContext = new DetailViewModel(entry);

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(_vm.Entry.Latitude, _vm.Entry.Longitude),
                Distance.FromMiles(.5)));

            map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Label = _vm.Entry.Title,
                Position = new Position(_vm.Entry.Latitude, _vm.Entry.Longitude)
            });

            /*
            title.Text = entry.Title;
            date.Text = entry.Date.ToString("M");
            rating.Text = $"{entry.Rating} star rating";
            notes.Text = entry.Notes;
            */


        }
	}
}