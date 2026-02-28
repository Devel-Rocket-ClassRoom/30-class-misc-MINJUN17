using System;
using System.Collections.Generic;
using System.Text;

class QueryBuilder
{
    private string _message; 
    public QueryBuilder Select(string columns)
    {
        _message += $"SELECT {columns} ";
        return this;
    }
    public QueryBuilder From(string columns)
    {
        _message += $"From {columns} ";
        return this;
    }
    public QueryBuilder Where(string columns)
    {
        _message += $"Where {columns} ";
        return this;
    }
    public QueryBuilder OrderBy(string columns)
    {
        _message += $"Order By {columns} ";
        return this;
    }
    public string Build()
    {
        return _message;
    }
}