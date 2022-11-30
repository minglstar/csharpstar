
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using CSharpStar.CSharpAdvancedTopics.Delegates;

var processor = new PhotoProcessor();
var filters = new PhotoFilters();
/*PhotoProcessor.PhotoFilterHandler*/Action<Photo> filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;

processor.Process("photo.png", filterHandler);



