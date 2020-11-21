using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        //create (method name is AddContentToList
        public void AddContentToList(StreamingContent content)
        {//field
            _listOfContent.Add(content);
           
        }

        //Read   //returntype
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }
        //Update method                                //pass string  pass streamingcontent object
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            // Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //update the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeofGenre = newContent.TypeofGenre;
                return true;
            }
            else
            {
                return false;
            }
        }


        //Delete
        public bool RemoveContentFromList(string title)
        {     //                            //call Method
            StreamingContent Content = GetContentByTitle(title);
            
            if(Content == null)
            {
                return false;
            }                                   //Count is a property of a list
            int initialCount = listofContent.Count;
            _listOfContent.Remove(content);

            if(initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        //Helper Method
        public StreamingContent GetContentByTitle(string title)
        {                //streamingcontent object
            foreach (StreamingContent content in _listOfContent)
            {
                if(content.Title == title)
                {
                    return content;
                }

            }
        return null;
        }
    }
}
