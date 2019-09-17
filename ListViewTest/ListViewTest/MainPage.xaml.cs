using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LV.ItemsSource = new string[]
                {
                  "mono",
                  "monodroid",
                  "monotouch",
                  "monorail",
                  "monodevelop",
                  "monotone",
                  "monopoly",
                  "monomodal",
                  "mononucleosis",
                  "mono",
                  "monodroid",
                  "monotouch",
                  "monorail",
                  "monodevelop",
                  "monotone",
                  "monopoly",
                  "monomodal",
                  "mononucleosis"
                };
        }
    }
}
