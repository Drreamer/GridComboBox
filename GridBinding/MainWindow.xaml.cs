using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GridBinding {
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window {
      public MainWindow() {
         InitializeComponent();
         this.DataContext = new ManageUsersViewModel();
      }
   }

   public class User {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Role { get; set; }
   }

   public class ManageUsersViewModel {
      new ObservableCollection<User> _users;
   public ManageUsersViewModel() {
      _users = new ObservableCollection<User>
      {
        new User { FirstName = "First1", LastName = "Last1", Role = "Admin" },
        new User { FirstName = "Last2", LastName = "Last2", Role ="User" },
    };

      ComboBox_Roles = new ObservableCollection<string> { "Admin", "User", "ASDSAD" };
   }

   public ObservableCollection<User> Users {
      get => _users;
      set {
         _users = value;
      }
   }

   public ObservableCollection<string> ComboBox_Roles { get; set; }
   }
}
