using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Designer
{
    public partial class FormCardDesigner : Form
    {
        public FormCardDesigner()
        {
            InitializeComponent();
        }
        //Initialize program constants
        const int OCCASIONCOUNT = 3;
        const int STYLECOUNT    = 2;

        //Create arrays
        string[] occasions      = new string[] {"Thank You", "Birthday", "Valentine"};
        string[] styles         = new string[] {"Simple ($1.00)", "Fancy ($1.50)"};

        public string[] images  = new string[] {"C:\\Users\\chris\\OneDrive\\Desktop\\C# Work\\HOTS\\HOT5\\Card Designer\\images\\thankyou_simple.jpg",
                                                        "C:\\Users\\chris\\OneDrive\\Desktop\\C# Work\\HOTS\\HOT5\\Card Designer\\images\\thankyou_fancy.jpg",
                                                        "C:\\Users\\chris\\OneDrive\\Desktop\\C# Work\\HOTS\\HOT5\\Card Designer\\images\\birthday_simple.png",
                                                        "C:\\Users\\chris\\OneDrive\\Desktop\\C# Work\\HOTS\\HOT5\\Card Designer\\images\\birthday_fancy.jpg",
                                                        "C:\\Users\\chris\\OneDrive\\Desktop\\C# Work\\HOTS\\HOT5\\Card Designer\\images\\valentine_simple.png",
                                                        "C:\\Users\\chris\\OneDrive\\Desktop\\C# Work\\HOTS\\HOT5\\Card Designer\\images\\valentine_fancy.jpg"};

        //Fill comboboxes and sets pictures to be resized
        public void FormCardDesigner_Load(object sender, EventArgs e)
        {
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            labelCustomMessage.BackColor = System.Drawing.Color.Transparent;

            for (int i = 0; i < OCCASIONCOUNT; ++i)
            {
                comboBoxOccasion.Items.Add(occasions[i]);
            }
            for (int x = 0; x < STYLECOUNT; ++x)
            {
                comboBoxStyle.Items.Add(styles[x]);
            }
        }

        //Run algorithms when data changes
        public void comboBoxOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            getInputs();
        }
        public void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            getInputs();
        }
        private void checkBoxEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            getInputs();
        }
        private void checkBoxStamp_CheckedChanged(object sender, EventArgs e)
        {
            getInputs();
        }
        private void checkBoxMessage_CheckedChanged(object sender, EventArgs e)
        {
            getInputs();
        }

        //Uses data from comboboxes and checkboxes to finish the program
        private void getInputs()
        {
            int userOccasion = comboBoxOccasion.SelectedIndex;
            int userStyle = comboBoxStyle.SelectedIndex;
            decimal cost = 0.00m;

            if (userOccasion == -1)
            {
                labelCost.Text = "NO SELECTION FOR OCCASION";
            }

            if (userStyle == -1)
            {
                labelCost.Text = "NO SELECTION FOR STYLE";
            }

            findOccasionOfCard(userOccasion, userStyle);

            //Calculate the cost
            if(checkBoxEnvelope.Checked)
            {
                cost += 0.25m;
            }
            if (checkBoxStamp.Checked)
            {
                cost += 0.50m;
            }
            if (checkBoxMessage.Checked)
            {
                cost += 0.30m;
                richTextBoxMessage.ReadOnly = false;
            }
            else
            {
                richTextBoxMessage.ReadOnly = true;
            }
            if (userStyle == 0)
            {
                cost += 1.00m;
            }
            if (userStyle == 1)
            {
                cost += 1.50m;
            }
            labelCost.Text = "Cost: $" + cost;
        }
        //Gets the selected occasion then sends to use style
        private void findOccasionOfCard(int userOccasion, int userStyle)
        {
            if(userOccasion == 0)
            {
            //    richTextBoxMessage.Text = "userOccasion for thank you cards";
                getThankYouCard();
            }
            else if (userOccasion == 1)
            {
            //    richTextBoxMessage.Text = "userOccasion for birthday";
                getBirthdayCard();
            }
            else if (userOccasion == 2)
            {
            //    richTextBoxMessage.Text = "userOccasion for valentine cards";
                getValentinesCard();
            }
            else
            {
            //    richTextBoxMessage.Text = "Something went wrong";
            }
        }
        //Display image for thank you card selection
        private void getThankYouCard()
        {
            int userStyle = comboBoxStyle.SelectedIndex;
            if (userStyle == 0)
            {
                pictureBoxPreview.Image = Image.FromFile(images[0]);
            }
            else if (userStyle == 1)
            {
                pictureBoxPreview.Image = Image.FromFile(images[1]);
            }
        }
        //Display image for birthday card selection
        private void getBirthdayCard()
        {
            int userStyle = comboBoxStyle.SelectedIndex;
            if (userStyle == 0)
            {
                pictureBoxPreview.Image = Image.FromFile(images[2]);
            }
            else if (userStyle == 1)
            {
                pictureBoxPreview.Image = Image.FromFile(images[3]);
            }
        }
        //Display image for valentine card selection
        private void getValentinesCard()
        {
            int userStyle = comboBoxStyle.SelectedIndex;
            if (userStyle == 0)
            {
                pictureBoxPreview.Image = Image.FromFile(images[4]);
            }
            else if (userStyle == 1)
            {
                pictureBoxPreview.Image = Image.FromFile(images[5]);
            }
        }
        //Display custom message on preview
        private void richTextBoxMessage_TextChanged(object sender, EventArgs e)
        {
            labelCustomMessage.Text = richTextBoxMessage.Text;
        }
    }
}