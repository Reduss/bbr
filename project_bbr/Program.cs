using Raylib_cs;

class Program
{
    public static void Main()
    {
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