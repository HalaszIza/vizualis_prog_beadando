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

namespace vizualis_beadando
{
    /// <summary>
    /// Interaction logic for HetiAjanlat.xaml
    /// </summary>
    public partial class HetiAjanlat : Window
    {

        private Random random = new Random();
        //Főételek nevei 
        private List<string> mainCourses = new List<string>
    {
        "Bolognai spagetti", "Csirkeburger", "Carbonara", "Chilis bab",
        "Lasagne", "Paprikás krumpli virslivel", "Tökfőzelék fasírttal", "Spenótos, gombás tészta"
    };
        //Desszertek nevei 
        private List<string> desserts = new List<string>
    {
        "Krumplis pogácsa", "Macaron", "Málnás tejszínhabos kocka", "Meggyes rácsos pite",
        "Pizzás csiga", "Sajtos ropogós", "Somlói galuska", "Sós aprósütemény"
    };


        public HetiAjanlat()
        {
            InitializeComponent();
            AddRandomMeals();
        }
        private void mi_Főoldal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddRandomMeals()
        {
            //Törlés
            var existingPanels = MainGrid.Children.OfType<StackPanel>().ToList();
            foreach (var panel in existingPanels)
            {
                MainGrid.Children.Remove(panel);
            }

            //Randomizálás
            var shuffledMains = mainCourses.OrderBy(x => random.Next()).ToList();
            var shuffledSides = desserts.OrderBy(x => random.Next()).ToList();

            //TextBlocks nevei
            var days = new[] { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek", "Szombat", "Vasárnap" };

            //Ne lépjük túl a határokat
            int mealCount = Math.Min(Math.Min(days.Length, shuffledMains.Count), shuffledSides.Count);

            for (int i = 0; i < mealCount; i++)
            {
                var dayTextBlock = this.FindName(days[i]) as TextBlock;
                if (dayTextBlock != null)
                {
                    //StackPanel létrehozása a szövegeknek
                    var stackPanel = new StackPanel
                    {
                        VerticalAlignment = VerticalAlignment.Center,
                        Margin = new Thickness(0, 30, 0, 0)
                    };

                    //Főétel hozzáadása, mindent 1x
                    //Stílusok
                    var mainCourse = new TextBlock
                    {
                        Text = shuffledMains[i],
                        FontSize = 19,
                        FontWeight = FontWeights.Bold,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        TextAlignment = TextAlignment.Center
                    };

                    //Desszert hozzáadása, minden 1x 
                    //Stílusok
                    var dessert = new TextBlock
                    {
                        Text = shuffledSides[i],
                        FontSize = 15,
                        FontStyle = FontStyles.Italic,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        TextAlignment = TextAlignment.Center,
                        Margin = new Thickness(0, 5, 0, 0)
                    };

                    stackPanel.Children.Add(mainCourse);
                    stackPanel.Children.Add(dessert);

                    //StackPanel grid cell-hez adjuk
                    Grid.SetRow(stackPanel, Grid.GetRow(dayTextBlock));
                    Grid.SetColumn(stackPanel, Grid.GetColumn(dayTextBlock));
                    MainGrid.Children.Add(stackPanel);
                }
            }
        }
    }
}