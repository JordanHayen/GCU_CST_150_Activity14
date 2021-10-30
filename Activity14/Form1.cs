using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class Form1 : Form
    {

        private string fontName; // A string field that will contain the name of the current font
        private bool bold; // A boolean field that will determine whether or not the text is bold
        private bool italic; // A boolean field that will determine whether or not the text is italic
        private bool underline; // A boolean field that will determine whether or not the text is underlined

        public Form1()
        {
            InitializeComponent();
        }

        // This code runs when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            SansSerif.Checked = true; // The SansSerif radio button is checked by default
            fontName = "Microsoft Sans Serif"; // The fontName field is set to "Microsoft Sans Serif" by default
            // All fields pertaining to font style are false by default
            bold = false;
            italic = false;
            underline = false;
        }

        private void SelectFont_Enter(object sender, EventArgs e)
        {

        }

        // This code runs when the Arial radio button is checked. Made with help from the textbook (Gaddis, 246)
        private void Arial_CheckedChanged(object sender, EventArgs e)
        {
            fontName = "Arial"; // The fontName field is set to "Arial"
            UpdateFont(); // The UpdateFont method is called
        }

        // This code runs when the TimesNewRoman radio button is checked. Made with help from the textbook (Gaddis, 246)
        private void TimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            fontName = "Times New Roman"; // The fontName field is set to "Times New Roman"
            UpdateFont(); // The UpdateFont method is called
        }

        // This code runs when the CourierNew radio button is checked. Made with help from the textbook (Gaddis, 246)
        private void CourierNew_CheckedChanged(object sender, EventArgs e)
        {
            fontName = "Courier New"; // The fontName field is set to "Courier New"
            UpdateFont(); // The UpdateFont method is called
        }

        // This code runs when the SansSerif radio button is checked. Made with help from the textbook (Gaddis, 246)
        private void SansSerif_CheckedChanged(object sender, EventArgs e)
        {
            fontName = "Microsoft Sans Serif"; // The fontName field is set to "Microsoft Sans Serif"
            UpdateFont(); // The UpdateFont method is called
        }

        // This code runs when an item in the ColorListBox is selected
        private void ColorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ColorListBox.SelectedIndex) // The index of the item selected in the ColorListBox is used to set the text color. Made with help from the textbook (Gaddis, 257)
            {
                case 0: // If the selected index is zero, the color is set to red
                    TextBox.ForeColor = Color.Red;
                    break;
                case 1: // If the selected index is one, the color is set to orange
                    TextBox.ForeColor = Color.Orange;
                    break;
                case 2: // If the selected index is two, the color is set to yellow
                    TextBox.ForeColor = Color.Yellow;
                    break;
                case 3: // If the selected index is three, the color is set to green
                    TextBox.ForeColor = Color.Green;
                    break;
                case 4: // If the selected index is four, the color is set to blue
                    TextBox.ForeColor = Color.Blue;
                    break;
                case 5: // If the selected index is five, the color is set to violet
                    TextBox.ForeColor = Color.DarkViolet;
                    break;
                case 6: // If the selected index is six, the color is set to black
                    TextBox.ForeColor = Color.Black;
                    break;
            }
        }

        // This code runs when the Bold checkbox is changed
        private void Bold_CheckedChanged(object sender, EventArgs e)
        {
            if(Bold.Checked) // If the checkbox is checked, the bold field is set to true. Made with help from the textbook (Gaddis, 249)
            {
                bold = true;
            }
            else // Otherwise, the bold field is set to false
            {
                bold = false;
            }
            UpdateFont(); // The UpdateFont method is called
        }

        // This code runs when the Italic checkbox is changed
        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            if (Italic.Checked) // If the checkbox is checked, the italic field is set to true. Made with help from the textbook (Gaddis, 249)
            {
                italic = true;
            }
            else // Otherwise, the italic field is set to false
            {
                italic = false;
            }
            UpdateFont(); // The UpdateFont method is called
        }

        // This code runs when the Underline checkbox is changed
        private void Underline_CheckedChanged(object sender, EventArgs e)
        {
            if (Underline.Checked) // If the checkbox is checked, the underline field is set to true. Made with help from the textbook (Gaddis, 249)
            {
                underline = true;
            }
            else // Otherwise, the underline field is set to false
            {
                underline = false;
            }
            UpdateFont(); // The UpdateFont method is called
        }

        // This method sets the font of the TextBox depending on the fields pertaining to font style
        private void UpdateFont()
        {
            if (bold && italic && underline) // If the bold, italic, and underline fields are all true, the font of the textbox is set to a font with the name of the fontName field that is bold, italic, and underlined
            {
                TextBox.Font = new Font(fontName, 12, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); // Made with help from Microsoft Font Class (n.d.) documentation and the website C# 411 (Toady, 2008)
            }
            else if(bold && italic) // If the bold and italic fields are true, the font of the textbox is set to a font with the name of the fontName field that is bold and italic
            {
                TextBox.Font = new Font(fontName, 12, FontStyle.Bold | FontStyle.Italic); // Made with help from Microsoft Font Class (n.d.) documentation and the website C# 411 (Toady, 2008)
            }
            else if (bold && underline) // If the bold and underline fields are true, the font of the textbox is set to a font with the name of the fontName field that is bold and underlined
            {
                TextBox.Font = new Font(fontName, 12, FontStyle.Bold | FontStyle.Underline); // Made with help from Microsoft Font Class (n.d.) documentation and the website C# 411 (Toady, 2008)
            }
            else if (italic && underline) // If the italic and underline fields are true, the font of the textbox is set to a font with the name of the fontName field that is italic and underlined
            {
                TextBox.Font = new Font(fontName, 12, FontStyle.Italic | FontStyle.Underline); // Made with help from Microsoft Font Class (n.d.) documentation and the website C# 411 (Toady, 2008)
            }
            else if(bold) // If the bold field is true, the font of the textbox is set to a font with the name of the fontName field that is bold
            {
                TextBox.Font = new Font(fontName, 12, FontStyle.Bold); // Made with help from Microsoft Font Class (n.d.) documentation and the website C# 411 (Toady, 2008)
            }
            else if(italic) // If the italic field is true, the font of the textbox is set to a font with the name of the fontName field that is italic
            {
                TextBox.Font = new Font(fontName, 12, FontStyle.Italic); // Made with help from Microsoft Font Class (n.d.) documentation and the website C# 411 (Toady, 2008)
            }
            else if(underline) // If the underline field is true, the font of the textbox is set to a font with the name of the fontName field that is underlined
            {
                TextBox.Font = new Font(fontName, 12, FontStyle.Underline); // Made with help from Microsoft Font Class (n.d.) documentation and the website C# 411 (Toady, 2008)
            }
            else // If none of the fields that pertain to font style are true, the font of the textbox is set to a font with the name of the fontName field
            {
                TextBox.Font = new Font(fontName, 12, FontStyle.Regular); // Made with help from Microsoft Font Class (n.d.) documentation and the website C# 411 (Toady, 2008)
            }
        }
    }
}

// References:
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.
// Microsoft (n.d.). Font Class. https://docs.microsoft.com/en-us/dotnet/api/system.drawing.font?view=windowsdesktop-5.0
// Toady, T. (2008, July, 5). Change Font Style. https://www.csharp411.com/change-font-style/