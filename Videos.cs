namespace game1401_la_5
{
    internal class Videos
    {
        string _name;
        int _id;
        string _description;
        double _length;
        public Videos (string name, int id, string description, double length)
        {
            _name = name;
            _id = id;
            _description = description;
            _length = length;
        }

        public void printVideo()
        {
            Console.Write(_name+"\nGenre: "+_description+"\nLength in hours: "+_length+"\nID: "+_id);
        }

        public string getName()
        {
            return _name;
        }
    }
}
