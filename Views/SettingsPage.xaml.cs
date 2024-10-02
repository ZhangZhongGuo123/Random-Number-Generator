using System.Configuration;
using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.Windows.ApplicationModel.Resources;
using Random_Number_Generator.ViewModels;
using Windows.ApplicationModel.Resources;
using Windows.Storage;

namespace Random_Number_Generator.Views;

// TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
public sealed partial class SettingsPage : Page
{
    public static int minimum;
    public static int maximum;
    public static int oncenumber;
    public static int mode;
    public static bool ifreadconfig = true;
    public SettingsViewModel ViewModel
    {
        get;
    }

    public SettingsPage()
    {
        ViewModel = App.GetService<SettingsViewModel>();
        InitializeComponent();
        if (ifreadconfig)
        {
            readconfig();
            ifreadconfig = false;
        }
        MinimumSet.Text = ApplicationData.Current.LocalSettings.Values["min"].ToString();
        MaximumSet.Text = ApplicationData.Current.LocalSettings.Values["max"].ToString();
        if (oncenumber <= 12 && oncenumber >= 1)
        {
            Number_of_drawsSet.SelectedIndex = int.Parse(ApplicationData.Current.LocalSettings.Values["once"].ToString()) - 1;
        }
        if (mode <= 3 && mode >= 1)
        {
            ModeSet.SelectedIndex = int.Parse(ApplicationData.Current.LocalSettings.Values["mode"].ToString()) - 1;
        }
    }


    private void MaximumSet_TextChanged(object sender, TextChangedEventArgs e)
    {

        int min = 0;
        if (MinimumSet.Text != null)
        {


            try
            {
                min = int.Parse(MinimumSet.Text);
            }
            catch
            {
                if (!string.IsNullOrEmpty(MinimumSet.Text))
                {
                    MinimumSet.Text = MinimumSet.Text.Remove(MinimumSet.Text.Length - 1, 1);
                }
            }
            finally
            {

            }
        }
        int once = 0;
        if (Number_of_drawsSet.SelectedValue != null)
        {


            try
            {
                var selectedValue = Number_of_drawsSet.SelectedValue;
                once = int.Parse(selectedValue.ToString());
            }
            catch
            {
            }
        }

        int max = 0;
        if (MaximumSet.Text != null)
        {


            try
            {
                max = int.Parse(MaximumSet.Text);
            }
            catch
            {
                if (!string.IsNullOrEmpty(MaximumSet.Text))
                {
                    MaximumSet.Text = MaximumSet.Text.Remove(MaximumSet.Text.Length - 1, 1);
                }
            }
            finally
            {
            }

            if (min > max - once)
            {
                this.MaximumSet.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 240, 128, 128));
                MaximumErr.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 240, 128, 128));
                Windows.ApplicationModel.Resources.ResourceLoader resourceLoader = new Windows.ApplicationModel.Resources.ResourceLoader();
                MaximumErr.Text = resourceLoader.GetString("ErrText_MinMax");
                //MaximumErr.Text = "Unable to extract numbers within the selected range.";
                this.MinimumSet.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 240, 128, 128));
                MinimumErr.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 240, 128, 128));
                MinimumErr.Text = resourceLoader.GetString("ErrText_MinMax");
                //MinimumErr.Text = "Unable to extract numbers within the selected range.";
            }
            else
            {
                this.MaximumSet.Background = null;
                MaximumErr.Text = "";
                this.MinimumSet.Background = null;
                MinimumErr.Text = "";
                HomePage.AddUpdateAppSettings("max", max.ToString());
                ApplicationData.Current.LocalSettings.Values["max"] = max.ToString();
            }
        }

    }


    private void MinimumSet_TextChanged(object sender, TextChangedEventArgs e)
    {
        int min = 0;
        if (MinimumSet.Text != null)
        {


            try
            {
                min = int.Parse(MinimumSet.Text);
            }
            catch
            {
                if (!string.IsNullOrEmpty(MinimumSet.Text))
                {
                    MinimumSet.Text = MinimumSet.Text.Remove(MinimumSet.Text.Length - 1, 1);
                }
            }
            finally
            {

            }
        }
        int once = 0;
        if (Number_of_drawsSet.SelectedValue != null)
        {


            try
            {
                var selectedValue = Number_of_drawsSet.SelectedValue;
                once = int.Parse(selectedValue.ToString());
            }
            catch
            {
            }
        }

        int max = 0;
        if (MaximumSet.Text != null)
        {


            try
            {
                max = int.Parse(MaximumSet.Text);
            }
            catch
            {
                if (!string.IsNullOrEmpty(MaximumSet.Text))
                {
                    MaximumSet.Text = MaximumSet.Text.Remove(MaximumSet.Text.Length - 1, 1);
                }
            }
            finally
            {
            }

            if (min > max - once)
            {
                this.MaximumSet.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 240, 128, 128));
                MaximumErr.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 240, 128, 128));
                Windows.ApplicationModel.Resources.ResourceLoader resourceLoader = new Windows.ApplicationModel.Resources.ResourceLoader();
                MaximumErr.Text = resourceLoader.GetString("ErrText_MinMax");
                //MaximumErr.Text = "Unable to extract numbers within the selected range.";
                this.MinimumSet.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 240, 128, 128));
                MinimumErr.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 240, 128, 128));
                MinimumErr.Text = resourceLoader.GetString("ErrText_MinMax");
                //MinimumErr.Text = "Unable to extract numbers within the selected range.";
            }
            else
            {
                this.MaximumSet.Background = null;
                MaximumErr.Text = "";
                this.MinimumSet.Background = null;
                MinimumErr.Text = "";
                HomePage.AddUpdateAppSettings("min", min.ToString());
                ApplicationData.Current.LocalSettings.Values["min"] = min.ToString();
            }
        }
    }

    private void Number_of_drawsSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        int once;
        if (Number_of_drawsSet.SelectedValue != null)
        {


            try
            {
                var selectedValue = Number_of_drawsSet.SelectedValue;
                once = int.Parse(selectedValue.ToString());
                HomePage.AddUpdateAppSettings("once", once.ToString());
                ApplicationData.Current.LocalSettings.Values["once"] = once.ToString();
            }
            catch
            {
            }
        }

    }
    public void readconfig()
    {
        try
        {
            var appSettings = ConfigurationManager.AppSettings;
            minimum = int.Parse(appSettings["min"]);
            maximum = int.Parse(appSettings["max"]);
            oncenumber = int.Parse(appSettings["once"]);
            mode = int.Parse(appSettings["mode"]);
        }
        catch (ConfigurationErrorsException)
        {


        }
    }

    private void ModeSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        int mode;
        if (ModeSet.SelectedValue != null)
        {


            try
            {
                var selectedValue = ModeSet.SelectedIndex;
                mode = int.Parse(selectedValue.ToString()) + 1;
                HomePage.AddUpdateAppSettings("mode", mode.ToString());
                ApplicationData.Current.LocalSettings.Values["mode"] = mode.ToString();
            }
            catch
            {
            }
        }

    }
}
