using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace TestWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image img;

        public MainWindow()
        {
           InitializeComponent();

            Uri fileUri = new Uri("Start.png",UriKind.Relative);
            MyImage.Source = new BitmapImage(fileUri);
            


        }

    

     

        private void MyImage_Drop(object sender, DragEventArgs e)
        {

            MyImage.Source = img.Source;

        }




        private void MyImage_MouseDown(object sender, MouseButtonEventArgs e)
        {

           
        }

        private void MyImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void MyImage_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void MyImage_DragEnter(object sender, DragEventArgs e)
        {
        
        }

        private void MyImage_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
       
        }

        private void image2_QueryCursor(object sender, QueryCursorEventArgs e)
        {
          
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void image2_MouseMove(object sender, MouseEventArgs e)
        {
            img = sender as Image;
            if (img != null && e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(MyImage,
                         img.Source,
                         DragDropEffects.Copy);
                
            }
        }
    }
}


