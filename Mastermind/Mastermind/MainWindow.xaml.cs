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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();

        }

        private void InitializeGame()
        {
            StringBuilder secretCode = new StringBuilder();
            Random color = new Random();
            secretCode.Append("Mastermind Code: ");
            for (int i = 0; i < 4; i++)
            {
                int colorNumber = color.Next(1, 7);
                if (colorNumber == 1)
                {
                    secretCode.Append("Red, ");
                }
                else if (colorNumber == 2)
                {
                    secretCode.Append("Yellow, ");
                }
                else if (colorNumber == 3)
                {
                    secretCode.Append("Orange, ");
                }
                else if (colorNumber == 4)
                {
                    secretCode.Append("White, ");
                }
                else if (colorNumber == 5)
                {
                    secretCode.Append("Green, ");
                }
                else if (colorNumber == 6)
                {
                    secretCode.Append("Blue, ");
                }
            }
            secretCode.Length -= 2;
            Title = secretCode.ToString();
        }
            

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender == comboBox1 && comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    kleur1.Background = new SolidColorBrush(Colors.Red);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    kleur1.Background = new SolidColorBrush(Colors.Yellow);
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    kleur1.Background = new SolidColorBrush(Colors.Orange);
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    kleur1.Background = new SolidColorBrush(Colors.White);
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    kleur1.Background = new SolidColorBrush(Colors.Green);
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    kleur1.Background = new SolidColorBrush(Colors.Blue);
                }           
            }

           if (sender == comboBox2 && comboBox2.SelectedItem != null)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    kleur2.Background = new SolidColorBrush(Colors.Red);
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    kleur2.Background = new SolidColorBrush(Colors.Yellow);
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    kleur2.Background = new SolidColorBrush(Colors.Orange);
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    kleur2.Background = new SolidColorBrush(Colors.White);
                }
                if (comboBox2.SelectedIndex == 4)
                {
                    kleur2.Background = new SolidColorBrush(Colors.Green);
                }
                if (comboBox2.SelectedIndex == 5)
                {
                    kleur2.Background = new SolidColorBrush(Colors.Blue);
                }
            }

            if (sender == comboBox3 && comboBox3.SelectedItem != null)
            {
                if (comboBox3.SelectedIndex == 0)
                {
                    kleur3.Background = new SolidColorBrush(Colors.Red);
                }
                if (comboBox3.SelectedIndex == 1)
                {
                    kleur3.Background = new SolidColorBrush(Colors.Yellow);
                }
                if (comboBox3.SelectedIndex == 2)
                {
                    kleur3.Background = new SolidColorBrush(Colors.Orange);
                }
                if (comboBox3.SelectedIndex == 3)
                {
                    kleur3.Background = new SolidColorBrush(Colors.White);
                }
                if (comboBox3.SelectedIndex == 4)
                {
                    kleur3.Background = new SolidColorBrush(Colors.Green);
                }
                if (comboBox3.SelectedIndex == 5)
                {
                    kleur3.Background = new SolidColorBrush(Colors.Blue);
                }
            }
            if (sender == comboBox4 && comboBox4.SelectedItem != null)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    kleur4.Background = new SolidColorBrush(Colors.Red);
                }
                if (comboBox4.SelectedIndex == 1)
                {
                    kleur4.Background = new SolidColorBrush(Colors.Yellow);
                }
                if (comboBox4.SelectedIndex == 2)
                {
                    kleur4.Background = new SolidColorBrush(Colors.Orange);
                }
                if (comboBox4.SelectedIndex == 3)
                {
                    kleur4.Background = new SolidColorBrush(Colors.White);
                }
                if (comboBox4.SelectedIndex == 4)
                {
                    kleur4.Background = new SolidColorBrush(Colors.Green);
                }
                if (comboBox4.SelectedIndex == 5)
                {
                    kleur4.Background = new SolidColorBrush(Colors.Blue);
                }
            }
        }

    }
}
