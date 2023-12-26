using DML;
Command c=new Command();
c.Insert();
Console.WriteLine("Added Sucessfully!!!! check Db");
c.Update();
Console.WriteLine("Data Updated Sucessfully!!!! check Db");
c.Delete();
Console.WriteLine("Data Deleted Sucessfully!!!! check Db");
c.Select();

c.Aggregate();


