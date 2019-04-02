using System;
using System.Collections.Generic;
using NodaTime;

namespace Route.Domain
{
    public class Race
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Racer> Members { get; set; }

        public Instant StartDate { get; set; }

        public IEnumerable<Heat> Heats { get; set; }
    }
    
    public class Heat
    {
        public Racer Racer { get; set; }
        public Car Car { get; set; }
        public Instant Start { get; set; }
        public Instant Finish { get; set; }
    }
    

    public class Racer
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }
    }

    public class Car
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}