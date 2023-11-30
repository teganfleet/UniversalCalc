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
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private void calculate_button_Click(object sender, RoutedEventArgs e)
		{
			float P = float.Parse(principal_borrow.Text);
			double yir = (double.Parse(year_interest_rate.Text) / 100) / 12;
			month_interest_rate.Text = yir.ToString("n4") + "%";
			double n = double.Parse(months.Text);
			double y = double.Parse(years.Text);
			double ym = y * 12;
			double ny = n + ym;
			double M;
			double Tpr = P * yir * Math.Pow((1 + yir), ny);
			double Divisor = Math.Pow((1 + yir), ny) - 1;
			M = Tpr / Divisor;
			month_repay_amount.Text = M.ToString("n2");
		}
	}
}
