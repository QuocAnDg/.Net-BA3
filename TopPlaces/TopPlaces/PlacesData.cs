using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TopPlaces
{
    public class PlacesData
    {
        private IList<Place> placesList;

        public PlacesData()
        {

            string pathProject = Environment.CurrentDirectory;
            Place p1 = new Place(pathProject + "/photos/bruxelles.jpg", "Bruxelles");
            Place p2 = new Place(pathProject + "/photos/paris.jpg", "Paris");
            Place p3 = new Place(pathProject + "/photos/moscou.jpg", "Moscou");
            Place p4 = new Place(pathProject + "/photos/amsterdam.jpg", "Amsterdam");
            Place p5 = new Place(pathProject + "/photos/newyork.jpg", "New York");

            placesList = new List<Place>
            {
                p1,
                p2,
                p3,
                p4,
                p5
            };

        }

        public IList<Place> PlacesList
        {
            get { return placesList; }
        }
    }


    public class Place
    {
        private string _description;
        private string _pathImageFile;
        private int _nbVotes;
        private Uri _uri;
        private BitmapFrame _image;

        public Place(string path, string description)
        {
            _description = description;
            _pathImageFile = path;
            _nbVotes = 0;
            try
            {
                _uri = new Uri(_pathImageFile);
                _image = BitmapFrame.Create(_uri);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Path
        {
            get { return _pathImageFile; }
            set { _pathImageFile = value; }
        }

        public int NbVotes
        {
            get { return _nbVotes; }
        }

        public void Vote()
        {
            _nbVotes++;
        }

        public BitmapFrame Image { get { return _image; } }
    }

}
