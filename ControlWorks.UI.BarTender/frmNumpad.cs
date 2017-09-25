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
        private TextBox _textBox;
        private string _value = String.Empty;

        public event EventHandler<NumpadButtonClickEventArgs> NumpadClick;

        public frmNumpad()
        {
            InitializeComponent();
        }

        public frmNumpad(TextBox txtBox)
        {
            InitializeComponent();
            _textBox = txtBox;
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
            var button = sender as Button;
            if (button != null)
            {
                var arg = String.Empty;

                if (button.Tag != null)
                {
                    arg = button.Tag.ToString();
                }

                switch (arg)
                {
                    case "Enter":
                        this.Close();
                        break;
                    case "Clear":
                        _value = String.Empty;
                        _textBox.Text = String.Empty;
                        break;
                    case "Back":
                        if (_value.Length > 0)
                        {
                            _value = _value.Substring(0, _value.Length - 1);
                            _textBox.Text = _value;
                        }
                        break;
                    case "dot":
                        if (!_value.Contains("."))
                        {
                            _value += ".";
                            _textBox.Text = _value;
                        }
                        break;
                    default:
                        _value += arg;
                        _textBox.Text = _value;
                        break;
                }
            }
        }

        private void OnNumpadClickHandler(string val)
        {
            var temp = NumpadClick;

            if (temp != null)
            {
                NumpadClick(this, new NumpadButtonClickEventArgs { Value = val });
            }
        }
    }

    public class NumpadButtonClickEventArgs : EventArgs
    {
        public string Value { get; set; }
    }
}


