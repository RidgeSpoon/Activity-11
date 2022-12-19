namespace Dice_Roll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Random rnd = new Random(); // Random number generation used to ran.
        int numSides = rnd.Next(4, 21); // Assign a number between 4 - 20
        private void button1_Click(object sender, EventArgs e)
        {
            outputRollsBox.Items.Clear(); // Clears the listbox control every time the button is pressed.
            Dice dice1 = new Dice(numSides); // Create first dice object with numSides.
            Dice dice2 = new Dice(numSides); // Create second dice object with numSides.
            int dice1Roll, dice2Roll, numberOfRolls = 0; // dice1Roll and dice2Roll track the current int assigned on a roll. numberOfRolls increases each iteration.
            do
            {
                dice1Roll = dice1.rollDie(); // Roll dice 1.
                dice2Roll = dice2.rollDie(); // Roll dice 2.
                outputRollsBox.Items.Add("Rolled! Dice #1 was " + dice1Roll + " and Dice #2 was " + dice2Roll); // Dice 1 & 2 values.
                ++numberOfRolls; //increment rolls.
            }
            while (dice1Roll != 1 || dice2Roll != 1);
            outputRollsBox.Items.Add("\nTotal Rolls: " + numberOfRolls + " rolls to get snake eyes!"); // Snake Eyes result with total numberofRolls.
        }
    }
}