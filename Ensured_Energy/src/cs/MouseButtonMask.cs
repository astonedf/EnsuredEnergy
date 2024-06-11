using Godot;

// Godot 4 MouseButtonMask enum workaround
public class MouseButtonMask : Node
{
    public static readonly int Left = 1;
    public static readonly int Right = 2;
    public static readonly int Middle = 4;
    public static readonly int Xbutton1 = 128;
    public static readonly int Xbutton2 = 256;
}
