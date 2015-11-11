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
using WebApp_Desktop.PersonReference;
using WebApp_Domain;

namespace WebApp_Desktop
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {

      public MainWindow()
      {
         InitializeComponent();

         FillBox((new PersonClient()).GetPersonList());
      }




      private void FillBox(IEnumerable<PersonDTO> people)
      {
         nameList.Items.Clear();

         foreach(var item in people.ToList())
         {
            nameList.Items.Add(item.FirstName + " " + item.LastName);
         }
      }

      private void searchButton()
      {
         var a = nameText.Text;
         nameText.Equals("");

         List<PersonDTO> p = new List<PersonDTO>();

         PersonClient pc = new PersonClient();
         var pl = pc.GetPersonList();

         foreach(PersonDTO person in pl)
         {
            if (person.FirstName.Equals(a) || person.LastName.Equals(a))
            {
               p.Add(person);
            }
         }

         FillBox(p);

      }

      private void nameButton_Click(object sender, RoutedEventArgs e)
      {
         searchButton();
      }


   }
}
