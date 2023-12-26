using Products;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// property initializer syntax
Product p1=new Product{ Id=12, Title="Gerbera", Description="Wedding flower", UnitPrice=12};
Product p2=new Product{ Id=13, Title="Rose", Description="Valentine flower", UnitPrice=34};
Product p3=new Product{ Id=14, Title="Lotus", Description="Worhip flower", UnitPrice=28};
Product p4=new Product{ Id=15, Title="Jasmine", Description="Smelling flower",UnitPrice=30};

List<Product> flowers=new List<Product>();
flowers.Add(p1);
flowers.Add(p2);
flowers.Add(p3);
flowers.Add(p4);

// //serialization
//     IFormatter formatter = new BinaryFormatter();
//     Stream stream = new FileStream(@"E:\ExampleNew.txt",FileMode.Create,FileAccess.Write);

//     formatter.Serialize(stream, flowers);
//     stream.Close();
// //deserialization
//     stream = new FileStream(@"E:\ExampleNew.txt",FileMode.Open,FileAccess.Read);
//     List<Product> objnew = (List<Product>)formatter.Deserialize(stream);

//     Console.WriteLine(objnew);

//     Console.ReadKey();

 try{
            // dynamic data type variable
            var options=new JsonSerializerOptions {IncludeFields=true};//to include all field
            //product object converted to string
            var produtsJson=JsonSerializer.Serialize<List<Product>>(flowers,options);
            string fileName=@"C:\Users\IET\Desktop\MsDotNet\Serialisation\products.json";
            //Serialize all Flowers into json file
            File.WriteAllText(fileName,produtsJson);


           //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);// inbuilt fn
            List<Product> jsonFlowers = JsonSerializer.Deserialize<List<Product>>(jsonString);
            Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Product flower in jsonFlowers)
            {
                Console.WriteLine($"{flower.Title} : {flower.Description}");   
            }   
    }
   catch(Exception exp){
    
    }
    finally{ }