using System;

namespace exeptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PhotoException example!");
            Console.WriteLine("");
            var newPhoto = new AddPhoto();
            try
            {
                newPhoto.Add();
            }
            catch (PhotoException photo)
            {
                Console.WriteLine("PhotoException: " + photo.Message);
            }
        }
    }
}
