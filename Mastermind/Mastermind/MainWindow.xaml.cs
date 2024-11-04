using System.Drawing;
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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            var colors = new List<string> { "Red", "Yellow", "White", "Orange", "Green", "Blue" };
            var random = new Random();

            // 4 willekeurige kleuren
            var secretCode = new List<string>
            {
                colors[random.Next(colors.Count)],
                colors[random.Next(colors.Count)],
                colors[random.Next(colors.Count)],
                colors[random.Next(colors.Count)]   
            };

            // Titel
            this.Title = "Mastermind Oplossing: " + string.Join(", ", secretCode);

         
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedColor = selectedItem.Content.ToString();

                Label targetLabel = null;
                if (comboBox == comboBox1) targetLabel = kleur1;
                else if (comboBox == comboBox2) targetLabel = kleur2;
                else if (comboBox == comboBox3) targetLabel = kleur3;
                else if (comboBox == comboBox4) targetLabel = kleur4;

                if (targetLabel != null)
                {
                    targetLabel.Background = (Brush)new BrushConverter().ConvertFromString(selectedColor);
                }
            }
        }

      
    }
}