using System;
using Newtonsoft.Json;

namespace SerializationJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initilizing New Trainee Object
            Trainee traineeObj = new Trainee();
            traineeObj.Name = "Jared Mackay";
            traineeObj.Age = 25;
            traineeObj.DateOfBirth = new DateTime(1994, 09, 12);

            //SERIALIZATION
            //Serialize the Trainee Object as a string
            string objectOutput = JsonConvert.SerializeObject(traineeObj);
            Console.WriteLine(objectOutput);

            //DESERIALIZATION
            //Deserialize the serialized "objectOutput" string
            Trainee deserializedTrainee = JsonConvert.DeserializeObject<Trainee>(objectOutput);
            Console.WriteLine(deserializedTrainee.Name);
            Console.WriteLine(deserializedTrainee.Age);
            Console.WriteLine(deserializedTrainee.DateOfBirth);
        }
    }
}
