using System;

namespace extendedExample
{
    public static class Story
    {
        public static void StoryText(this string story)
        {
            Console.WriteLine(story);
        }
        public static void NewStory(this SecondStory secondStory, string newStory)
        {
            secondStory.Add("This is something new ", newStory);
        }
    }
}
