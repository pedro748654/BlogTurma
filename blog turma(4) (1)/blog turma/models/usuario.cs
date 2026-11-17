using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Collections.Generic;

public class Usuario
{
    public int id { get; set; }= 0;
    public string nome {get;set;} = string.Empty;
    public string email {get;set;}= string.Empty;
    public int SenhaHash { get; set; } = 0;
}