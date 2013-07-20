using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Graphics;
using SFML.Window;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = new RenderWindow(new VideoMode(1280, 720), "AdventureGame", Styles.Close);
            window.SetFramerateLimit(60);

            window.Closed += (sender, eventArgs) => window.Close();

            while (window.IsOpen())
            {
                window.DispatchEvents();

                window.Clear(Color.Black);

                window.Display();
            }
        }
    }
}
