using System;
using System.Threading;
using OpenCvSharp;

namespace azurlane_yanxi
{
    public class gameController
    {
        public _Config c;
        public ADBController a;
        

        public gameController()
        {
            c = Config.init();
            a = ADBController.init();
        }
        
        public void check()
        {
            a.startGame();
            Thread.Sleep(c.startIntervalSeconds * 1000);
            a.tap(1713,379);
            Thread.Sleep(c.tapIntervalMilliSeconds * 2);
            a.tap(1623,537);
            Thread.Sleep(c.tapIntervalMilliSeconds);
            a.tap(1753,1013);
            Thread.Sleep(c.tapIntervalMilliSeconds);
            a.stopGame();

        }

        public int get1Rank()
        {
            var img = a.getScreen();
            return ImageHanddle.get1Rank(img);
        }
    }
}