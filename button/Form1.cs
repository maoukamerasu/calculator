using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string value1="0";
		string value2="0";
		int calculation = 0;
		bool reset = false;
		public string Plus(string value1, string value2) {
			float label = float.Parse(value1) + float.Parse(value2);
			return label.ToString();
		}
		public string Minus(string value1, string value2)
		{
			float label = float.Parse(value1) - float.Parse(value2);
			return label.ToString();
		}
		public string Multiplication(string value1, string value2)
		{
			float label = float.Parse(value1) * float.Parse(value2);
			return label.ToString();
		}
		public string Division(string value1, string value2)
		{
			float label = float.Parse(value1) / float.Parse(value2);
			return label.ToString();
		}
		private void click(object sender, EventArgs e)
		{
			if (float.Parse(label1.Text) != 0&& float.Parse(label1.Text) * 10 + float.Parse(((Button)sender).Text)<99999999&&reset!=true)
			{
				float value = float.Parse(label1.Text) * 10 + float.Parse(((Button)sender).Text);
				label1.Text = value.ToString();
			}
			else if(float.Parse(label1.Text) == 0|| reset == true) {
				label1.Text = ((Button)sender).Text;
				reset = false;
			}
		}
		private void EqualButton(object ender, EventArgs e) {
			if (value2 == "0")
				value2 = label1.Text;
			else
				value1 = label1.Text;
			switch (calculation) {
				case 1:
				   label1.Text = Plus(value1, value2);
				   break;
				case 2:
					label1.Text = Minus(value1, value2);
					break;
				case 3:
					label1.Text = Multiplication(value1, value2);
					break;
				case 4:
					label1.Text = Division(value1, value2);
					break;
			}
			reset = true;
		}
		private void PlusButton(object ender, EventArgs s) {
			value1 = label1.Text;
			calculation = 1;
			reset = true;
		}
		private void MinusButton(object ender, EventArgs s)
		{
			value1 = label1.Text;
			calculation = 2;
			reset = true;
		}
		private void MultiplicationButton(object ender, EventArgs s)
		{
			value1 = label1.Text;
			calculation = 3;
			reset = true;
		}
		private void DivisionButton(object ender, EventArgs s)
		{
			value1 = label1.Text;
			calculation = 4;
			reset = true;
		}
		private void ResetButton(object ender, EventArgs s)
		{
			label1.Text = "0";
			calculation = 0;
			value1 = "0";
			value2 = "0";
		}
		private void SquareRoot(object ender, EventArgs s) {
			label1.Text = Math.Sqrt(float.Parse(label1.Text)).ToString();
			reset = true;
		}
	}
}
