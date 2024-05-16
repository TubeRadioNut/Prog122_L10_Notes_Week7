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
            MessageBox.Show($"Number of Items in the Canvas List Children: {canvasMain.Children.Count.ToString()}");
            

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
        //Create click event for button UserControl
        private void btnUserControl_Click(object sender, RoutedEventArgs e)
        {
            //Clear the canvas so current instance of user control is remnoved iof there is one
            ClearCavas();
            //Create double variables for canvas size to be used to size the new instance of user control
            double canWidth = canvasDisplay.Width;
            double canHeight = canvasDisplay.Height;
            //Create new instance of user control naming it ucw and using double variables to size it
            NewControl ucw = new NewControl();
            ucw.Width = canWidth;
            ucw.Height = canHeight;
            //adding new instance of user control to canvas list Children
            canvasDisplay.Children.Add(ucw);
        }
        //Create click event for button UserControl2
        private void btnUserControl2_Click(object sender, RoutedEventArgs e)
        {
            //Clear canvas so current instance of user control is removed if there is one
            ClearCavas();
            //Create double variables for canvas size to be used to size the new instance of user control
            double canWidth = canvasDisplay.Width;
            double canHeight = canvasDisplay.Height;
            //Create new instance of user control naming it ucw2 and using double variables to size it
            UserControl2 ucw2 = new UserControl2();
            ucw2.Width = canWidth;
            ucw2.Height = canHeight;
            //adding new instance of user control to canvas list Children
            canvasDisplay.Children.Add(ucw2);
        }
        //Create method to clear the canvas of current user control
        public void ClearCavas()
        {
            //Clear the canvas list Children
            canvasDisplay.Children.Clear();
        }
    }//end of partial class


}//end of namespace