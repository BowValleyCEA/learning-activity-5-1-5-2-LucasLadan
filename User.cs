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

        public User (string name, int id)
        {
            _name = name;
            _id = id;
            _currentlyRented = new List<Videos>();
            _previouslyRented = new List<Videos>();
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
            Console.WriteLine(_name+"\nID: "+_id);

            Console.WriteLine("Currently renting: ");
            if (_currentlyRented.Count > 0)
            {
                for (int i = 0; i < _currentlyRented.Count; i++)
                {
                    Console.Write(_currentlyRented[i].getName() + " ");
                }
            }
            else
            {
                Console.Write("nothing");
            }

            Console.WriteLine("Previous rents: ");
            if (_previouslyRented.Count > 0)
            {
                for (int i = 0; i < _previouslyRented.Count; i++)
                {
                    Console.Write(_previouslyRented[i].getName() + " ");
                }
            }
            else
            {
                Console.Write("nothing");
            }
        }

        public void addCurrentVideo (Videos video)
        {
            _currentlyRented.Add(video);
        }

        public void addPreviousVideo(Videos video)
        {
            _previouslyRented.Add(video);
        }
    }
}
