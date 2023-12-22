public class _6_Printing
{
    private _1_Boolean__Values test;
    private _22_Font font;
    private _42_Game_Script script;
    private _52_Sprites art;
    private _7_Settings set;
    public _6_Printing(_1_Boolean__Values test, _42_Game_Script script, _7_Settings set, _22_Font font, _52_Sprites art)
    {
        this.test = test;
        this.set = set;
        this.script = script;
        this.font = font;
        this.art = art;
    }
    public void PrintScript()
    {
        Console.SetCursorPosition(0, 155);
        int x; int y;
        switch (script.LineSize)
        {
            case 1:
                if (script.Speaker == $"{test.FirstName} :" || script.Speaker == "[???] :" || script.Speaker == $"S{test.GameID} :")
                {
                    test.costume = "1";
                    art.Print_MC(700, 63 + 26);
                }
                else
                {
                    test.costume = "0";
                    art.Print_MC(700, 63 + 26);
                }
                if (script.TempSpeaker != script.Speaker)
                {
                    art.Print_WBD();
                    Console.SetCursorPosition(40, 144 + 2 - 5);
                    foreach (char c in script.Speaker)
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = set.SD_Color;
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = set.FG_Color;
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
                else { art.Print_WSBD(); }
                Console.SetCursorPosition(150, 144 + 2 - 5);
                foreach (char c in script.Line1)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop; set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                break;
            case 2:
                if (script.Speaker == $"{test.FirstName} :" || script.Speaker == "[???] :" || script.Speaker == $"S{test.GameID} :")
                {
                    test.costume = "1";
                    art.Print_MC(700, 63 + 26);
                }
                else
                {
                    test.costume = "0";
                    art.Print_MC(700, 63 + 26);
                }
                if (script.TempSpeaker != script.Speaker)
                {
                    art.Print_WBD();
                    Console.SetCursorPosition(40, 144 + 2 - 5);
                    foreach (char c in script.Speaker)
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = set.SD_Color;
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = set.FG_Color;
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
                else { art.Print_WSBD(); }
                Console.SetCursorPosition(150, 144 + 2 - 5);
                foreach (char c in script.Line1)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.SetCursorPosition(150, 161 + 2 - 5);
                foreach (char c in script.Line2)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                break;
            case 3:
                if (script.Speaker == $"{test.FirstName} :" || script.Speaker == "[???] :" || script.Speaker == $"S{test.GameID} :")
                {
                    test.costume = "1";
                    art.Print_MC(700, 63 + 26);
                }
                else
                {
                    test.costume = "0";
                    art.Print_MC(700, 63 + 26);
                }
                if (script.TempSpeaker != script.Speaker)
                {
                    art.Print_WBD();
                    Console.SetCursorPosition(40, 144 + 2 - 5);
                    foreach (char c in script.Speaker)
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = set.SD_Color;
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = set.FG_Color;
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
                else { art.Print_WSBD(); }
                Console.SetCursorPosition(150, 144 + 2 - 5);
                foreach (char c in script.Line1)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.SetCursorPosition(150, 161 + 2 - 5);
                foreach (char c in script.Line2)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.ReadKey(intercept: true);
                art.Print_WSBD();
                Console.SetCursorPosition(150, 144 + 2 - 5);
                foreach (char c in script.Line2)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.SetCursorPosition(150, 161 + 2 - 5);
                foreach (char c in script.Line3)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                break;
            case 4:
                if (script.Speaker == $"{test.FirstName} :" || script.Speaker == "[???] :" || script.Speaker == $"S{test.GameID} :")
                {
                    test.costume = "1";
                    art.Print_MC(700, 63 + 26);
                }
                else
                {
                    test.costume = "0";
                    art.Print_MC(700, 63 + 26);
                }
                if (script.TempSpeaker != script.Speaker)
                {
                    art.Print_WBD();
                    Console.SetCursorPosition(40, 144 + 2 - 5);
                    foreach (char c in script.Speaker)
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = set.SD_Color;
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = set.FG_Color;
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
                else { art.Print_WSBD(); }
                Console.SetCursorPosition(150, 144 + 2 - 5);
                foreach (char c in script.Line1)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.SetCursorPosition(150, 161 + 2 - 5);
                foreach (char c in script.Line2)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.ReadKey(intercept: true);
                art.Print_WSBD();
                Console.SetCursorPosition(150, 144 + 2 - 5);
                foreach (char c in script.Line2)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.SetCursorPosition(150, 161 + 2 - 5);
                foreach (char c in script.Line3)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.ReadKey(intercept: true);
                art.Print_WSBD();
                Console.SetCursorPosition(150, 144 + 2 - 5);
                foreach (char c in script.Line3)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                Console.SetCursorPosition(150, 161 + 2 - 5);
                foreach (char c in script.Line4)
                {
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    set.Text_Color = set.SD_Color;
                    font.Print_Char(x + 1, y + 1, c);
                    font.Print_Char(x + 1, y, c);
                    set.Text_Color = set.FG_Color;
                    font.Print_Char(x, y, c);
                    Thread.Sleep(set.Delay);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                break;
        }
    }
}