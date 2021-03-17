using System;

namespace ViewModellerLite
{
    class Program
    {

        static void Main(string[] args)
        {
            //string viewPath = args[0];
           // string viewModelsFolderPath = args[1];
            //Console.WriteLine(ViewModellerCore.ViewModeller.CreateCommand("getOut"));
            //Console.WriteLine(ViewModellerCore.ViewModeller.CreateTCommand("GetIn","string"));
            //Console.WriteLine(ViewModellerCore.ViewModeller.CreateProperty("sallary", "decimal"));
            Console.WriteLine(ViewModellerCore.ViewModeller.BindedPropertiesExtractor(@"<UserControl
    x: Class = ""IntermexDirect.DebitCardPlugin.Controls.HomeCard.HomeCardView""
    xmlns = ""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
    xmlns: x = ""http://schemas.microsoft.com/winfx/2006/xaml""
    xmlns: d = ""http://schemas.microsoft.com/expression/blend/2008""
    xmlns: l = ""http://wpflocalizeextension.codeplex.com""
    xmlns: local = ""clr-namespace:IntermexDirect.DebitCardPlugin.Controls.HomeCard""
    xmlns: mc = ""http://schemas.openxmlformats.org/markup-compatibility/2006""
    xmlns: md = ""http://materialdesigninxaml.net/winfx/xaml/themes""
    xmlns: plugins = ""clr-namespace:IntermexDirect.UI;assembly=IntermexDirect.ComponentModel""
    Width = ""372""
    Height = ""250""
    d: DataContext = ""{d:DesignInstance local:HomeCardDesignTimeViewModel,
                                     IsDesignTimeCreatable = True}""
    l: LocalizeDictionary.DesignCulture = ""en""
    l: ResxLocalizationProvider.DefaultAssembly = ""DEBITCARD""
    l: ResxLocalizationProvider.DefaultDictionary = ""Strings""
    plugins: ViewModelLocator.AutoHookedUpViewModel = ""True""
    mc: Ignorable = ""d"" >
 
     < UserControl.Resources >
 
         < ResourceDictionary >
 
             < ResourceDictionary.MergedDictionaries >
 
                 < ResourceDictionary Source = ""pack://application:,,,/IntermexDirect.ComponentModel;component/Styles/IntermexDirectResourceDictionary.xaml"" />
  
              </ ResourceDictionary.MergedDictionaries >
  
              < SolidColorBrush x: Key = ""CardTitleForeground"" Color = ""#1D313A"" />
      
                  < SolidColorBrush x: Key = ""CardTitleBackground"" Color = ""#F3F3F3"" />
          
                  </ ResourceDictionary >
          
              </ UserControl.Resources >
          
              < DockPanel >
          
                  < Border
            Padding = ""10""
            Background = ""{StaticResource CardTitleBackground}""
            DockPanel.Dock = ""Top"" >
            < DockPanel >
                < md:PackIcon
                     Width = ""26""
                    Height=""23""
                    VerticalAlignment=""Center""
                    DockPanel.Dock=""Left""
                    Foreground=""{StaticResource CardTitleForeground}""
                    Kind=""CreditCard"" />
                <TextBlock
                    Margin=""15,0,0,0""
                    VerticalAlignment=""Center""
                    DockPanel.Dock=""Left""
                    FontSize=""18""
                    Foreground=""{StaticResource CardTitleForeground}""
                    Text=""{l:LocText DebitCard_Card_Title}"" />
                <TextBlock
                    Margin=""5,0""
                    HorizontalAlignment=""Right""
                    VerticalAlignment=""Top""
                    DockPanel.Dock=""Right""
                    FontSize=""10""
                    Text=""{Binding Version}"" />

            </DockPanel>
        </Border>

        <Border Padding=""15"" DockPanel.Dock=""Bottom"">
            <UniformGrid
                HorizontalAlignment=""Left""
                Columns=""1""
                Rows=""4"">
                <Button
                    Margin=""0,0,0,5""
                    Command=""{Binding RegistrationCommand}""
                    Content=""{l:LocTextUpper DebitCard_Card_Registration}"" />

                <Button
                    Margin=""0,0,0,5""
                    Command=""{Binding ReloadCommand}""
                    Content=""{l:LocTextUpper DebitCard_Card_Reload}"" />

                <Button
                    Margin=""0,0,0,5""
                    Command=""{Binding BalanceInquiryCommand}""
                    Content=""{l:LocTextUpper DebitCard_Card_BalanceInquiry}"" />

                <Button
                    Margin=""0,0,0,5""
                    Command=""{Binding SearchTransactionsCommand}""
                    Content=""{l:LocTextUpper DebitCard_Card_SearchTransactions}"" />

            </UniformGrid>
        </Border>

        <Grid>
            <TextBlock
                Grid.Row=""1""
                Margin=""15,0,0,0""
                FontSize=""20""
                Foreground=""{StaticResource PrimaryHueMidBrush}""
                Text=""{l:LocText DebitCard_Card_WelcomeMessage}""
                TextWrapping=""Wrap"" />
        </Grid>
    </DockPanel>
</UserControl>
"));

        }
        public class DelegateCommand { }
    }
   
}
