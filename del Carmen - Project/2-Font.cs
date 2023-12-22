using Spectre.Console;

public abstract class _21_Font_Handling
{
    protected _1_Boolean__Values test;
    protected _7_Settings set;
    protected _21_Font_Handling(_1_Boolean__Values test, _7_Settings set)
    {
        this.test = test;
        this.set = set;
    }
    public char special_char;
    public int special_num;
    public abstract void Print_Char(int x, int y, char c);
}
public class _22_Font : _21_Font_Handling
{
    public _22_Font(_1_Boolean__Values sharedValues, _7_Settings settings) : base(sharedValues, settings) { }
    public override void Print_Char(int x, int y, char c)
    {
        switch (c)
        {
            case ' ':
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '\t':
                while ((x - 6) % 6 != 0)
                {
                    x++;
                }
                Console.SetCursorPosition(x + 40, y + 10);
                break;
            case 'A':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'B':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'C':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'D':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'E':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); ;
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'F':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'G':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'H':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'I':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 4, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'J':
                Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'K':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'L':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'M':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'N':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'O':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'P':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'Q':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]"); Console.SetCursorPosition(x + 10, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 12, y + 10);
                break;
            case 'R':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'S':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'T':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 4, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'U':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'V':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'W':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'X':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'Y':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'Z':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'a':
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'b':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'c':
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'd':
                Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'e':
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'f':
                Console.SetCursorPosition(x + 6, y); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 4, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'g':
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'h':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'i':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 10);
                break;
            case 'j':
                Console.SetCursorPosition(x + 6, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 8, y + 10);
                break;
            case 'k':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'l':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 10);
                break;
            case 'm':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'n':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'o':
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'p':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'q':
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                break;
            case 'r':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 10);
                break;
            case 's':
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 't':
                Console.SetCursorPosition(x + 4, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'u':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'v':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'w':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'x':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'y':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case 'z':
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 6, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '0':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '1':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 6, y + 10);
                break;
            case '2':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '3':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '4':
                Console.SetCursorPosition(x + 4, y); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '5':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '6':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '7':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '8':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '9':
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case ',':
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 10);
                break;
            case '.':
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 4, y + 10);
                break;
            case '/':
                Console.SetCursorPosition(x + 8, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '\\':
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case ';':
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 10);
                break;
            case '’':
                Console.SetCursorPosition(x, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 10);
                break;
            case '\'':
                Console.SetCursorPosition(x, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 10);
                break;
            case '“':
                Console.SetCursorPosition(x + 2, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '”':
                Console.SetCursorPosition(x, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '+':
                Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '-':
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '%':
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]"); Console.SetCursorPosition(x + 8, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 6, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '?':
                Console.SetCursorPosition(x + 2, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '@':
                Console.SetCursorPosition(x + 4, y); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 12, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 14, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 10, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 14, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 10, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 14, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 14, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 10, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████████[/]");
                Console.SetCursorPosition(x + 16, y + 10);
                break;
            case '_':
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████████████[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '*':
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██████████[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '!':
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 10);
                break;
            case '^':
                Console.SetCursorPosition(x + 4, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '&':
                Console.SetCursorPosition(x + 4, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 6, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]████[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case ':':
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████[/]");
                Console.SetCursorPosition(x + 4, y + 10);
                break;
            case '[':
                Console.SetCursorPosition(x, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                break;
            case ']':
                Console.SetCursorPosition(x, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 4, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                break;
            case '{':
                Console.SetCursorPosition(x + 4, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                break;
            case '}':
                Console.SetCursorPosition(x, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 10);
                break;
            case '<':
                Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '>':
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 8, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '|':
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 10);
                break;
            case '#':
                Console.SetCursorPosition(x + 6, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 12, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 12, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 6, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 12, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]████████████████[/]");
                Console.SetCursorPosition(x + 4, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 10, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 10, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████████████████[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 16, y + 10);
                break;
            case '$':
                Console.SetCursorPosition(x + 2, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]"); Console.SetCursorPosition(x + 8, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██████[/]");
                Console.SetCursorPosition(x + 2, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]████████[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 10, y + 10);
                break;
            case '(':
                Console.SetCursorPosition(x + 2, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                break;
            case ')':
                Console.SetCursorPosition(x, y - 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y - 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 1); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 2); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 3); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 4); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 5); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 6); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 7); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 8); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 2, y + 9); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x, y + 10); AnsiConsole.Markup($"[{set.Text_Color}]██[/]");
                Console.SetCursorPosition(x + 4, y + 10);
                break;
        }
    }
}