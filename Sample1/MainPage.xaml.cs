using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }


        string entryTxt = "";
        string outText = "";
        void ClickDot(object sender, System.EventArgs e)
        {

            entryTxt += ".";
        }
        void ClickDash(object sender, System.EventArgs e)
        {
            entryTxt += "-";
        }

        void ClickSpace(object sender, System.EventArgs e)
        {
            char text = Morse.MorseCoder(entryTxt);
            outText += text;
            entryTxt = "";
            output.Text = outText;
        }

    }
}
