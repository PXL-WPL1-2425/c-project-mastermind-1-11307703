using System;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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
using systemColor = System.Windows.Media.Color;
namespace Mastermind
{  
    public partial class MainWindow : Window
    {
        Array correctNumbers = Array.CreateInstance(typeof(systemColor), 5);
        Array guesses = Array.CreateInstance(typeof(systemColor), 5);


        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();

        }

        private void ArrayColorPositionSetter(systemColor inputCode, int position, Array colorArray)
        {
            colorArray.SetValue(inputCode, position);
           
        }

        private static systemColor ColorPickers(int colorIndex)
        {
            if (colorIndex == 0)
            {          
                return Colors.Red;
            }
            else if (colorIndex == 1)
            {
                return Colors.Yellow;
            }
            else if (colorIndex == 2)
            {
                return Colors.Orange;
            }
            else if (colorIndex == 3)
            {
                return Colors.White;
            }
            else if (colorIndex == 4)
            {
                return Colors.Green;
            }
            else if (colorIndex == 5)
            {
                return Colors.Blue;
            }
            else
            {
                return Colors.Red;
            }
        }
       

        private void InitializeGame()
        {
            
            StringBuilder secretCode = new StringBuilder();
            Random rng = new Random();
            secretCode.Append("Mastermind Code: ");
            for (int i = 0; i < 4; i++)
            {
                int colorNumber = rng.Next(1, 7);
                int colorPosition = rng.Next(0, i);
                systemColor color = ColorPickers(colorNumber);
                bool wasColorPlaced = false;


                while (wasColorPlaced)
                {
                    if (correctNumbers.GetValue(colorPosition).GetType == null)
                    {
                        correctNumbers.SetValue(color, colorNumber);                       
                        wasColorPlaced = true;
                    }

                    colorPosition = rng.Next(0, i);
                }


                //if (correctNumbers.GetValue(colorPosition).GetType() == null)
                //{
                //    correctNumbers.SetValue(color, colorPosition);
                //}
                //else
                //{
                //    this.correctNumbers.
                //}
                //if (colorNumber == 1)
                //{                 
                //    secretCode.Append("Red, ");
                //}
                //else if (colorNumber == 2)
                //{
                //    secretCode.Append("Yellow, ");
                //}
                //else if (colorNumber == 3)
                //{
                //    secretCode.Append("Orange, ");
                //}
                //else if (colorNumber == 4)
                //{
                //    secretCode.Append("White, ");
                //}
                //else if (colorNumber == 5)
                //{
                //    secretCode.Append("Green, ");
                //}
                //else if (colorNumber == 6)
                //{
                //    secretCode.Append("Blue, ");
                //}
            }

            for (int i = 0; i < correctNumbers.Length; i++)
            {
                string colorName = correctNumbers.GetValue(i).ToString();
                secretCode.Append($" {colorName}");

            }
            //secretCode.Length -= 2;
            Title = secretCode.ToString();
        }
          
        
        private void ComboBoxPicker(object sender, ComboBox comboBox, Label labelColor, systemColor color)
        {
            labelColor.Background = new SolidColorBrush(color);       
        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (sender == comboBox1 && comboBox1.SelectedItem != null)
            {
                systemColor color = ColorPickers(comboBox1.SelectedIndex);            
                ComboBoxPicker(sender, comboBox1, kleur1, color);
                ArrayColorPositionSetter(color, 0, guesses);
            }

           if (sender == comboBox2 && comboBox2.SelectedItem != null)
            {
                systemColor color = ColorPickers(comboBox2.SelectedIndex);
                ComboBoxPicker(sender, comboBox2, kleur2, color);
                ArrayColorPositionSetter(color, 1, guesses);
            }

            if (sender == comboBox3 && comboBox3.SelectedItem != null)
            {
                systemColor color = ColorPickers(comboBox3.SelectedIndex);
                ComboBoxPicker(sender, comboBox3, kleur3, color);
                ArrayColorPositionSetter(color, 2, guesses);
            }
            if (sender == comboBox4 && comboBox4.SelectedItem != null)
            {
                systemColor color = ColorPickers(comboBox4.SelectedIndex);
                ComboBoxPicker(sender, comboBox4, kleur4, color);
                ArrayColorPositionSetter(color, 3, guesses);
            }
        }

        private void ControlButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
