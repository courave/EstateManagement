using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ComboItem
{
    private string _key;

    public string Key
    {
        get { return _key; }
        set { _key = value; }
    }

    private string _value;

    public string Value
    {
        get { return this._value; }
        set { this._value = value; }
    }

    public ComboItem(string key, string value)
    {
        _key = key;
        _value = value;
    }

    public override string ToString()
    {
        return this._value;
    }
}
