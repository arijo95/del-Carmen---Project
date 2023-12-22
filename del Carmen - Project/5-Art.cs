using Spectre.Console;

public abstract class _51_Art
{
    protected _1_Boolean__Values test;
    protected _7_Settings set;
    protected _51_Art(_1_Boolean__Values test, _7_Settings set)
    {
        this.test = test;
        this.set = set;
    }
    public abstract void Print_MC(int x, int y);
    public abstract void Print_BD();
    public abstract void Print_FM(int linenum, int x, int y);
}
public class _52_Sprites : _51_Art
{
    public _52_Sprites(_1_Boolean__Values sharedValues, _7_Settings settings) : base(sharedValues, settings) { }
    public override void Print_MC(int x, int y) //Will wait for sister
    {
        string color1 = "#F4DE90";// hair base
        string color2 = "#F4C572";//hair shadow
        string color3 = "#FFE8DC";//skin base
        string color4 = "#FFDACB";//skin shadow
        string color5 = "#B53F3E";//scarf base
        string color6 = "#8D2A2A";//scarf shadow
        switch (test.costume)
        {
            case "0":
                color1 = "#B3B3B3";// hair base
                color2 = "#999999";//hair shadow
                color3 = "#FFFFFF";//skin base
                color4 = "#666666";//skin shadow
                color5 = "#262626";//scarf base
                color6 = "#000000";//scarf shadow
                break;
            default:
                color1 = "#F4DE90";// hair base
                color2 = "#F4C572";//hair shadow
                color3 = "#FFE8DC";//skin base
                color4 = "#FFDACB";//skin shadow
                color5 = "#B53F3E";//scarf base
                color6 = "#8D2A2A";//scarf shadow
                break;
        }

        Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]");
        Console.SetCursorPosition(x - 6, y + 1); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████████[/]");
        Console.SetCursorPosition(x - 12, y + 2); AnsiConsole.Markup($"[{color2}]██████████████[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 14, y + 3); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 18, y + 4); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 18, y + 5); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 22, y + 6); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 24, y + 7); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████████████[/]"); //add something start here
        Console.SetCursorPosition(x - 26, y + 8); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████[/]");
        Console.SetCursorPosition(x - 28, y + 9); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]");
        Console.SetCursorPosition(x - 28, y + 10); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████[/]");
        Console.SetCursorPosition(x - 30, y + 11); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████[/]");
        Console.SetCursorPosition(x - 34, y + 12); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████[/]");
        Console.SetCursorPosition(x - 34, y + 13); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████[/]");
        Console.SetCursorPosition(x - 34, y + 14); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████[/]"); AnsiConsole.Markup($"[{color4}]██████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");
        Console.SetCursorPosition(x - 36, y + 15); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color3}]████[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");
        Console.SetCursorPosition(x - 36, y + 16); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████████[/]"); AnsiConsole.Markup($"[{color3}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]");
        Console.SetCursorPosition(x - 36, y + 17); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color3}]██████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");
        Console.SetCursorPosition(x - 38, y + 18); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]████████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]████████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color3}]████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]");
        Console.SetCursorPosition(x - 38, y + 19); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]████████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]");
        Console.SetCursorPosition(x - 38, y + 20); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]");
        Console.SetCursorPosition(x - 38, y + 21); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color4}]████████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]");
        Console.SetCursorPosition(x - 38, y + 22); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color4}]████████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x - 38, y + 23); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x - 38, y + 24); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color4}]██████[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x - 38, y + 25); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x - 38, y + 26); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 38, y + 27); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 38, y + 28); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]████████████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 38, y + 29); AnsiConsole.Markup($"[{color2}]██████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 38, y + 30); AnsiConsole.Markup($"[{color2}]██████████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████[/]");
        Console.SetCursorPosition(x - 36, y + 31); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
        Console.SetCursorPosition(x - 36, y + 32); AnsiConsole.Markup($"[{color2}]██████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
        Console.SetCursorPosition(x - 34, y + 33); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████[/]"); AnsiConsole.Markup($"[{color4}]████████[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x - 34, y + 34); AnsiConsole.Markup($"[{color2}]██████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]████████████[/]"); AnsiConsole.Markup($"[{color4}]██████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x - 34, y + 35); AnsiConsole.Markup($"[{color2}]████████████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color4}]██████████████[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x - 34, y + 36); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color4}]██████████████[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x - 36, y + 37); AnsiConsole.Markup($"[{color6}]██████████[/]"); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color2}]████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color6}]████████████[/]"); AnsiConsole.Markup($"[{color4}]██████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x - 36, y + 38); AnsiConsole.Markup($"[{color6}]████████████[/]"); AnsiConsole.Markup($"[{color2}]████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████████[/]"); AnsiConsole.Markup($"[{color4}]████████████[/]"); AnsiConsole.Markup($"[{color3}]████████████████[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]");
    }
    public void EraseMC(int x, int y)
    {
        for (int i = 0; i <= 38; i++)
        {
            Console.SetCursorPosition(x - 38, y + i); Console.Write("                                                                                                                                            ");
        }
    }
    public override void Print_BD() //Color changes only
    {
        int x = 0; int y = 0;
        string color1 = "silver";
        string color2 = "grey";
        string color3 = "black";
        string color4 = "white";
        switch (set.Border)
        {
            case "border1":
                color1 = "silver";
                color2 = "grey";
                color3 = "black";
                color4 = "white";
                break;
            case "border2":
                color1 = "#777777";
                color2 = "#ffe1ad";
                color3 = "#293131";
                color4 = "white";
                break;
            default:
                color1 = "#293131";
                color2 = "#736C84";
                color3 = "#4A4A6B";
                color4 = "white";
                break;

        }
        Console.SetCursorPosition(x + 12, y + 128); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 8, y + 129); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 6, y + 130); AnsiConsole.Markup($"[{color1}]██████[/]"); Console.SetCursorPosition(x + 20, y + 130); AnsiConsole.Markup($"[{color1}]██[/]"); Console.SetCursorPosition(x + 778, y + 130); AnsiConsole.Markup($"[{color1}]██[/]"); Console.SetCursorPosition(x + 788, y + 130); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x + 4, y + 131); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 792, y + 131); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x + 4, y + 132); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 792, y + 132); AnsiConsole.Markup($"[{color1}]████[/]");
        for (int i = 133; i <= 175; i++)
        {
            Console.SetCursorPosition(x + 2, i); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 794, i); AnsiConsole.Markup($"[{color1}]████[/]");
        }
        Console.SetCursorPosition(x + 4, y + 176); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 792, y + 176); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x + 4, y + 177); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 792, y + 177); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x + 6, y + 178); AnsiConsole.Markup($"[{color1}]██████[/]"); Console.SetCursorPosition(x + 20, y + 178); AnsiConsole.Markup($"[{color1}]██[/]"); Console.SetCursorPosition(x + 778, y + 178); AnsiConsole.Markup($"[{color1}]██[/]"); Console.SetCursorPosition(x + 788, y + 178); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x + 8, y + 179); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 12, y + 180); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");

        Console.SetCursorPosition(x + 12, y + 130); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 780, y + 130); AnsiConsole.Markup($"[{color2}]████████[/]");
        Console.SetCursorPosition(x + 8, y + 131); AnsiConsole.Markup($"[{color2}]██████████[/]"); Console.SetCursorPosition(x + 782, y + 131); AnsiConsole.Markup($"[{color2}]██████████[/]");
        Console.SetCursorPosition(x + 8, y + 132); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 784, y + 132); AnsiConsole.Markup($"[{color2}]████████[/]");
        for (int i = 133; i <= 175; i++)
        {
            Console.SetCursorPosition(x + 6, i); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 786, i); AnsiConsole.Markup($"[{color2}]████████[/]");
        }
        Console.SetCursorPosition(x + 8, y + 176); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 784, y + 176); AnsiConsole.Markup($"[{color2}]████████[/]");
        Console.SetCursorPosition(x + 8, y + 177); AnsiConsole.Markup($"[{color2}]██████████[/]"); Console.SetCursorPosition(x + 782, y + 177); AnsiConsole.Markup($"[{color2}]██████████[/]");
        Console.SetCursorPosition(x + 12, y + 178); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 780, y + 178); AnsiConsole.Markup($"[{color2}]████████[/]");

        Console.SetCursorPosition(x + 22, y + 130); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 18, y + 131); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 780, y + 131); AnsiConsole.Markup($"[{color3}]██[/]");
        Console.SetCursorPosition(x + 16, y + 132); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 782, y + 132); AnsiConsole.Markup($"[{color3}]██[/]");
        for (int i = 133; i <= 175; i++)
        {
            Console.SetCursorPosition(x + 14, i); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 784, i); AnsiConsole.Markup($"[{color3}]██[/]");
        }
        Console.SetCursorPosition(x + 16, y + 176); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 782, y + 176); AnsiConsole.Markup($"[{color3}]██[/]");
        Console.SetCursorPosition(x + 18, y + 177); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 780, y + 177); AnsiConsole.Markup($"[{color3}]██[/]");
        Console.SetCursorPosition(x + 22, y + 178); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");

        Console.SetCursorPosition(x + 20, y + 131); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 18, y + 132); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        for (int i = 133; i <= 175; i++)
        {
            Console.SetCursorPosition(x + 16, i); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        }
        Console.SetCursorPosition(x + 18, y + 176); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 20, y + 177); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
    }
    public void Print_WBD() //Clears the white space
    {
        int x = 0;
        string color4 = "white";
        for (int i = 136; i <= 169; i++)
        {
            Console.SetCursorPosition(x + 16, i); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        }
    }
    public void Print_WSBD() //Clears the white space of the lines only
    {
        int x = 0;
        string color4 = "white";
        for (int i = 136; i <= 169; i++)
        {
            Console.SetCursorPosition(x + 150, i); AnsiConsole.Markup($"[{color4}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        }
    }
    public void Change_BD() //Does not include the middle part
    {
        int x = 0; int y = 0;
        string color1 = "silver";
        string color2 = "grey";
        string color3 = "black";
        switch (set.Border)
        {
            case "border1":
                color1 = "silver";
                color2 = "grey";
                color3 = "black";
                break;
            case "border2":
                color1 = "#777777";
                color2 = "#ffe1ad";
                color3 = "#293131";
                break;
            default:
                color1 = "#293131";
                color2 = "#736C84";
                color3 = "#4A4A6B";
                break;
        }
        Console.SetCursorPosition(x + 12, y + 128); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 8, y + 129); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 6, y + 130); AnsiConsole.Markup($"[{color1}]██████[/]"); Console.SetCursorPosition(x + 20, y + 130); AnsiConsole.Markup($"[{color1}]██[/]"); Console.SetCursorPosition(x + 778, y + 130); AnsiConsole.Markup($"[{color1}]██[/]"); Console.SetCursorPosition(x + 788, y + 130); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x + 4, y + 131); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 792, y + 131); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x + 4, y + 132); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 792, y + 132); AnsiConsole.Markup($"[{color1}]████[/]");
        for (int i = 133; i <= 175; i++)
        {
            Console.SetCursorPosition(x + 2, i); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 794, i); AnsiConsole.Markup($"[{color1}]████[/]");
        }
        Console.SetCursorPosition(x + 4, y + 176); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 792, y + 176); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x + 4, y + 177); AnsiConsole.Markup($"[{color1}]████[/]"); Console.SetCursorPosition(x + 792, y + 177); AnsiConsole.Markup($"[{color1}]████[/]");
        Console.SetCursorPosition(x + 6, y + 178); AnsiConsole.Markup($"[{color1}]██████[/]"); Console.SetCursorPosition(x + 20, y + 178); AnsiConsole.Markup($"[{color1}]██[/]"); Console.SetCursorPosition(x + 778, y + 178); AnsiConsole.Markup($"[{color1}]██[/]"); Console.SetCursorPosition(x + 788, y + 178); AnsiConsole.Markup($"[{color1}]██████[/]");
        Console.SetCursorPosition(x + 8, y + 179); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 12, y + 180); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");

        Console.SetCursorPosition(x + 12, y + 130); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 780, y + 130); AnsiConsole.Markup($"[{color2}]████████[/]");
        Console.SetCursorPosition(x + 8, y + 131); AnsiConsole.Markup($"[{color2}]██████████[/]"); Console.SetCursorPosition(x + 782, y + 131); AnsiConsole.Markup($"[{color2}]██████████[/]");
        Console.SetCursorPosition(x + 8, y + 132); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 784, y + 132); AnsiConsole.Markup($"[{color2}]████████[/]");
        for (int i = 133; i <= 175; i++)
        {
            Console.SetCursorPosition(x + 6, i); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 786, i); AnsiConsole.Markup($"[{color2}]████████[/]");
        }
        Console.SetCursorPosition(x + 8, y + 176); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 784, y + 176); AnsiConsole.Markup($"[{color2}]████████[/]");
        Console.SetCursorPosition(x + 8, y + 177); AnsiConsole.Markup($"[{color2}]██████████[/]"); Console.SetCursorPosition(x + 782, y + 177); AnsiConsole.Markup($"[{color2}]██████████[/]");
        Console.SetCursorPosition(x + 12, y + 178); AnsiConsole.Markup($"[{color2}]████████[/]"); Console.SetCursorPosition(x + 780, y + 178); AnsiConsole.Markup($"[{color2}]████████[/]");

        Console.SetCursorPosition(x + 22, y + 130); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
        Console.SetCursorPosition(x + 18, y + 131); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 780, y + 131); AnsiConsole.Markup($"[{color3}]██[/]");
        Console.SetCursorPosition(x + 16, y + 132); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 782, y + 132); AnsiConsole.Markup($"[{color3}]██[/]");
        for (int i = 133; i <= 175; i++)
        {
            Console.SetCursorPosition(x + 14, i); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 784, i); AnsiConsole.Markup($"[{color3}]██[/]");
        }
        Console.SetCursorPosition(x + 16, y + 176); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 782, y + 176); AnsiConsole.Markup($"[{color3}]██[/]");
        Console.SetCursorPosition(x + 18, y + 177); AnsiConsole.Markup($"[{color3}]██[/]"); Console.SetCursorPosition(x + 780, y + 177); AnsiConsole.Markup($"[{color3}]██[/]");
        Console.SetCursorPosition(x + 22, y + 178); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
    }
    public override void Print_FM(int linenum, int x, int y)
    {
        string color1 = "#293131";
        string color2 = "#7373AE";
        string color3 = "#8D8CC4";
        string color4 = "#636395";
        string color5 = "#736C84";
        string color6 = "#4A4A6B";
        string color7 = "#ADBDAD";
        string color8 = "#DFD7DF";
        string color9 = "white";
        switch (set.Frame)
        {
            case "frame1":
                color1 = "#4A4252";
                color2 = "#6B7B7B";
                color3 = "#CEDEDE";
                color4 = "#9CADAE";
                color5 = "#B5BDB5";
                color6 = "#DFD7DF";
                color7 = "white";
                Console.SetCursorPosition(x + 2, y - 1); AnsiConsole.Markup($"[{color1}]████████████[/]"); Console.SetCursorPosition(x + 186, y - 1); AnsiConsole.Markup($"[{color1}]████████████[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 4); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x - 2, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 6); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");

                switch (linenum)
                {
                    case 1:
                        for (int i = 7; i <= 30; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 31);
                        break;
                    case 2:
                        for (int i = 7; i <= 47; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 48);
                        break;
                    case 3:
                        for (int i = 7; i <= 64; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 65);
                        break;
                    case 4:
                        for (int i = 7; i <= 81; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 82);
                        break;
                    case 5:
                        for (int i = 7; i <= 98; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 99);
                        break;
                    case 6:
                        for (int i = 7; i <= 115; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 116);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x - 2, y); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");
                Console.SetCursorPosition(x - 2, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 2); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x - 2, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{color1}]████████████[/]"); Console.SetCursorPosition(x + 186, y + 7); AnsiConsole.Markup($"[{color1}]████████████[/]");
                break;
            case "frame2":
                color1 = "#2e3d49";
                color2 = "#aaaaaa";
                color3 = "#777777";
                color4 = "#ffe1ad";
                color5 = "#57636d";
                color6 = "#eeeeee";
                color7 = "#4A4252";
                color8 = "#DFD7DF";
                color9 = "white";
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]████████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]████████[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color7}]██████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                switch (linenum)
                {
                    case 1:
                        for (int i = 7; i <= 30; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 31);
                        break;
                    case 2:
                        for (int i = 7; i <= 47; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 48);
                        break;
                    case 3:
                        for (int i = 7; i <= 64; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 65);
                        break;
                    case 4:
                        for (int i = 7; i <= 81; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 82);
                        break;
                    case 5:
                        for (int i = 7; i <= 98; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 99);
                        break;
                    case 6:
                        for (int i = 7; i <= 115; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 116);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                break;
            default:
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");

                switch (linenum)
                {
                    case 1:
                        for (int i = 6; i <= 31; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 32);
                        break;
                    case 2:
                        for (int i = 6; i <= 48; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 49);
                        break;
                    case 3:
                        for (int i = 6; i <= 65; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 66);
                        break;
                    case 4:
                        for (int i = 6; i <= 82; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 83);
                        break;
                    case 5:
                        for (int i = 6; i <= 99; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 100);
                        break;
                    case 6:
                        for (int i = 6; i <= 116; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 117);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                break;
        }
    }
    public void Print_WFM(int linenum, int x, int y)
    {
        string color7 = "white";
        switch (linenum)
        {
            case 1:
                for (int i = 14; i <= 25; i++)
                {
                    Console.SetCursorPosition(x + 38, y + i); AnsiConsole.Markup($"[{color7}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                }
                break;
            case 2:
                for (int i = 14; i <= 42; i++)
                {
                    Console.SetCursorPosition(x + 38, y + i); AnsiConsole.Markup($"[{color7}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                }
                break;
            case 3:
                for (int i = 14; i <= 59; i++)
                {
                    Console.SetCursorPosition(x + 38, y + i); AnsiConsole.Markup($"[{color7}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                }
                break;
            case 4:
                for (int i = 14; i <= 76; i++)
                {
                    Console.SetCursorPosition(x + 38, y + i); AnsiConsole.Markup($"[{color7}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                }
                break;
            case 5:
                for (int i = 14; i <= 93; i++)
                {
                    Console.SetCursorPosition(x + 38, y + i); AnsiConsole.Markup($"[{color7}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                }
                break;
            case 6:
                for (int i = 14; i <= 110; i++)
                {
                    Console.SetCursorPosition(x + 38, y + i); AnsiConsole.Markup($"[{color7}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                }
                break;
        }
    } //Outdated But will retain since too tiring
    public void Change_FM(int linenum, int x, int y)
    {
        string color1 = "#293131";
        string color2 = "#7373AE";
        string color3 = "#8D8CC4";
        string color4 = "#636395";
        string color5 = "#736C84";
        string color6 = "#4A4A6B";
        string color7 = "#ADBDAD";
        string color8 = "#DFD7DF";
        string color9 = "white";
        switch (set.Frame)
        {
            case "frame1":
                color1 = "#4A4252";
                color2 = "#6B7B7B";
                color3 = "#CEDEDE";
                color4 = "#9CADAE";
                color5 = "#B5BDB5";
                color6 = "#DFD7DF";
                color7 = "white";
                Console.SetCursorPosition(x + 2, y - 1); AnsiConsole.Markup($"[{color1}]████████████[/]"); Console.SetCursorPosition(x + 186, y - 1); AnsiConsole.Markup($"[{color1}]████████████[/]");
                Console.SetCursorPosition(x - 2, y); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 4); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x - 2, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + 5); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 6); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + 6); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");
                switch (linenum)
                {
                    case 1:
                        for (int i = 7; i <= 30; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 31);
                        break;
                    case 2:
                        for (int i = 7; i <= 47; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 48);
                        break;
                    case 3:
                        for (int i = 7; i <= 64; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 65);
                        break;
                    case 4:
                        for (int i = 7; i <= 81; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 82);
                        break;
                    case 5:
                        for (int i = 7; i <= 98; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 99);
                        break;
                    case 6:
                        for (int i = 7; i <= 115; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 116);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x - 2, y); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");
                Console.SetCursorPosition(x - 2, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + 1); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 2); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x - 2, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 6); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x + 2, y + 7); Console.Write(new string(' ', 206));
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{color1}]████████████[/]"); Console.SetCursorPosition(x + 186, y + 7); AnsiConsole.Markup($"[{color1}]████████████[/]");
                break;
            case "frame2":
                color1 = "#2e3d49";
                color2 = "#aaaaaa";
                color3 = "#777777";
                color4 = "#ffe1ad";
                color5 = "#57636d";
                color6 = "#eeeeee";
                color7 = "#4A4252";
                color8 = "#DFD7DF";
                color9 = "white";
                Console.SetCursorPosition(x + 2, y - 1); Console.Write("            "); Console.SetCursorPosition(x + 186, y - 1); Console.Write("            ");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]████████████[/]"); AnsiConsole.Markup($"[{color3}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x - 2, y + 1); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 2); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 3); Console.Write("  "); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 4); Console.Write("  "); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 5); Console.Write("  "); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.SetCursorPosition(x + 186, y + 5); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 6); Console.Write("  "); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]████████[/]"); Console.SetCursorPosition(x + 186, y + 6); AnsiConsole.Markup($"[{color7}]██████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                switch (linenum)
                {
                    case 1:
                        for (int i = 7; i <= 30; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 31);
                        break;
                    case 2:
                        for (int i = 7; i <= 47; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 48);
                        break;
                    case 3:
                        for (int i = 7; i <= 64; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 65);
                        break;
                    case 4:
                        for (int i = 7; i <= 81; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 82);
                        break;
                    case 5:
                        for (int i = 7; i <= 98; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 99);
                        break;
                    case 6:
                        for (int i = 7; i <= 115; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); Console.SetCursorPosition(x + 190, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 116);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x - 2, y); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.SetCursorPosition(x + 186, y); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 1); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.SetCursorPosition(x + 186, y + 1); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 2); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 3); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 4); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 5); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                Console.SetCursorPosition(x + 2, y + 7); Console.Write(new string(' ', 206));
                break;
            default:
                Console.SetCursorPosition(x + 2, y - 1); Console.Write("            "); Console.SetCursorPosition(x + 186, y - 1); Console.Write("            ");
                Console.SetCursorPosition(x, y); Console.Write("  "); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 1); Console.Write("  "); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 2); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 3); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 4); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 5); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + 5); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 6); Console.Write("  "); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]████████[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + 6); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color7}]██████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); Console.Write("  ");

                switch (linenum)
                {
                    case 1:
                        for (int i = 6; i <= 31; i++)
                        {
                            Console.SetCursorPosition(x - 2, y + i); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + i); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                        }
                        Console.SetCursorPosition(x, y + 32);
                        break;
                    case 2:
                        for (int i = 6; i <= 48; i++)
                        {
                            Console.SetCursorPosition(x - 2, y + i); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + i); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                        }
                        Console.SetCursorPosition(x, y + 49);
                        break;
                    case 3:
                        for (int i = 6; i <= 65; i++)
                        {
                            Console.SetCursorPosition(x - 2, y + i); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + i); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                        }
                        Console.SetCursorPosition(x, y + 66);
                        break;
                    case 4:
                        for (int i = 6; i <= 82; i++)
                        {
                            Console.SetCursorPosition(x - 2, y + i); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + i); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                        }
                        Console.SetCursorPosition(x, y + 83);
                        break;
                    case 5:
                        for (int i = 6; i <= 99; i++)
                        {
                            Console.SetCursorPosition(x - 2, y + i); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + i); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                        }
                        Console.SetCursorPosition(x, y + 100);
                        break;
                    case 6:
                        for (int i = 6; i <= 116; i++)
                        {
                            Console.SetCursorPosition(x - 2, y + i); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y + i); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                        }
                        Console.SetCursorPosition(x, y + 117);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x - 2, y); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color9}]████[/]"); Console.SetCursorPosition(x + 186, y); AnsiConsole.Markup($"[{color9}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 1); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 2); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 3); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 4); Console.Write("  "); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); Console.Write("  ");
                Console.SetCursorPosition(x - 2, y + 5); Console.Write("  "); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); AnsiConsole.Markup($"[{color1}]████[/]"); Console.Write("  ");
                Console.SetCursorPosition(x, y + 6); Console.Write("  "); AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); Console.Write("  ");
                break;
        }
    } //Outdated but will retain since too tiring
    public void Choices(int linenum, int x, int y, int length) //Includes length of the choices basically an update Print_FM
    {
        string color1 = "#293131";
        string color2 = "#7373AE";
        string color3 = "#8D8CC4";
        string color4 = "#636395";
        string color5 = "#736C84";
        string color6 = "#4A4A6B";
        string color7 = "#ADBDAD";
        string color8 = "#DFD7DF";
        string color9 = "white";
        switch (set.Frame)
        {
            case "frame1":
                color1 = "#4A4252";
                color2 = "#6B7B7B";
                color3 = "#CEDEDE";
                color4 = "#9CADAE";
                color5 = "#B5BDB5";
                color6 = "#DFD7DF";
                color7 = "white";
                Console.SetCursorPosition(x + 2, y - 1); AnsiConsole.Markup($"[{color1}]████████████[/]"); Console.SetCursorPosition(x + length * 100 + 6, y - 1); AnsiConsole.Markup($"[{color1}]████████████[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); for (int i = 1; i <= length; i++) { AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 12 + length * 100 - 4, y); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); for (int i = 1; i <= length; i++) { AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 + length * 100 - 8, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); for (int i = 1; i <= length; i++) { AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 + length * 100 - 8, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); for (int i = 1; i <= length; i++) { AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 + length * 100 - 8, y + 3); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 4); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); for (int i = 1; i <= length; i++) { AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 4); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x - 2, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int i = 1; i <= length; i++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 5); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 6); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int i = 1; i <= length; i++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 6); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");

                switch (linenum)
                {
                    case 1:
                        for (int i = 7; i <= 30; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 31);
                        break;
                    case 2:
                        for (int i = 7; i <= 47; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 48);
                        break;
                    case 3:
                        for (int i = 7; i <= 64; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 65);
                        break;
                    case 4:
                        for (int i = 7; i <= 81; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 82);
                        break;
                    case 5:
                        for (int i = 7; i <= 98; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 99);
                        break;
                    case 6:
                        for (int i = 7; i <= 115; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 116);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x - 2, y); AnsiConsole.Markup($"[{color1}]██████████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██████████[/]");
                Console.SetCursorPosition(x - 2, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 1); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 2); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 2); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x - 2, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]████████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 + length * 100 - 8, y + 3); AnsiConsole.Markup($"[{color1}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 + length * 100 - 8, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x - 2, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 + length * 100 - 8, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 12 + length * 100 - 4, y + 6); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{color1}]████████████[/]"); Console.SetCursorPosition(x + length * 100 + 6, y + 7); AnsiConsole.Markup($"[{color1}]████████████[/]");
                break;
            case "frame2":
                color1 = "#2e3d49";
                color2 = "#aaaaaa";
                color3 = "#777777";
                color4 = "#ffe1ad";
                color5 = "#57636d";
                color6 = "#eeeeee";
                color7 = "#4A4252";
                color8 = "#DFD7DF";
                color9 = "white";
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]████████████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 12 - 6 + length * 100, y); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 1); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]██████████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color4}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 2); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 12 - 6 + length * 100, y + 3); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 4); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 5); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]████████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 6); AnsiConsole.Markup($"[{color7}]██████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                switch (linenum)
                {
                    case 1:
                        for (int i = 7; i <= 30; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 31);
                        break;
                    case 2:
                        for (int i = 7; i <= 47; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 48);
                        break;
                    case 3:
                        for (int i = 7; i <= 64; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 65);
                        break;
                    case 4:
                        for (int i = 7; i <= 81; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 82);
                        break;
                    case 5:
                        for (int i = 7; i <= 98; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 99);
                        break;
                    case 6:
                        for (int i = 7; i <= 115; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 116);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color3}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color1}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 1); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 2); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 12 - 6 + length * 100, y + 3); AnsiConsole.Markup($"[{color3}]████████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 4); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color2}]████[/]"); AnsiConsole.Markup($"[{color5}]██[/]"); AnsiConsole.Markup($"[{color6}]████[/]"); AnsiConsole.Markup($"[{color1}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color2}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 14 - 8 + length * 100, y + 5); AnsiConsole.Markup($"[{color3}]██[/]"); AnsiConsole.Markup($"[{color4}]██████████[/]"); AnsiConsole.Markup($"[{color7}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{color7}]██████████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 6); AnsiConsole.Markup($"[{color7}]██████████[/]");
                break;
            default:
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{color1}]████████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y); AnsiConsole.Markup($"[{color1}]████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color3}]████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color3}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 1); AnsiConsole.Markup($"[{color3}]████[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 2); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 3); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 8 + length * 100, y + 4); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 5); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");

                switch (linenum)
                {
                    case 1:
                        for (int i = 6; i <= 31; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 32);
                        break;
                    case 2:
                        for (int i = 6; i <= 48; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 49);
                        break;
                    case 3:
                        for (int i = 6; i <= 65; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 66);
                        break;
                    case 4:
                        for (int i = 6; i <= 82; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 83);
                        break;
                    case 5:
                        for (int i = 6; i <= 99; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 100);
                        break;
                    case 6:
                        for (int i = 6; i <= 116; i++)
                        {
                            Console.SetCursorPosition(x, y + i); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color8}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                            Console.SetCursorPosition(x + 10 + length * 100, y + i); AnsiConsole.Markup($"[{color8}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                        }
                        Console.SetCursorPosition(x, y + 117);
                        break;
                }
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color9}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color7}]██[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color8}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 8 + length * 100, y + 1); AnsiConsole.Markup($"[{color7}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 2); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]████████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 6 + length * 100, y + 3); AnsiConsole.Markup($"[{color5}]████████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{color1}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color5}]██████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color5}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 6 + length * 100, y + 4); AnsiConsole.Markup($"[{color5}]██████[/]"); AnsiConsole.Markup($"[{color4}]██[/]"); AnsiConsole.Markup($"[{color2}]██[/]"); AnsiConsole.Markup($"[{color6}]██[/]"); AnsiConsole.Markup($"[{color1}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{color1}]████[/]"); AnsiConsole.Markup($"[{color6}]██████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color6}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 5); AnsiConsole.Markup($"[{color6}]██████[/]"); AnsiConsole.Markup($"[{color1}]████[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{color1}]████████[/]"); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color1}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                Console.SetCursorPosition(x + 10 + length * 100, y + 6); AnsiConsole.Markup($"[{color1}]████████[/]");
                break;
        }
    }
    public void Change_WC(int linenum, int x, int y, int length) //Clear the white space of the Choices with the size in mind
    {
        string color7 = "white";
        switch (linenum)
        {
            case 1:
                for (int i = 12; i <= 25; i++)
                {
                    Console.SetCursorPosition(x + 10, y + i); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                }
                break;
            case 2:
                for (int i = 12; i <= 42; i++)
                {
                    Console.SetCursorPosition(x + 10, y + i); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                }
                break;
            case 3:
                for (int i = 12; i <= 59; i++)
                {
                    Console.SetCursorPosition(x + 10, y + i); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                }
                break;
            case 4:
                for (int i = 12; i <= 76; i++)
                {
                    Console.SetCursorPosition(x + 10, y + i); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                }
                break;
            case 5:
                for (int i = 12; i <= 93; i++)
                {
                    Console.SetCursorPosition(x + 10, y + i); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                }
                break;
            case 6:
                for (int i = 12; i <= 110; i++)
                {
                    Console.SetCursorPosition(x + 10, y + i); for (int j = 1; j <= length; j++) { AnsiConsole.Markup($"[{color7}]████████████████████████████████████████████████████████████████████████████████████████████████████[/]"); }
                }
                break;
        }
    }
    public void Erase_Choices(int linenum, int x, int y, int length)
    {
        for (int i = 0; i <= linenum * 14 + 25 + (linenum - 1) * 4; i++)
        {
            Console.SetCursorPosition(x - 2, y - 1 + i);
            Console.Write(new string(' ', 24 + 100 * length));
        }
    }
}