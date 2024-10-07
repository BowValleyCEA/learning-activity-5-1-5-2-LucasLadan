namespace game1401_la_5
{
    internal class Videos
    {
        string _name;
        int _id;
        string _genre;
        float _length;
        public Videos (string name, int id, string genre, float length)
        {
            _name = name;
            _id = id;
            _genre = genre;
            _length = length;
        }

        public void printVideo()
        {
            Console.WriteLine(_name+"\nGenre: "+_genre+"\nLength: "+_length+"\nID: "+_id);
        }

        public string getName()
        {
            return _name;
        }
    }
}
