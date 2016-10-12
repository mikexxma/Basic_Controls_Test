using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Basic_Controls_Test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void myCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckBoxResult.Text = myCheckBox.IsChecked.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RedioButtonResult.Text = (bool)YesRedioButton.IsChecked? "Yes" : "No";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var text = (ComboBoxItem)combo.SelectedItem;
            ComboBoxResult.Text = text.Content.ToString();
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items = myListBox.Items.Cast<ListBoxItem>().Where(p=>p.IsSelected).Select(p=>p.Content).ToArray();
            ListBoxResult.Text = string.Join(",", items); 
        }

        private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var toggleButton = (ToggleButton)sender;
            ToggleButtonResult.Text = MyToggleButton.IsChecked.ToString();
        }
    }
}
