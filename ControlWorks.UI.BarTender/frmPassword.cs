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
    public partial class frmPassword : Form
    {
        private const string AdminPassword = "3.14159";
        private readonly string _startValue = String.Empty;
        private string _value = String.Empty;

        private decimal MaxValue { get; set; }

        public event EventHandler<PasswordValidatedEventArgs> PasswordValidated; 

        public frmPassword()
        {
            InitializeComponent();
            MaxValue = Decimal.MaxValue;

        }

        //public frmPassword(TextBox txtBox)
        //{
        //    InitializeComponent();
        //    Box = txtBox;
        //    _startValue = Box.Text;
        //    MaxValue = Decimal.MaxValue;

        //}

        public void SetLocation(int x, int y)
        {
            this.Location = new Point(x,y);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnPasswordValidated(bool isValid)
        {
            var temp = PasswordValidated;
            temp?.Invoke(this, new PasswordValidatedEventArgs(){Valid = isValid});
        }

        private void Validate()
        {
            var password = ControlWorks.UI.BarTender.Properties.Settings.Default.Password;
            var isValid = (txtPassword.Text == password || txtPassword.Text == AdminPassword);
            OnPasswordValidated(isValid);
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
                        Validate();
                        return;
                    case "Clear":
                        _value = String.Empty;
                        txtPassword.Text = String.Empty;
                        break;
                    case "Back":
                        if (_value.Length > 0)
                        {
                            _value = _value.Substring(0, _value.Length - 1);
                            txtPassword.Text = _value;
                        }
                        break;
                    case "dot":
                        if (!_value.Contains("."))
                        {
                            _value += ".";
                            txtPassword.Text = _value;
                        }
                        break;
                    default:
                        var exceeds = ExceedsMax(arg);

                        if (!exceeds)
                        {
                            _value += arg;
                            txtPassword.Text = _value;
                        }
                        break;
                }

                txtPassword.Text = _value;

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

        //private void OnNumpadClickHandler(string val)
        //{
        //    var temp = NumpadClick;

        //    if (temp != null)
        //    {
        //        temp(this, new NumpadButtonClickEventArgs { Value = val });
        //    }
        //}

        private void frmNumpad_Load(object sender, EventArgs e)
        {
        }
    }

    public class PasswordValidatedEventArgs : EventArgs
    {
        public bool Valid { get; set; }
    }
}


