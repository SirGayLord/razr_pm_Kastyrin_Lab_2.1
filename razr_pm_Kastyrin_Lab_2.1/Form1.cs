namespace razr_pm_Kastyrin_Lab_2._1
{
    public partial class Form1 : Form
    {
        private List<Button> buttons;
        public Form1()
        {
            InitializeComponent();

            InitializeButtons();
        }

        private void InitializeButtons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5 };

            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int index = buttons.IndexOf(clickedButton);

            clickedButton.Visible = false;

            if (index > 0)
            {
                if (!buttons[index - 1].Visible)
                {
                    buttons[index - 1].Visible = true;
                }
                else
                {
                    buttons[index - 1].Visible = false;
                }
            }
            if (index < buttons.Count - 1)
            {
                if (!buttons[index + 1].Visible)
                {
                    buttons[index + 1].Visible = true;
                }
                else
                {
                    buttons[index + 1].Visible = false;
                }
            }

            if (AreAllButtonsHidden())
            {
                MessageBox.Show("Игра пройдена");
            }
        }

        private bool AreAllButtonsHidden()
        {
            foreach (Button button in buttons)
            {
                if (button.Visible)
                {
                    return false;
                }
            }
            return true;
        }
    }
}