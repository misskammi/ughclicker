namespace IdleClicker
{
    public partial class Form1 : Form
    {
        private int cash;
        public int Cash
        {
            set
            {
                cash = value;
                label1.Text = "Moni: $" + value.ToString();
            }
            get
            {
                return cash;
            }
        }
        int buttonLevel;
        int A1Ammount;
        int A2Ammount;
        int A3Ammount;
        int A1Interval;
        int A2Interval;
        int A3Interval;
        public Form1()
        {
            InitializeComponent();
            Cash = 0;
            buttonLevel = 1;
            A1Ammount = 1;
            A2Ammount = 10;
            A3Ammount = 100;
            A1Interval = 0;
            A2Interval = 0;
            A3Interval = 0;
            A1AmmountTextBox.Text = A1Ammount.ToString();
            A1IntervalTextBox.Text = A1Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash += (int)Math.Pow(10, buttonLevel-1);

        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if(Cash >= upgradeCost)
            {
                buttonLevel++;
                buttonLevelTextBox.Text = buttonLevel.ToString();
                Cash -= upgradeCost;

                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                upgradeButton.Text = "Upgrade\n" + nextUpgradeCost;
            }
            
        }

        private void A1UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 5;
            if (Cash >= upgradeCost) {
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1Timer.Interval = (int)Math.Ceiling((double)((60 / A1Interval) *100 + float.Epsilon));
                if (!A1Timer.Enabled)
                    A1Timer.Enabled = true;
                Cash -= upgradeCost;

            }
            
        }

        private void A1Tick(object sender, EventArgs e)
        {
            Cash += A1Ammount;

        }

        private void A1UpgradeAmmount_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Ammount * 10;
            if (Cash >= upgradeCost)
            {
                A1Ammount += 10;
                A1AmmountTextBox.Text = A1Ammount.ToString();
                Cash -= upgradeCost;   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void A2UpgradeAmmount_Click(object sender, EventArgs e)
        {
            int upgradeCost = A2Ammount * 10;
            if (Cash >= upgradeCost)
            {
                A2Ammount += 10;
                A2AmmountTextBox.Text = A2Ammount.ToString();
                Cash -= upgradeCost;
            }
        }

        private void A2UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A2Interval;
            if (Cash >= upgradeCost)
            {
                A2Interval++;
                A2IntervalTextBox.Text = A2Interval.ToString();
                A2Timer.Interval = (int)Math.Ceiling((double)((60 / A2Interval) * 100 + float.Epsilon));
                if (!A2Timer.Enabled)
                    A2Timer.Enabled = true;
                Cash -= upgradeCost;

            }
        }

        private void A1IntervalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void A2AmmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void A1AmmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void A3UpgradeAmmount_Click(object sender, EventArgs e)
        {
            int upgradeCost = A3Ammount * 10;
            if (Cash >= upgradeCost)
            {
                A3Ammount += 10;
                A3AmmountTextBox.Text = A2Ammount.ToString();
                Cash -= upgradeCost;
            }
        }

        private void A3UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A3Interval;
            if (Cash >= upgradeCost)
            {
                A3Interval++;
                A3IntervalTextBox.Text = A3Interval.ToString();
                A3Timer.Interval = (int)Math.Ceiling((double)((60 / A3Interval) * 100 + float.Epsilon));
                if (!A3Timer.Enabled)
                    A3Timer.Enabled = true;
                Cash -= upgradeCost;

            }
        }

        private void A2Timer_Tick(object sender, EventArgs e)
        {

        }
    }
}