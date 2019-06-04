using System;
using OpenCvSharp;

namespace azurlane_yanxi
{
    public class ImageHanddle
    {
        private static Rect _get1RankRect=new Rect(252,476,222,95);
        
        public static int get1Rank(Mat img)
        {
//            var rankPart = img[_get1RankRect];
            var rankPart = img;
            
            var thresholdRankPart = new Mat();
            Cv2.Threshold(rankPart, thresholdRankPart,155 ,255,OpenCvSharp.ThresholdTypes.BinaryInv);
//            thresholdRankPart.SaveImage("J:\\testimg2.png");
             
            

            
            Cv2.FindContours(thresholdRankPart,out var contours, out _ , RetrievalModes.List,ContourApproximationModes.ApproxNone);
           
            for (int i = 0; i < contours.Length - 1; ++i)
            {
                Console.WriteLine("========================================");
                var left = contours[i][0].X;
                var right = left;
                foreach (var p in contours[i])
                {
                    left = Math.Min(p.X, left);
                    right = Math.Max(p.X, right);
                }
                Console.WriteLine(left);
                Console.WriteLine(right);
            }
            
//            
//            var indexer = thresholdRankPart.GetGenericIndexer<byte>();
//            
//            for (int x = 0; x < thresholdRankPart.Width; ++x)
//            {
//                for (int y = 0; y < thresholdRankPart.Height; ++y)
//                {
//                    var c = indexer[x, y];
////                        Console.WriteLine($"x: {x}, y: {y}, {c[0]}, {c[1]}, {c[2]}");
//                        Console.WriteLine($"x: {x}, y: {y}, {c}");
//                }
//            }
//            using (new Window("mats[0]", mats[0]))
            using (new Window("thresholdRankPart", thresholdRankPart))
            {
                Cv2.WaitKey();
            }
            return 0;
        }
    }
}