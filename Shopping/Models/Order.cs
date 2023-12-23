namespace Shop;
public class Order: Product{
    int Oid{get;set;}
    
    public Order(int id,string s,int q,double d,int oid):base(id,s,q,d){
        this.Oid=oid;
    }
    
}