using Spaghetti1;

public class Drink
{
    int drink, drinkSize, milkSize, shugarSize;
    public Drink(int a, int b, int d, int f) 
    { this.drink = a; this.drinkSize = b; this.milkSize = d;this.shugarSize = f; }
    public string Create()
    {
        switch (drink)
        {
            case 1:
                return Water();
            case 2:
                return Tea();
            case 3:
                return  Coffe();
            case 4:
                return Juice();
            default:
                return "Wystapil blad , sprobuj ponownie";
        }
    }
    public string Water()
    {
        return $"Woda; {DrinkSize()} ml; {MilkSize()}; {Shugar()}";
    }
   
    public string Tea()
    {
        return $"Herbata; {DrinkSize()} ml; {MilkSize()}; {Shugar()}";
    }
    public string Coffe()
    {
        return $"Kawa; {DrinkSize()} ml; {MilkSize()}; {Shugar()}";
    }
    public string Juice()
    {
        return $"Porcja soku; {DrinkSize()} ml; {MilkSize()}; {Shugar()}";
    }
    private string Shugar()
    {
        string shugar = "z cukrem";
            switch (shugarSize)
            {
                case 0:
                    shugar = "bez cukru.";
                    break;
                case 1:
                    shugar += " 1 kostka.";
                    break;
                case 2:
                    shugar += " 2 kostki.";
                    break;
                case 3:
                    shugar += " 3 kostki.";
                    break;
                case 4:
                    shugar += " 4 kostki.";
                    break;

                default:
                    return shugar = "Blędna ilosc cukru";

            }
            return shugar;
        
    }
    private string DrinkSize()
    { 
        string size = "";
        int ml = 0;
        switch (drinkSize)
        {
            case 1:
                ml += 50;
                size = "mala";
                break;
            case 2:
                ml += 100;
                size = "mala";
                break;
            case 3:
                ml += 150;
                size = "średnia";
                break;
            case 4:
                ml += 200;
                size = "duża";
                break;
            default: break;
        }

        return $"{size} {ml.ToString()}";
    }
    private string MilkSize()
    {
        string milk = "z mlekiem";
            int milkMl = 0;
            switch (milkSize)
            {
                case 1:
                    milkMl += 50;
                    break;
                case 2:
                    milkMl += 100;
                    break;
                case 3:
                    milkMl += 150;
                    break;
                case 4:
                    milkMl += 200;
                    break;
                default: 
                return milk="bez mleka";
            }
            return milk += $" {milkMl} ml";
        
    }
}