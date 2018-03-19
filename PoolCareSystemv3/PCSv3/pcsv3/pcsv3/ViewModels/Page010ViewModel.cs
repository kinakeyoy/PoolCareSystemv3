using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Reflection;
using Xamarin.Forms;

namespace pcsv3.ViewModels
{
    public class Page010ViewModel : BindableBase
    {
        public Page010ViewModel()
        {

        }
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;

            if (picker.SelectedIndex == -1)
            {

            }
            else
            {
                string colorName = picker.Items[picker.SelectedIndex];
                FieldInfo colorField = typeof(Color).GetRuntimeField(colorName);

            }
        }
    }
}
