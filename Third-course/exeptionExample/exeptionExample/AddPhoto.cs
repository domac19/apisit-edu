using System;
namespace exeptionExample
{
    public class AddPhoto
    {
        string newPhoto = "logo.jpg";
        public void Add()
        {
            if (String.IsNullOrEmpty(newPhoto))
                Console.WriteLine("There is no photo");
            else
                throw (new PhotoException($"New photo upload {newPhoto}"));
        }
    }
}
