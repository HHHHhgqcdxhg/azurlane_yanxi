using System;
using System.Threading;
using OpenCvSharp;
namespace azurlane_yanxi
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            gameController g = new gameController();
//            g.check();
            g.testImg(@"J:\ldmnqshare\azurlaneyanxitemp.png");
//            var img = new Mat("J:\\test3.png", ImreadModes.Grayscale);
//            ImageHanddle.get1Rank(img);
//            var imageHanddle = new ImageHanddle();
//            
//            int res = imageHanddle.get1Rank(img);
//            Console.WriteLine(res);
        }
    }
}