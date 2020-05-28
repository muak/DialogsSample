using System;
using System.Collections.Generic;
using AiForms.Dialogs.Abstractions;
using Xamarin.Forms;

namespace DialogsSample
{
    public partial class SampleDialog : DialogView
    {
        public SampleDialog()
        {
            InitializeComponent();
        }

        void OK_Clicked(System.Object sender, System.EventArgs e)
        {
            DialogNotifier.Complete();
        }

        void Cancel_Clicked(System.Object sender, System.EventArgs e)
        {
            DialogNotifier.Cancel();
        }
    }
}
