using System;

namespace extendedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var banana = "First story goes by!";
            banana.StoryText();

            SecondStory secondStory = new SecondStory();
            secondStory.NewStory("And new story comes here!");
        }
    }
}
