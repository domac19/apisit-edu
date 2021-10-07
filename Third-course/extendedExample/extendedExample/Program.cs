using System;

namespace extendedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentStory = "First story goes by!";
            currentStory.StoryText();

            SecondStory secondStory = new SecondStory();
            secondStory.NewStory("And new story comes here!");
        }
    }
}
