using System;

public class MyString
{
    private string _value;

    
    public MyString()
    {
        _value = string.Empty;
    }

    
    public MyString(string value)
    {
        _value = value;
    }

    
    public MyString(MyString other)
    {
        _value = other._value;
    }

    
    public string Value
    {
        get { return _value; }
        set { _value = value; }
    }

    
    public string Reverse()
    {
        char[] charArray = _value.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

  
    public override string ToString()
    {
        return _value;
    }
}


public class Program
{
    public static void Main()
    {
        MyString myString1 = new MyString("Hello, World!");
        Console.WriteLine("Оригинал: " + myString1);

        string reversedString = myString1.Reverse();
        Console.WriteLine("Реверс: " + reversedString);

        MyString myString2 = new MyString(myString1);
        Console.WriteLine("Копия: " + myString2);
    }
}