namespace DML;
using MySql.Data.MySqlClient;
public class Command
{
    public void Insert()
    {
        Console.WriteLine("Enter id");
        int id=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter pname");
        string s=Console.ReadLine();
        
        Console.WriteLine("Enter Quantity");
        int qty=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Price");
        int price=int.Parse(Console.ReadLine());

        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac45;password=welcome;database=dac45";
        string query = "insert into cart values(@id,@s,@qty,@price)";
        //string query="insert into cart values(1,'gsahg',10,100);"
        MySqlCommand cmd = new MySqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@id",id);
        cmd.Parameters.AddWithValue("@s",s);
        cmd.Parameters.AddWithValue("@qty",qty);
        cmd.Parameters.AddWithValue("@price",price);
        
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void Update()
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac45;password=welcome;database=dac45";
        string query = "update Cart set pname='parle-G' where pid=3 ";
        MySqlCommand cmd = new MySqlCommand(query, conn);

        try
        {

            conn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {

            conn.Close();
        }
    }

    public void Delete()
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac45;password=welcome;database=dac45";
        string query = "delete from cart where pid=6";
        MySqlCommand cmd = new MySqlCommand(query, conn);

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    public void Select()
    {

        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = "server=192.168.10.150; port=3306;user=dac45;password=welcome;database=dac45";
        string query = "select * from cart";
        MySqlCommand command = new MySqlCommand(query, connection);
        try
        {
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["pid"].ToString());
                string title = reader["pname"].ToString();
                int qty = int.Parse(reader["pqty"].ToString());
                int price = int.Parse(reader["price"].ToString());
                Console.WriteLine(id + "  " + title + "  " + qty + "  " + price);
            }
            reader.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public void Aggregate(){
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString="server=192.168.10.150;port=3306;user=dac45;password=welcome;database=dac45";
        string query="Select max(price) from cart";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        try{
            conn.Open();
            int n=int.Parse(cmd.ExecuteScalar().ToString());
            Console.WriteLine("maximum price is: "+n);
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            conn.Close();
        }
    }
}