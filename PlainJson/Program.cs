﻿using System;
using JsonServer;

namespace PlainJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Start();
        }
    }
}