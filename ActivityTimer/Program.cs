using Microsoft.VisualBasic;

namespace ActivityTimer
{
    class Program
    {
        static int Minutes;

        static void Main(string[] args)
        {
            int counter = 0;
            PromptTimeLength();
            while (counter < 30)
            {
                Count();
                DisplayMessage();
                counter++;
            }
        }

        static void PromptTimeLength()
        {
            string input = Interaction.InputBox("Enter a time length between prompts in minutes.\nNo value or invalid values will select the default of 30 minutes.", "Time Length");
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
            string message = String.Format("{0} minutes have passed.\nGet up and move around!", Minutes);
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
