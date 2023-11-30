using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrancyConverter : Page
	{

		public CurrancyConverter()
		{
			this.InitializeComponent();
			comboFrom.Items.Add("US Dollar");
			comboFrom.Items.Add("Euro");
			comboFrom.Items.Add("British Pound");
			comboFrom.Items.Add("Indian Rupee");

			comboTo.Items.Add("US Dollar");
			comboTo.Items.Add("Euro");
			comboTo.Items.Add("British Pound");
			comboTo.Items.Add("Indian Rupee");

		}

		private void btnConvert_Click(object sender, RoutedEventArgs e)
		{
			double amount = double.Parse(txtAmount.Text);

			if (comboFrom.SelectedIndex == 0)
			{
				txtStartValue.Text = amount.ToString() + " US Dollar =";
				if (comboTo.SelectedIndex == 0)
				{
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 US Dollar = 1 US Dollar";
					txtConvertTo.Text = "1 US Dollar = 1 US Dollar";
				}
				else if (comboTo.SelectedIndex == 1)
				{
					amount = amount * 0.85189982;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 US Dollar = " + 0.85189982 + " Euros";
					txtConvertTo.Text = "1 Euro = " + 1.1739732 + " US Dollars";
				}
				else if (comboTo.SelectedIndex == 2)
				{
					amount = amount * 0.72872436;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 US Dollar = " + 0.72872436 + " Bristish Pounds";
					txtConvertTo.Text = "1 British Pound = " + 1.371907 + " US Dollars";
				}
				else if (comboTo.SelectedIndex == 3)
				{
					amount = amount * 74.257327;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 US Dollar = " + 74.257327 + " Indian Rupee";
					txtConvertTo.Text = "1 Indian Rupee = " + 0.011492628 + " US Dollars";
				}
			}
			else if (comboFrom.SelectedIndex == 1)
			{
				txtStartValue.Text = amount.ToString() + " Euro =";
				if (comboTo.SelectedIndex == 0)
				{
					amount = amount * 1.1739732;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 Euro = " + 1.1739732 + " US Dollars";
					txtConvertTo.Text = "1 US Dollars = " + 0.85189982 + " Euros";
				}
				else if (comboTo.SelectedIndex == 1)
				{
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 Euro = 1 Euro" ;
					txtConvertTo.Text = "1 Euro = 1 Euro";
				}
				else if (comboTo.SelectedIndex == 2)
				{
					amount = amount * 0.8556672;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 Euro = " + 0.8556672 + " British Pounds";
					txtConvertTo.Text = "1 British Pounds = " + 1.1686692 + " Euros";
				}
				else if (comboTo.SelectedIndex == 3)
				{
					amount = amount * 87.00755;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 Euro = " + 87.00755 + " Indian Rupee";
					txtConvertTo.Text = "1 Indian Rupee = " + 0.013492774 + " Euros";
				}
			}
			else if (comboFrom.SelectedIndex == 2)
			{
				txtStartValue.Text = amount.ToString() + " British Pound =";
				if (comboTo.SelectedIndex == 0)
				{
					amount = amount * 1.371907;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 British Pound = " + 1.371907 + " US Dollars";
					txtConvertTo.Text = "1 US Dollars = " + 0.72872436 + "  British Pound";
				}
				else if (comboTo.SelectedIndex == 1)
				{
					amount = amount * 1.1686692;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 British Pound = " + 1.1686692 + " Euros";
					txtConvertTo.Text = "1 Euro = " + 0.8556672 + "  British Pound";
				}
				else if (comboTo.SelectedIndex == 2)
				{
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 British Pound = 1 British Pound";
					txtConvertTo.Text = "1 British Pound = 1 British Pound";
				}
				else if (comboTo.SelectedIndex == 3)
				{
					amount = amount * 101.68635;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 British Pound = " + 101.68635 + " Indian Rupee";
					txtConvertTo.Text = "1 Indian Rupee = " + 0.0098339397 + "  British Pound";
				}
			}
			else if (comboFrom.SelectedIndex == 3)
			{
				txtStartValue.Text = amount.ToString() + " Indian Rupee =";
				if (comboTo.SelectedIndex == 0)
				{
					amount = amount * 0.011492628;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 Indian Rupee = " + 0.011492628 + " US Dollars";
					txtConvertTo.Text = "1 US Dollars = " + 74.257327 + "  Indian Rupee";
				}
				else if (comboTo.SelectedIndex == 1)
				{
					amount = amount * 0.013492774;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 Indian Rupee = " + 0.013492774 + " Euros";
					txtConvertTo.Text = "1 Euro = " + 87.00755 + "  Indian Rupee";
				}
				else if (comboTo.SelectedIndex == 2)
				{
					amount = amount * 0.0098339397;
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 Indian Rupee = " + 0.0098339397 + " British Pounds";
					txtConvertTo.Text = "1 British Pound = " + 101.68635 + "  Indian Rupee";
				}
				else if (comboTo.SelectedIndex == 3)
				{
					txtTotal.Text = amount.ToString();
					txtConvertFrom.Text = "1 Indian Rupee = 1 Indian Rupee";
					txtConvertTo.Text = "1 Indian Rupee = 1 Indian Rupee";
				}
			}
		}
		private void btnExit_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}

		private void txtAmount_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void comboFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void comboTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
		{

		}

		private void txtTotal_SelectionChanged(object sender, RoutedEventArgs e)
		{

		}
	}
}
