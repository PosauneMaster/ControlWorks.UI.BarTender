using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWorks.UI.BarTender
{
    public partial class frmNumpad : Form
    {
        public TextBox Box { get; }
        private readonly string _startValue;
        private string _value = String.Empty;

        public event EventHandler<NumpadButtonClickEventArgs> NumpadClick;

        public decimal MaxValue { get; set; }

        public frmNumpad()
        {
            InitializeComponent();
            MaxValue = Decimal.MaxValue;

        }

        public frmNumpad(TextBox txtBox)
        {
            InitializeComponent();
            Box = txtBox;
            _startValue = Box.Text;
            MaxValue = Decimal.MaxValue;

        }

        public void SetLocation(int x, int y)
        {
            this.Location = new Point(x,y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNumpad_Click(object sender, EventArgs e)
        {

        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                var arg = String.Empty;

                if (button.Tag != null)
                {
                    arg = button.Tag.ToString();
                }

                switch (arg)
                {
                    case "Enter":

                        if (!IsValid(_value))
                        {
                            Box.Text = _startValue;
                        }

                        Close();
                        return;
                    case "Clear":
                        _value = String.Empty;
                        Box.Text = String.Empty;
                        break;
                    case "Back":
                        if (_value.Length > 0)
                        {
                            _value = _value.Substring(0, _value.Length - 1);
                            Box.Text = _value;
                        }
                        break;
                    case "dot":
                        if (!_value.Contains("."))
                        {
                            _value += ".";
                            Box.Text = _value;
                        }
                        break;
                    default:
                        var exceeds = ExceedsMax(arg);

                        if (!exceeds)
                        {
                            _value += arg;
                            Box.Text = _value;
                        }
                        break;
                }

                Box.Text = _value;

            }
        }

        private bool IsValid(string val)
        {
            decimal d;
            return Decimal.TryParse(val, out d);
        }

        private bool ExceedsMax(string arg)
        {
            decimal d1;
            Decimal.TryParse(String.Concat(_value,arg), out d1);

            return d1 > MaxValue;
        }

        private void OnNumpadClickHandler(string val)
        {
            var temp = NumpadClick;

            if (temp != null)
            {
                temp(this, new NumpadButtonClickEventArgs { Value = val });
            }
        }

        private void frmNumpad_Load(object sender, EventArgs e)
        {
        }
    }

    public class NumpadButtonClickEventArgs : EventArgs
    {
        public string Value { get; set; }
    }
}


