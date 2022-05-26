using System;
using System.Collections.Generic;

namespace TransportRegistry{
/// <summary>
/// This is the template for creating object in the rental class
/// </summary>
    public class Rental{
        private readonly List<Transport> _transports;
/// <summary>
/// this is used to initialize the object
/// </summary>
        public Rental(){
            _transports = new List<Transport>();
        }
/// <summary>
/// this returns the current count of the transport list
/// </summary>
/// <value></value>
        public int TransportCount{
            get{ return _transports.Count; }
        }
/// <summary>
/// this is a property that allows the user to acces the object using an index like an array
/// </summary>
/// <value></value>
        public Transport this[int i]{
            get{ return _transports[i]; }
        }
/// <summary>
/// this is function which accepts and adds a transport object into the list
/// </summary>
/// <param name="t"></param>
        public void AddTransport(Transport t){
            _transports.Add(t);
        }
/// <summary>
/// this is function which accepts and removes a transport object from the list
/// </summary>
/// <param name="t"></param>
        public void RemoveTransport(Transport t){
            _transports.Remove(t);
        }
    }
}