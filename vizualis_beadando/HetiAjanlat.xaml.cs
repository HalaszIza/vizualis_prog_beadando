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
        // Sample lists of food items (customize these)
        private List<string> mainCourses = new List<string>
    {
        "Bolognai spagetti", "Csirkeburger", "Carbonara", "Chilis bab",
        "Lasagne", "Paprikás krumpli virslivel", "Tökfőzelék fasírttal", "Spenótos, gombás tészta"
    };

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
            // Clear existing meal content if any
            var existingPanels = MainGrid.Children.OfType<StackPanel>().ToList();
            foreach (var panel in existingPanels)
            {
                MainGrid.Children.Remove(panel);
            }

            // Create shuffled lists of meals
            var shuffledMains = mainCourses.OrderBy(x => random.Next()).ToList();
            var shuffledSides = desserts.OrderBy(x => random.Next()).ToList();

            // Get all TextBlocks that represent days
            var days = new[] { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek", "Szombat", "Vasárnap" };

            // Make sure we don't exceed our meal options
            int mealCount = Math.Min(Math.Min(days.Length, shuffledMains.Count), shuffledSides.Count);

            for (int i = 0; i < mealCount; i++)
            {
                var dayTextBlock = this.FindName(days[i]) as TextBlock;
                if (dayTextBlock != null)
                {
                    // Create a StackPanel to hold both text items
                    var stackPanel = new StackPanel
                    {
                        VerticalAlignment = VerticalAlignment.Center,
                        Margin = new Thickness(0, 30, 0, 0) // Add some top margin
                    };

                    // Add main course (no repeats)
                    var mainCourse = new TextBlock
                    {
                        Text = shuffledMains[i],
                        FontSize = 19,
                        FontWeight = FontWeights.Bold,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        TextAlignment = TextAlignment.Center
                    };

                    // Add side dish (no repeats)
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

                    // Add the StackPanel to the appropriate grid cell
                    Grid.SetRow(stackPanel, Grid.GetRow(dayTextBlock));
                    Grid.SetColumn(stackPanel, Grid.GetColumn(dayTextBlock));
                    MainGrid.Children.Add(stackPanel);
                }
            }
        }
    }
}