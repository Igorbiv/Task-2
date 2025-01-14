public class MyString
{
    private string _value;

   
    public MyString()
    {
        _value = "";
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

    
    public void Reverse()
    {
        _value = new string(
            _value.ToCharArray()
            .Reverse()
            .ToArray()
        );
    }

   
    public static implicit operator string(MyString myString)
    {
        return myString._value;
    }

    
    public static MyString operator =(MyString left, string right)
    {
        left._value = right;
        return left;
    }
}
