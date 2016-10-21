using System.Collections.Generic;

namespace Hackathon.Beuth.Server
{
    public class DataRepository
    {
        public IDictionary<int, Student> Students {get;} = new Dictionary<int, Student>();
        public IDictionary<int, Klausur> Klausur {get;} = new Dictionary<int, Klausur>();
        
    }
}