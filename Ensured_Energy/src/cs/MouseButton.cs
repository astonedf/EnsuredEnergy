using Godot;

// Godot 4 MouseButton enum workaround
public class MouseButton : Node
{
    public static readonly int None = 0;
    public static readonly int Left = 1;
    public static readonly int Right = 2;
    public static readonly int Middle = 3;
    public static readonly int WheelUp = 4;
    public static readonly int WheelDown = 5;
    public static readonly int WheelLeft = 6;
    public static readonly int WheelRight = 7;
    public static readonly int Xbutton1 = 8;
    public static readonly int Xbutton2 = 9;
}