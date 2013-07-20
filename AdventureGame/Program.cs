using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using SFML.Graphics;
using SFML.Window;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = new RenderWindow(new VideoMode(1280, 720), "AdventureGame", Styles.Close);
            var stopwatch = new Stopwatch();

            window.Closed += (sender, eventArgs) => window.Close();
            window.SetFramerateLimit(60);
            stopwatch.Start();

            double accumulator = 0.0;
            const double tickLength = 1 / 30.0;

            while (window.IsOpen())
            {
                accumulator += stopwatch.Elapsed.TotalSeconds;
                stopwatch.Restart();

                while (accumulator >= tickLength)
                {
                    // Tick!
                    accumulator -= tickLength;
                }

                window.Clear(Color.Black);
                {
                    // Render!
                }
                window.Display();

                window.DispatchEvents();
            }
        }
    }
}
