class Program 
{
    static void Main()
    {
        BankAccount account1 = new BankAccount ("itallo", 100);
        BankAccount account2 = new BankAccount ("karol", 100);

        account1.Deposit(-100);

        account2.Deposit(100);
    }
       
}

class BankAccount
{
    private string name;
    private decimal balance;

    public BankAccount(string name, decimal balance)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("nome invalido.", nameof(name));
        }
        if (balance < 0)
        {
            throw new Exception("saldo nao pode ser menor ");
        }
        this.name = name;
        this.balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0 )
        {
         
            return;
        }

        balance += amount;
    }
}

    


