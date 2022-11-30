using System;


namespace CSharpStar.CSharpAdvancedTopics.Delegates
{
    internal class PhotoFilters
    {
        public void ApplyBrightness(Photo p)
        {
            Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Photo p)
        {
            Console.WriteLine("Apply Contrast");
        }

        public void Resize(Photo p)
        {
            Console.WriteLine("Resize Photo");
        }
    }
}
