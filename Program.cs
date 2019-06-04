using System;
using System.Threading;
using OpenCvSharp;
namespace azurlane_yanxi
{
    internal class Program
    {

        public static void Main(string[] args)
        {
//            gameController g = new gameController();
//            g.get1Rank();
            var img = new Mat("J:\\test.png", ImreadModes.Grayscale);
            ImageHanddle.get1Rank(img);
        }
    }
}