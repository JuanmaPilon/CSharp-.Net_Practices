
var sale = new Sale(15);
var message = sale.GetInfo();
var sumado = sale.Sumar(30);

Console.WriteLine(sumado);



class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
    }

    public string GetInfo()
    {
        return "El total es " + Total;
    }

    public decimal GetTotal()
    {
        return Total;
    }

    public decimal Sumar(decimal a)
    {
        return Total + a;
    }
}


