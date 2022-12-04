// Delegates
/*using CSharpStar.CSharpAdvancedTopics.Delegates;

var processor = new PhotoProcessor();
var filters = new PhotoFilters();
*//*PhotoProcessor.PhotoFilterHandler*//*Action<Photo> filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;

processor.Process("photo.png", filterHandler);*/

// LambdaExpressions
/*using LambdaExpressions;

var books = new BookRepository().GetBooks();

var cheapBooks = books.FindAll(b => b.Price < 10);

foreach (var book in cheapBooks)
{
    Console.WriteLine(book.Title);
}*/

// Events
/*using CSharpStar.AdvancedTopics.Events;

var video = new Video() { Title = "Video 1"};
var videoEncoder = new VideoEncoder(); // publisher
var mailService = new MailService(); // subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

videoEncoder.Encode(video);*/


