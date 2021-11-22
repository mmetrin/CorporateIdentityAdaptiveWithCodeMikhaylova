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

namespace CorporateIdentityAdaptiveWithCode
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush MainColor = new SolidColorBrush(Color.FromRgb(105, 149, 194));

        //цвет серого текста
        SolidColorBrush GrayColor = new SolidColorBrush(Color.FromRgb(126, 126, 126));
        //фоновый цвет кнопок
        SolidColorBrush BackColorBtn = new SolidColorBrush(Color.FromRgb(247, 247, 247));
        //цвет черного текста
        SolidColorBrush BlackColor = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        //цвет заголовка (с примера pdf)
        SolidColorBrush GrayColorTitle = new SolidColorBrush(Color.FromRgb(71, 73, 78));

        FontFamily MicrosoftSansSerif = new FontFamily("Microsoft Sans Serif");

        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void AdminGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DockPanel HeaderPanel = new DockPanel();
            StackPanel HeaderStackPanel = new StackPanel();

            Image LogoJpg = new Image
            {
                Source = new BitmapImage(new Uri("Resources/logo.jpg", UriKind.Relative)),
                Width = 19,
                Height = 35,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 0, 0)
            };
            DockPanel.SetDock(LogoJpg, Dock.Left);

            TextBlock LabName = new TextBlock
            {
                Text = "NBA Manegement System",
                FontSize = 12,
                Margin = new Thickness(5, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = GrayColor
            };
            DockPanel.SetDock(LabName, Dock.Left);

            TextBlock LabTitle = new TextBlock
            {
                FontFamily = new FontFamily("Calibri"),
                Text = "Admin Login",
                FontSize = 16,
                TextAlignment = TextAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(10, 0, 70, 0),
                Foreground = GrayColorTitle
            };

            Button BtnBack = new Button
            {
                Width = 55,
                Height = 25,
                BorderThickness = new Thickness(0.5),
                Content = "Back",
                Margin = new Thickness(0, 0, 10, 0),
                VerticalAlignment = VerticalAlignment.Center,
                BorderBrush = Brushes.DarkGray,
                IsEnabled = false,
                
            };
            DockPanel.SetDock(BtnBack, Dock.Right);
            
            Border border = new Border
            {
                BorderBrush = MainColor,
                BorderThickness = new Thickness(0.5),
                Margin = new Thickness(Top = 4)
            };

            DockPanel.SetDock(border, Dock.Bottom);
            HeaderPanel.Children.Add(LogoJpg);
            HeaderPanel.Children.Add(LabName);
            HeaderPanel.Children.Add(BtnBack);
            HeaderPanel.Children.Add(LabTitle);
            DockPanel.SetDock(HeaderStackPanel, Dock.Top);
            HeaderStackPanel.Children.Add(HeaderPanel);
            HeaderStackPanel.Children.Add(border);
            AdminGrid.Children.Add(HeaderStackPanel);


            DockPanel LabNoteLogin = new DockPanel { Margin = new Thickness(0, 50, 0, 0) };
            TextBlock LabText = new TextBlock
            {
                Foreground = GrayColor,
                FontFamily = MicrosoftSansSerif,
                FontSize = 12,
                Text = "Users can login into the system using their jobnumber and password",
                TextAlignment = TextAlignment.Center
            };
            LabNoteLogin.Children.Add(LabText);

            DockPanel PanelForJobnumber = new DockPanel { Margin = new Thickness(0, 40, 0, 0) };
            TextBlock JobNumberLab = new TextBlock
            {
                Text = "JobNumber:",
                FontFamily = MicrosoftSansSerif,
                FontSize = 10,
                Margin = new Thickness(70, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = BlackColor,
                HorizontalAlignment = HorizontalAlignment.Right,
                TextAlignment = TextAlignment.Right,

            };
            TextBox TxtJobnumber = new TextBox
            {
                Height = 20,
                Width=180,
                FontSize = 10,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = BlackColor,
            };
            DockPanel ContainerFirst = new DockPanel { MaxWidth = 350, MinWidth = 100 };
            ContainerFirst.Children.Add(JobNumberLab);
            ContainerFirst.Children.Add(TxtJobnumber);
            PanelForJobnumber.Children.Add(ContainerFirst);

            DockPanel PanelForPassword = new DockPanel { Margin = new Thickness(5, 20, 0, 0) };
            TextBlock Password = new TextBlock
            {
                Text = "Password:",
                FontFamily = MicrosoftSansSerif,
                FontSize = 10,
                Margin = new Thickness(70, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = BlackColor,
                HorizontalAlignment = HorizontalAlignment.Right,
                TextAlignment = TextAlignment.Right,

            };
            TextBox TxtPassword = new TextBox
            {
                Height = 20,
                FontSize = 10,
                Width=180,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = BlackColor,
            };
            DockPanel ContainerSecond = new DockPanel { MaxWidth = 350, MinWidth = 100 };
            ContainerSecond.Children.Add(Password);
            ContainerSecond.Children.Add(TxtPassword);
            PanelForPassword.Children.Add(ContainerSecond);

            DockPanel PanelforCheckBox = new DockPanel { Margin = new Thickness(0, 20, 0, 0) };
            DockPanel ContainerThird = new DockPanel { MaxWidth = 150, Margin = new Thickness(0, 0, 30, 0) };

            CheckBox checkBox = new CheckBox()
            {
                Margin = new Thickness(60, 0, 0, 0),
            };

            TextBlock TxtForCheckBox = new TextBlock
            {
                Text = "Remember me",
                FontFamily = MicrosoftSansSerif,
                FontSize = 10,
                Margin = new Thickness(5, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = BlackColor,
                HorizontalAlignment = HorizontalAlignment.Left,
                TextAlignment = TextAlignment.Left,

            };
            ContainerThird.Children.Add(checkBox);
            ContainerThird.Children.Add(TxtForCheckBox);
            PanelforCheckBox.Children.Add(ContainerThird);

            DockPanel PanelforButtons = new DockPanel { Margin = new Thickness(0, 20, 0, 0) };
            Grid ContainerFourth = new Grid { MaxWidth = 300, Margin = new Thickness(80, 0, 0, 0) };

            Button BtnLogin = new Button
            {
                Content = "Login",
                Height = 30,
                Margin = new Thickness(60, 0, 0, 0),
                Background = BackColorBtn,
                Width = 69
            };

            Button BtnCancel = new Button
            {
                Content = "Cancel",
                Height = 30,
                Background = BackColorBtn,
                Width=69
            };
            ContainerFourth.ColumnDefinitions.Add(new ColumnDefinition());
            ContainerFourth.ColumnDefinitions.Add(new ColumnDefinition());
            ContainerFourth.ColumnDefinitions.Add(new ColumnDefinition());
            ContainerFourth.RowDefinitions.Add(new RowDefinition());

            ContainerFourth.ColumnDefinitions[1].Width = new GridLength(30);

            Grid.SetColumn(BtnLogin, 0);
            Grid.SetRow(BtnLogin, 0);
            Grid.SetColumn(BtnCancel, 2);
            Grid.SetRow(BtnCancel, 0);
            ContainerFourth.Children.Add(BtnLogin);
            ContainerFourth.Children.Add(BtnCancel);
            PanelforButtons.Children.Add(ContainerFourth);

            StackPanel MainPanel = new StackPanel();

            MainPanel.Children.Add(LabNoteLogin);
            MainPanel.Children.Add(PanelForJobnumber);
            MainPanel.Children.Add(PanelForPassword);
            MainPanel.Children.Add(PanelforCheckBox);
            MainPanel.Children.Add(PanelforButtons);
            DockPanel FooterPanel = new DockPanel { Background = MainColor, MinHeight = 20, MinWidth = 300 };
            DockPanel.SetDock(FooterPanel, Dock.Bottom);

            TextBlock FooterText = new TextBlock
            {
                Text = "The current season is 2016-2017, and the NBA already has a history of 71 years.",
                TextAlignment = TextAlignment.Center,
                Foreground = Brushes.White,
                FontSize = 10,
                VerticalAlignment = VerticalAlignment.Center
            };
            FooterPanel.Children.Add(FooterText);
            AdminGrid.Children.Add(FooterPanel);
            AdminGrid.Children.Add(MainPanel);
        }
    }
}
