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

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblAfficheur.Content = "";
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Faire apparaitre les tailles dans la sortie
            ((Window)sender).ActualHeight.Dump();
            ((Window)sender).ActualWidth.Dump();

            ((Window)sender).Height = 4 / 3 * ((Window)sender).ActualWidth; // garder les proportions



        }

        /*private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lblAfficheur.Content += "1";
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lblAfficheur.Content += "2";
        }
        */
       
            
        

        private void btnNum_Click(object sender, RoutedEventArgs e)
        {
            
            lblAfficheur.Content += (string)((Button)sender).Content;
            if (opération != null && !lblAfficheur.Content.ToString().Contains(","))
            {
                btnVirgule.IsEnabled = true; // Réactive le bouton de la virgule
            }
        }
        private void btnVirgule_Click(object sender, RoutedEventArgs e)
        {

            // Ajoutez la virgule à l'affichage
            lblAfficheur.Content += ",";

            // Désactive le bouton de la virgule
            btnVirgule.IsEnabled = false;
        }
        double total = 0;
        string opération = "";

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(lblAfficheur.Content.ToString(), out double num))
            {
                total = num;
                opération = "+";
                lblAfficheur.Content = "";
                ;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.");
            }
        }

       
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(lblAfficheur.Content.ToString(), out double num))
            {
                total = num;
                opération = "-";
                lblAfficheur.Content = "";
                btnVirgule.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.");
            }


        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(lblAfficheur.Content.ToString(), out double num))
            {
                total = num;
                opération = "*";
                lblAfficheur.Content = "";
                btnVirgule.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.");
            }

        }

        private void btnDivise_click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(lblAfficheur.Content.ToString(), out double num))
            {
                total = num;
                opération = "/";
                lblAfficheur.Content = "";
                btnVirgule.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.");
            }


        }

        private void btnEqual_click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(lblAfficheur.Content.ToString(), out double num))
            {
                switch (opération)
                {
                    case "+":
                        lblAfficheur.Content = total + num;
                        break;
                    case "-":
                        lblAfficheur.Content = total - num;
                        break;
                    case "*":
                        lblAfficheur.Content = total * num;
                        break;
                    case "/":
                        lblAfficheur.Content = total / num;
                        break;
                    default:
                        break;
                        
                }btnVirgule.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.");
            }
        }

        private void btnCe_click(object sender, RoutedEventArgs e)
        {
            string currentContent = lblAfficheur.Content.ToString();
            if (currentContent.Length > 0)
            {
                int lastOperatorIndex = Math.Max(Math.Max(currentContent.LastIndexOf("+"), currentContent.LastIndexOf("-")), Math.Max(currentContent.LastIndexOf("*"), currentContent.LastIndexOf("/")));
                if (lastOperatorIndex >= 0)
                {
                    lblAfficheur.Content = currentContent.Substring(0, lastOperatorIndex + 1);
                }
                else
                {
                    lblAfficheur.Content = "";
                }
            }
        }
    }
}
