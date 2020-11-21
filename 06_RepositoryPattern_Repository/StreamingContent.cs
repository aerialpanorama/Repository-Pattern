using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror = 1,
        RomCom = 2,
        SciFi = 3,
        Documentary = 4,
        Bromance =5,
        Drama = 6,
        Action = 7
    }
    //POCO
    public class StreamingContent
    {//parameters
        public string Title { get; set; }
        public string Description { get; set; }

        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set }
        public GenreType TypeofGenre { get; set; }

        //constructors
        public StreamingContent() { }
        public StreamingContent(String title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {//property / contructor method?
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeofGenre = genre;


        }


    }
}
