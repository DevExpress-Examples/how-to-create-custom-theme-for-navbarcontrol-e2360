using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.NavBar;
using System.Windows.Data;
using System.Globalization;

namespace AgNavBarCustomTheme {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        void RadioButton_Checked(object sender, RoutedEventArgs e) {
            if (navBar == null)
                return;

            string view = ((RadioButton)sender).Content as string;

            switch (view) {
                case "ExplorerBar":
                    navBar.View = new ExplorerBarView();
                    break;
                case "NavigationPane":
                    navBar.View = new NavigationPaneView();
                    break;
                case "SideBar":
                    navBar.View = new SideBarView();
                    break;
            }
        }
    }

    public class BooleanToAgleConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return (bool)value ? 0d : System.Convert.ToDouble(parameter, CultureInfo.InvariantCulture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
