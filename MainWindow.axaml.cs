using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Interactivity;

namespace RubikCubeGraphics
{
    public partial class MainWindow : Window
    {
        public SolidColorBrush[] cubeColors { get; set; }
        Cube cube = new();
        public MainWindow()
        {
            cubeColors = new SolidColorBrush[] {SolidColorBrush.Parse("Orange")};
            Console.WriteLine("test");
            UpdateView();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void UpdateView() {
            cubeColors = GetCubeColors();
            this.InitializeComponent();
            this.DataContext = this;
        }

        public SolidColorBrush[] GetCubeColors() {
            cubeColors = new SolidColorBrush[54];
            String colorsString = cube.PrintOut();
            Console.WriteLine(colorsString);
            String[] colorStrings = colorsString.Split(new[] {" ", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 54; i++) {
                cubeColors[i] = SolidColorBrush.Parse(colorStrings[i]);
            }
            return cubeColors;
        }
        public void HorizontalNorth(object sender, RoutedEventArgs e) {
            cube.TwistHorizontalNorth(false);
            UpdateView();
        }
        public void HorizontalNorthReversed(object sender, RoutedEventArgs e) {
            cube.TwistHorizontalNorth(true);
            UpdateView();
        }
        public void HorizontalSouth(object sender, RoutedEventArgs e) {
            cube.TwistHorizontalSouth(false);
            UpdateView();
        }
        public void HorizontalSouthReversed(object sender, RoutedEventArgs e) {
            cube.TwistHorizontalSouth(true);
            UpdateView();
        }
        public void VerticalFrontWest(object sender, RoutedEventArgs e) {
            cube.TwistVerticalFrontWest(false);
            UpdateView();
        }
        public void VerticalFrontWestReversed(object sender, RoutedEventArgs e) {
            cube.TwistVerticalFrontWest(true);
            UpdateView();
        }
        public void VerticalFrontEast(object sender, RoutedEventArgs e) {
            cube.TwistVerticalFrontEast(false);
            UpdateView();
        }
        public void VerticalFrontEastReversed(object sender, RoutedEventArgs e) {
            cube.TwistVerticalFrontEast(true);
            UpdateView();
        }
        public void VerticalSideWest(object sender, RoutedEventArgs e) {
            cube.TwistVerticalSideWest(false);
            UpdateView();
        }
        public void VerticalSideWestReversed(object sender, RoutedEventArgs e) {
            cube.TwistVerticalSideWest(true);
            UpdateView();
        }
        public void VerticalSideEast(object sender, RoutedEventArgs e) {
            cube.TwistVerticalSideEast(false);
            UpdateView();
        }
        public void VerticalSideEastReversed(object sender, RoutedEventArgs e) {
            cube.TwistVerticalSideEast(true);
            UpdateView();
        }
        
    }
    
}