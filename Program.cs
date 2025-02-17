using System;

class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Başarıyla {amount} TL yatırıldı. Güncel bakiye: {balance} TL");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Yetersiz bakiye! Çekim işlemi başarısız.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Başarıyla {amount} TL çekildi. Güncel bakiye: {balance} TL");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Güncel bakiyeniz: {balance} TL");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Başlangıç bakiyenizi girin: ");
        decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

        BankAccount account = new BankAccount(initialBalance);

        while (true)
        {
            Console.WriteLine("\n1. Bakiye Görüntüle\n2. Para Yatır\n3. Para Çek\n4. Çıkış");
            Console.Write("Seçiminizi yapın: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    account.ShowBalance();
                    break;
                case "2":
                    Console.Write("Yatırmak istediğiniz miktarı girin: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                case "3":
                    Console.Write("Çekmek istediğiniz miktarı girin: ");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;
                case "4":
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                    break;
            }
        }
    }
}
