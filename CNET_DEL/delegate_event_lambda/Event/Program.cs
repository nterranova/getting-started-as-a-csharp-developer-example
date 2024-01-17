
class Program
{

    public delegate void MyEventHandler(int cash);

    class Piggybank
    {
        private int BankVault;

        public event MyEventHandler balancechange;

        public int balance
        {
            set
            {
                this.BankVault = value;
                balancechange(value);
            }
            get
            {
                return this.BankVault;
            }
        }

    }

    static void display_bank_value(int amount)
    {
        Console.WriteLine("The amount in Piggy Bank is {0}", amount);
    }

    static void retirement(int amount)
    {
        if (amount > 500){
            Console.WriteLine("The amount in Piggy Bank is {0}, you can safly retire now", amount);
        }
    }

    static void Main()
    {
        Piggybank chase = new Piggybank();

        chase.balancechange += display_bank_value;
        chase.balancechange += retirement;

        while (true)
        {
            Console.WriteLine("enter amount");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int intValue))
            {
                chase.balance += intValue;
            }

            if (input == "exit")
            {
                return;
            }
        }

            
    }

}