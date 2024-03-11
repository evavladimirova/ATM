namespace ATM
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        double Bankaccount = 1000;
        string PIN = "1234";
        double WithdrawalLimit = 400;
        private void button1_Click(object sender, EventArgs e)
        {
            amountErrorProvider.SetError(amountTextBox, "");
            pinErrorProvider.SetError(pinTextBox, "");

            double amount;

            if (!double.TryParse(amountTextBox.Text, out amount))
            {
                amountErrorProvider.SetError(amountTextBox, "Invalid amount :(");
            }
            else if (amount > WithdrawalLimit)
            {
                amountErrorProvider.SetError(amountTextBox, $"Withdrawal amount exceeds the limit of {WithdrawalLimit} :(");
            }
            else
            {
                amountErrorProvider.SetError(amountTextBox, string.Empty);
            }

            string enteredPin = pinTextBox.Text;
            if (string.IsNullOrEmpty(enteredPin))
            {
                pinErrorProvider.SetError(pinTextBox, "PIN cannot be empty");
            }
            else if (enteredPin.Length != 4 || !int.TryParse(enteredPin, out _))
            {
                pinErrorProvider.SetError(pinTextBox, "PIN must be a 4-digit number");
            }
            else if (enteredPin == PIN)
            {
                pinErrorProvider.SetError(pinTextBox, string.Empty);
            }
            else
            {
                pinErrorProvider.SetError(pinTextBox, "Wrong PIN");
            }

            if (amountErrorProvider.GetError(amountTextBox).Equals(string.Empty) &&
                pinErrorProvider.GetError(pinTextBox).Equals(string.Empty))
            {
                if (amount <= Bankaccount)
                {
                    Bankaccount -= amount;
                    MessageBox.Show($"Transaction successful! You withdrew {amount}. Remaining balance: {Bankaccount}");
                }
                else
                {
                    MessageBox.Show("Insufficient funds :(");
                }
            }
            else
            {
                MessageBox.Show(amountErrorProvider.GetError(amountTextBox) + Environment.NewLine + pinErrorProvider.GetError(pinTextBox));
            }
        }

            public void amountTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            public void pinTextBox_TextChanged(object sender, EventArgs e)
            {

            }
        }
}


