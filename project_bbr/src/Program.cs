using project_bbr.src;
using Raylib_cs;
using System.Numerics;

class Program
{
    public static void Main()
    {

        // Game.Run();


        Raylib.InitWindow(800, 480, "Hello BBR");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            Raylib.DrawText("Hello, BBR!", 12, 12, 20, Color.Black);

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}