
using System.Linq.Expressions;

var sale = new Sale();
var game = new Game();

Some(sale);
Some(game);

void Some(ISave save)
{
    save.Save();
}

interface ISale
{
    decimal Total { get; set; 
}


interface ISave
    {
        public void Save();
    }

    public class  Sale : ISale, ISave
    { 
      public decimal Total { get; set; }

    public void Save()
        {
            Console.WriteLine("Guardando");
        }
    }

    public class Game : ISave
    {
        public void Save()
        {
            Console.WriteLine("Guardando");
        }
    }
}



var sale = new SaleWithTax(15, 1.15m);
var message = sale.GetInfo();
var sumado = sale.Sumar(30);

Console.WriteLine(sumado);


class SaleWithTax : Sale {

    public decimal Tax { get; set; }

    public SaleWithTax(decimal total, decimal tax) : base(total){
        Tax = tax;
    
    }
    public override string GetInfo()
    {
        return "El total es " + Total + "El impuesto es: " + Tax;
    }

    public string GetInfo(string message)
    {
        return message;
    }
}

class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
    }

    public virtual string GetInfo()
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


var numbers = new MyList<int>(10);
var names = new MyList<string>(10);
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

public class MyList<T>
{

    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = _limit;
    }

    public void Add(T item)
    {
        if(_list.Count < _limit)
        _list.Add(item);
    }

    public string GetContent()
    {
        
    }
}