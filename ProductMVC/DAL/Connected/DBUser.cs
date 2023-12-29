namespace DAL;

using BOL;

using MySql.Data.MySqlClient;

public static class DBUser{
    public static string conString="server=192.168.10.150;port=3306;user=dac45;password=welcome;database=dac45";

    public static void register(User ui)
    {
        MySqlConnection conn=new MySqlConnection();

        conn.ConnectionString=conString;

        string query="insert into user values(@uname,@password,@emailId)";

        MySqlCommand cmd=new MySqlCommand(query,conn);

      
        

        cmd.Parameters.AddWithValue("@uname",ui.uname);

        cmd.Parameters.AddWithValue("@password",ui.password);

        cmd.Parameters.AddWithValue("@emailId",ui.emailId);

    try{
        conn.Open();
        cmd.ExecuteNonQuery();
    }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }finally{
        conn.Close();
    }
}
    }
