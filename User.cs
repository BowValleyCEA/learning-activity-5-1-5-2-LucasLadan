using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_5
{
    internal class User
    {
        string _name;
        int _id;
        List<Videos> _currentlyRented;
        List<Videos> _previouslyRented;
        List<DateTime> _timeSinceRented;

        public User (string name, int id)
        {
            _name = name;
            _id = id;
            _currentlyRented = new List<Videos>();
            _previouslyRented = new List<Videos>();
            _timeSinceRented = new List<DateTime>();
        }

        public string getName()
        {
            return _name;
        }
        public int getId()
        {
            return _id;
        }
        public void printUserInfo()//Prints everything about the intro
        {
            Console.WriteLine("\n"+_name+"\nID: "+_id);

            Console.WriteLine("\nCurrently renting: ");
            if (_currentlyRented.Count > 0)
            {
                for (int i = 0; i < _currentlyRented.Count; i++)
                {
                    Console.Write(_currentlyRented[i].getName() + "\nTime rented: " + (DateTime.Now.Subtract(_timeSinceRented[i]) +"\n\n"));
                }
            }
            else
            {
                Console.Write("nothing");
            }

            Console.WriteLine("\nPrevious rents: ");
            if (_previouslyRented.Count > 0)
            {
                for (int i = 0; i < _previouslyRented.Count; i++)
                {
                    Console.Write(_previouslyRented[i].getName() + ", ");
                }
            }
            else
            {
                Console.Write("nothing");
            }
        }

        public int getCurrentRentsCount()
        {
            return _currentlyRented.Count;
        }

        public void removeCurrentRent(int index)
        {
            addPreviousVideo(_currentlyRented[index]);
            _currentlyRented.RemoveAt(index);
            _timeSinceRented.RemoveAt(index);
        }
        public bool CurrentRentCheck()
        {
            bool rentingAnything = false;
            if (_currentlyRented.Count > 0)
            {
                rentingAnything= true;
                Console.WriteLine("\nCurrent rents: ");
                for (int i = 0; i < _currentlyRented.Count; i++)
                {
                    Console.WriteLine((i+1)+": "+ _currentlyRented[i].getName());
                }
            }
            else
            {
                Console.WriteLine("This user is currently not renting anything");
            }
            return rentingAnything;
        }

        public void addCurrentVideo (Videos video)
        {
            _currentlyRented.Add(video);
            _timeSinceRented.Add(DateTime.Now);
        }

        public void addPreviousVideo(Videos video)
        {
            _previouslyRented.Add(video);
        }

    }
}
