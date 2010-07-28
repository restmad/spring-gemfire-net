﻿using System;
using GemStone.GemFire.Cache;

namespace Spring.Data.Gemfire.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DistributedSystem system = DistributedSystem.Connect("dist", GemStone.GemFire.Cache.Properties.Create());
            Cache cache = CacheFactory.Create("cache", system);
            cache.Close();
            Console.WriteLine("calling disconnect");
            DistributedSystem.Disconnect();
            Console.WriteLine("Done. Hit enter to exit");
            Console.ReadLine();
        }
    }
}
