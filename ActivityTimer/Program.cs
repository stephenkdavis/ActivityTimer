using Microsoft.VisualBasic;

namespace ActivityTimer
{
    class Program
    {
        static int Minutes;

        static void Main(string[] args)
        {
            PromptTimeLength();
            while (true)
            {
                Count();
                DisplayMessage();
            }
        }

        static void PromptTimeLength()
        {
            string line1 = "Enter a time length between prompts in minutes.";
            string line2 = "No value or invalid values will select the default of 30 minutes.";
            string input = Interaction.InputBox(String.Format("{0}\n{1}", line1, line2), "Time Length");
            bool success = int.TryParse(input, out int value);
            Minutes = success ? value : 30;
        }

        static void Count()
        {
            int milliseconds = Minutes * 60000;
            Thread.Sleep(milliseconds);
        }

        static void DisplayMessage()
        {
            string title = "Activity Timer";
            string line1 = "minutes have passed.";
            string line2 = "Would you like to continue this timer or exit this program?";
            string message = String.Format("{0} {1}\n{2}", Minutes, line1, line2);
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.No)
                Environment.Exit(0);
        }
    }
}
