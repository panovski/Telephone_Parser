using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Parser.UserControls
{
    public partial class TextBoxCaption : UserControl
    {
        #region Load
        public TextBoxCaption()
        {
            InitializeComponent();
        }
        private void TextBoxCaption_Load(object sender, EventArgs e)
        {
            Label.Text = Caption;

            if (IsUpper == 1)
            {
                TextBox.CharacterCasing = CharacterCasing.Upper;
            }
        }
        #endregion

        #region Additional Property
        string _Caption = "";
        public string Caption
        {
	        get
	        {
	            return this._Caption;
	        }
	        set
	        {
	            this._Caption = value;
	        }
        }

        int _IsNumber = 0;
        public int IsNumber
        {
            get
            {
                return this._IsNumber;
            }
            set
            {
                this._IsNumber = value;
            }
        }

        int _IsUpper = 0;
        public int IsUpper
        {
            get
            {
                return this._IsUpper;
            }
            set
            {
                this._IsUpper = value;
            }
        }

        #endregion

        #region Button Clicks
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumber == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    e.Handled = true;

                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                    e.Handled = true;
            }
        }
        #endregion
    }
}
