using DesktopLibary;
using DesktopLibary.Models;
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

namespace DesktopApp
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private static DomainHelper domain = new DomainHelper();

      private void FillBox()
      {
         var book = domain.ListPeople();

         bookBox.Items.Clear();

         foreach(var item in book)
         {
            bookBox.Items.Add(item);
         }
      }

      public MainWindow()
      {
         InitializeComponent();

         FillBox();
      }

      private void AddPerson_Click(object sender, RoutedEventArgs e)
      {
         var p = new Person();

         p.FirstName = string.IsNullOrWhiteSpace(FirstText.Text) ? "NoName" : FirstText.Text;
         p.LastName = string.IsNullOrWhiteSpace(LastText.Text) ? "NoName" :  LastText.Text;

         domain.AddPerson(p);

         FirstText.Clear();
         LastText.Clear();
         FillBox();
      }
   }
}
