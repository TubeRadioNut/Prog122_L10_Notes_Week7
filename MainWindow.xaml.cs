using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_L10_Notes_Week7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//<--Do not delete and leave at the top of the MainWindow()

            //NewControl nc = new NewControl();
            //nc.Width = 300;
            //nc.Height = 300;

            //canvasMain.Children.Add(nc);
            //MessageBox.Show(canvasMain.Children.Count.ToString());
            

        }//end Of MainWindow

        private void btnVisiblity_Click(object sender, RoutedEventArgs e)
        {
            //Ternary for making the userControlNewControl.Visibitity hidden or visible
            //userControlNewControl.Visibility = (userControlNewControl.IsVisible) ? Visibility.Hidden : Visibility.Visible;
            //if(userControlNewControl.IsVisible)
            //{
            //    //make userControlNewControl hidden
            //    userControlNewControl.Visibility = Visibility.Hidden;

            //}
            //else
            //{
            //    userControlNewControl.Visibility = Visibility.Visible;

            //    //MessageBox.Show("is invisible");
            //}

            
            //MessageBox.Show(userControlNewControl.IsVisible.ToString());
            
            
        }

        private void btnUserControl_Click(object sender, RoutedEventArgs e)
        {
            ClearCavas();
            double canWidth = canvasDisplay.Width;
            double canHeight = canvasDisplay.Height;

            NewControl ucw = new NewControl();
            ucw.Width = canWidth;
            ucw.Height = canHeight;

            canvasDisplay.Children.Add(ucw);
        }

        private void btnUserControl2_Click(object sender, RoutedEventArgs e)
        {
            ClearCavas();
            double canWidth = canvasDisplay.Width;
            double canHeight = canvasDisplay.Height;

            UserControl2 ucw = new UserControl2();
            ucw.Width = canWidth;
            ucw.Height = canHeight;

            canvasDisplay.Children.Add(ucw);
        }

        public void ClearCavas()
        {
            canvasDisplay.Children.Clear();
        }
    }//end of partial class


}//end of namespace