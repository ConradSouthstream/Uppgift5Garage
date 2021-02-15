using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Uppgift_5_Garage
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
        
    {
        private T[] vehicles;
        

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }
        public T this[int index] => vehicles[index];
        

        public bool Add(T vehicle)
        {
            //TODO gör en reg-check, om reg finns, return false;
            
            for (int i = 0; i < vehicles.Length; i++)
            {
                                  
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
                else if (vehicles[i].Regnmbr == vehicle.Regnmbr)
                {
                    return false;
                }
            }

            return false; // Inga tomma platser
        }

        public bool Remove(string regNum)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].Regnmbr == regNum) //kolla om den befintliga fordonets regnr matchar med regNum
                {
                    // gör om den befintliga fordonet till null
                    vehicles[i] = null;
                    return true;
                }
            }

            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
           foreach(var vehicle in vehicles)
            {
                yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
}
