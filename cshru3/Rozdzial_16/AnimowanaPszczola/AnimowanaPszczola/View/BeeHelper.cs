using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimowanaPszczola.View
{
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media.Animation;

    static class BeeHelper
    {
        public static AnimatedImage BeeFactory(
                   double width, double height, TimeSpan flapInterval)
        {
            List<string> imageNames = new List<string>();
            imageNames.Add("Bee animation 1.png");
            imageNames.Add("Bee animation 2.png");
            imageNames.Add("Bee animation 3.png");
            imageNames.Add("Bee animation 4.png");

            AnimatedImage bee = new AnimatedImage(imageNames, flapInterval);
            bee.Width = width;
            bee.Height = height;
            return bee;
        }

        public static void SetBeeLocation(AnimatedImage bee, double x, double y)
        {
            Canvas.SetLeft(bee, x);
            Canvas.SetTop(bee, y);
        }

        public static void MakeBeeMove(AnimatedImage bee,
                                       double fromX, double toX, double y)
        {
            Canvas.SetTop(bee, y);
            Storyboard storyboard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, bee);
            Storyboard.SetTargetProperty(animation, "(Canvas.Left)");
            animation.From = fromX;
            animation.To = toX;
            animation.Duration = TimeSpan.FromSeconds(3);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            animation.AutoReverse = true;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }
    }
}
