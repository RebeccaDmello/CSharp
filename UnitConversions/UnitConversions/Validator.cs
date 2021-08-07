using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UnitConversions
{
	public static class Validator
	{
		private static string title = "Error";
		public static string Title
		{
			get => title;
			set => title = value;
		}

		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool IsFloat(TextBox textBox)
		{
			float number = 0f;
			if (float.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be a float value.", Title);
				textBox.Focus();
				return false;
			}
		}
	}
}
