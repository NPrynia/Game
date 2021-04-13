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
using System.Windows.Shapes;
using Game.Page;

namespace Game.Window
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow
    {
        public GameWindow()
        {
            InitializeComponent();
            FrameMain.Navigate(new TitleScrin());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveWindow saveWindow = new SaveWindow();
            this.Close();
            saveWindow.Show();

        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            SaveWindow saveWindow = new SaveWindow();
            this.Close();
            saveWindow.Show();
        }
    }
}
