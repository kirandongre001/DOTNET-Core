namespace Products;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
[Serializable]
public class Product{
    public int Id{get;set;}
    [Required]
    public string Title{get;set;}
    public string Description{get;set;}
    public double UnitPrice{get;set;}

    public Product(){
        this.Id=1;
        this.Title="Gerbera";
        this.Description="Wedding Flower";
        this.UnitPrice=20;
    }

    public Product(int i,string t,string d,int p){
        this.Id=i;
        this.Title=t;
        this.Description=d;
        this.UnitPrice=p;
    }
}