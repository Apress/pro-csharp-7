using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Ink;
using System.Windows.Media;
using AutoLotDAL.Repos;

namespace WpfControlsAndAPIs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MyInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            this.inkRadio.IsChecked = true;
            this.comboColors.SelectedIndex = 0;
            SetBindings();
            ConfigureGrid();
        }

        private void RadioButtonClicked(object sender, RoutedEventArgs e)
        {
            switch ((sender as RadioButton)?.Content.ToString())
            {
                // These strings must be the same as the Content values for each
                // RadioButton.
                case "Ink Mode!":
                    this.MyInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;

                case "Erase Mode!":
                    this.MyInkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;

                case "Select Mode!":
                    this.MyInkCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
            }
        }

        private void ColorChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected value in the combo box.
            //string colorToUse = (comboColors.SelectedItem as ComboBoxItem)?.Content.ToString();
            string colorToUse =
                (comboColors.SelectedItem as StackPanel)?.Tag.ToString();

            // Change the color used to render the strokes.
            this.MyInkCanvas.DefaultDrawingAttributes.Color =
                (Color)ColorConverter.ConvertFromString(colorToUse);

        }

        private void SaveData(object sender, System.Windows.RoutedEventArgs e)
        {
            // Save all data on the InkCanvas to a local file.
            using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Create))
            {
                this.MyInkCanvas.Strokes.Save(fs);
                fs.Close();
            }
        }

        private void LoadData(object sender, System.Windows.RoutedEventArgs e)
        {
            // Fill StrokeCollection from file.
            using (FileStream fs = new FileStream("StrokeData.bin",
                FileMode.Open, FileAccess.Read))
            {
                StrokeCollection strokes = new StrokeCollection(fs);
                this.MyInkCanvas.Strokes = strokes;
            }
        }

        private void Clear(object sender, System.Windows.RoutedEventArgs e)
        {
            // Clear all strokes.
            this.MyInkCanvas.Strokes.Clear();
        }

        private void SetBindings()
        {
            // Create a Binding object.
            Binding b = new Binding();

            // Register the converter, source, and path.
            b.Converter = new MyDoubleConverter();
            b.Source = this.mySB;
            b.Path = new PropertyPath("Value");

            // Call the SetBinding method on the Label.
            this.labelSBThumb.SetBinding(Label.ContentProperty, b);
        }
        private void ConfigureGrid()
        {
            using (var repo = new InventoryRepo())
            {
                // Build a LINQ query that gets back some data from the Inventory table.
                gridInventory.ItemsSource = 
                    repo.GetAll().Select(x => new { x.Id, x.Make, x.Color, x.PetName });
            }
        }

    }
}
