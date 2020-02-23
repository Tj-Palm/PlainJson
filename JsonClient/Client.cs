using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using ModelLib;
using Newtonsoft.Json;

namespace JsonClient
{
    class Client
    {

        public void Start()
        {
            TcpClient Client = new TcpClient("localhost", 7);

            using (Client)
            {
                NetworkStream ns = Client.GetStream();
                StreamWriter sw = new StreamWriter(ns);
                StreamReader sr = new StreamReader(ns);
                sw.AutoFlush = true;

                while (true)
                {
                    Car car = new Car();

                    Console.WriteLine("What is the model of the car?");
                    car.Model = Console.ReadLine();
                    Console.WriteLine("What is the color of the car?");
                    car.Color = Console.ReadLine();
                    Console.WriteLine("What is the cars registrations number?");
                    car.RegistrationNumber = Int32.Parse(Console.ReadLine());

                    string serializedcar = JsonConvert.SerializeObject(car);

                    sw.WriteLine(serializedcar);

                    Console.WriteLine(sr.ReadLine());
                    Console.ReadKey();
                }
            }
        }
    }
}
