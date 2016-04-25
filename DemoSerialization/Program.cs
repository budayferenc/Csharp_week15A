using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DemoSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person buday = new Person("Feri", DateTime.Now);
            Console.WriteLine(balazs.ToString());
            Serialize(buday);
            Console.WriteLine("Serialization done");

            Console.WriteLine("Reading deserialized data from disk.. ");
            Person pebaDeserialized = Deserialize();
            Console.WriteLine(pebaDeserialized.ToString()); 
        }

        static void Serialize(Person sp)
        {
            // Create file to save the data to 
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);
            
            // Create a BinaryFormatter object to perform the serialization 
            BinaryFormatter bf = new BinaryFormatter();

            // Use the BinaryFormatter object to serialize the data to the file 
            bf.Serialize(fs, sp);

            // Close the file 
            fs.Close();
        }

        static Person Deserialize()
        {
            Person dsp = new Person();

            // Open file to read the data from 
            FileStream fs = new FileStream("Person.Dat", FileMode.Open);

            // Create a BinaryFormatter object to perform the deserialization 
            BinaryFormatter bf = new BinaryFormatter();

            // Use the BinaryFormatter object to deserialize the data from the file 
            dsp = (Person)bf.Deserialize(fs);

            // Close the file 
            fs.Close();

            return dsp;
        }

    }
}
