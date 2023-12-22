using Spectre.Console;
public class _8_Ease //To make my life easier
{
    private _1_Boolean__Values test;
    private _22_Font font;
    private _42_Game_Script script;
    private _52_Sprites art;
    private _6_Printing print;
    private _7_Settings set;
    public _8_Ease(_1_Boolean__Values test, _7_Settings set, _42_Game_Script script)
    {
        this.test = test;
        this.set = set;
        font = new _22_Font(test, set);
        script = new _42_Game_Script(test, set);
        art = new _52_Sprites(test, set);
        print = new _6_Printing(test, script, set, font, art);
        this.script = script;
    }
    public void Menu3()
    {
        int x, y, current_index = 0, c_index1 = 0, c_index2 = 0, c_index0 = 0;
        test.InMenu = true;
        string[] menu_choices = { "Continue", "Options", "Exit" };
        string[] bordercolor = { "Border3", "Border1", "Border2" };
        string[] frametype = { "Frame3", "Frame1", "Frame2" };
        art.Print_FM(3, 2, 1);
        while (test.InMenu)
        {
            art.Print_WFM(3, 2, 1);
            for (int i = 0; i < menu_choices.Length; i++)
            {
                int index = (current_index + i) % menu_choices.Length;

                if (i == 0)
                {
                    Console.SetCursorPosition(40, 15);
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    foreach (char c in menu_choices[index])
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = "silver";
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = "black";
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
                else if (i == 1)
                {
                    Console.SetCursorPosition(40, 32);
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    foreach (char c in menu_choices[index])
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = "silver";
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = "grey";
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
                else if (i == 2)
                {
                    Console.SetCursorPosition(40, 49);
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    foreach (char c in menu_choices[index])
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = "silver";
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = "grey";
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
            }
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.UpArrow)
            {
                current_index = (current_index + menu_choices.Length - 1) % menu_choices.Length;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                current_index = (current_index + 1) % menu_choices.Length;
            }
            else if (key.Key == ConsoleKey.X)
            {
                test.InMenu = false;
                Console.SetCursorPosition(0, 0);
                x = Console.CursorLeft;
                y = Console.CursorTop;
                for (int i = 0; i <= 100; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(new string(' ', 206));
                }
            }
            else if (key.Key == ConsoleKey.Z)
            {
                switch (menu_choices[current_index])
                {
                    case "Continue":
                        test.InMenu = false;
                        Console.SetCursorPosition(0, 0);
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        for (int i = 0; i <= 100; i++)
                        {
                            Console.SetCursorPosition(x, y + i);
                            Console.Write(new string(' ', 206));
                        }
                        if (test.Options)
                        {
                            test.Options = false;
                            test.MainMenu = true;
                        }
                        break;
                    case "Options":
                        test.InOptions = true;
                        switch (set.Border)
                        {
                            case "border1":
                                c_index1 = 1;
                                break;
                            case "border2":
                                c_index1 = 2;
                                break;
                            default:
                                c_index1 = 0;
                                break;
                        }
                        switch (set.Frame)
                        {
                            case "frame1":
                                c_index2 = 1;
                                break;
                            case "frame2":
                                c_index2 = 2;
                                break;
                            default:
                                c_index2 = 0;
                                break;
                        }
                        art.Print_FM(2, 206, 1);
                        while (test.InOptions)
                        {
                            string[] opt_choices = { bordercolor[c_index1], frametype[c_index2] };
                            for (int i = 0; i < opt_choices.Length; i++)
                            {
                                int index = (c_index0 + i) % opt_choices.Length;
                                if (i == 0)
                                {
                                    Console.SetCursorPosition(244, 15);
                                    x = Console.CursorLeft;
                                    y = Console.CursorTop;
                                    foreach (char c in opt_choices[index])
                                    {
                                        x = Console.CursorLeft;
                                        y = Console.CursorTop;
                                        set.Text_Color = "silver";
                                        font.Print_Char(x + 1, y + 1, c);
                                        font.Print_Char(x + 1, y, c);
                                        set.Text_Color = "black";
                                        font.Print_Char(x, y, c);
                                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                    }
                                }
                                if (i == 1)
                                {
                                    Console.SetCursorPosition(244, 32);
                                    x = Console.CursorLeft;
                                    y = Console.CursorTop;
                                    foreach (char c in opt_choices[index])
                                    {
                                        x = Console.CursorLeft;
                                        y = Console.CursorTop;
                                        set.Text_Color = "silver";
                                        font.Print_Char(x + 1, y + 1, c);
                                        font.Print_Char(x + 1, y, c);
                                        set.Text_Color = "grey";
                                        font.Print_Char(x, y, c);
                                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                    }
                                }
                            }
                            ConsoleKeyInfo key1 = Console.ReadKey(true);
                            if (key1.Key == ConsoleKey.UpArrow)
                            {
                                c_index0 = (c_index0 + opt_choices.Length - 1) % opt_choices.Length;
                                art.Print_WFM(2, 206, 1);
                            }
                            else if (key1.Key == ConsoleKey.DownArrow)
                            {
                                c_index0 = (c_index0 + 1) % opt_choices.Length;
                                art.Print_WFM(2, 206, 1);
                            }
                            else if (key1.Key == ConsoleKey.RightArrow && opt_choices[c_index0] == bordercolor[c_index1])
                            {
                                c_index1 = (c_index1 + bordercolor.Length - 1) % bordercolor.Length;
                                set.Border = bordercolor[c_index1].ToLower();
                                art.Print_WFM(2, 206, 1);
                                art.Change_BD();
                            }
                            else if (key1.Key == ConsoleKey.LeftArrow && opt_choices[c_index0] == bordercolor[c_index1])
                            {
                                c_index1 = (c_index1 + 1) % bordercolor.Length;
                                set.Border = bordercolor[c_index1].ToLower();
                                art.Print_WFM(2, 206, 1);
                                art.Change_BD();
                            }
                            else if (key1.Key == ConsoleKey.RightArrow && opt_choices[c_index0] == frametype[c_index2])
                            {
                                c_index2 = (c_index2 + frametype.Length - 1) % frametype.Length;
                                set.Frame = frametype[c_index2].ToLower();
                                art.Print_WFM(2, 206, 1);
                                art.Change_FM(2, 206, 1);
                                art.Change_FM(3, 2, 1);
                            }
                            else if (key1.Key == ConsoleKey.LeftArrow && opt_choices[c_index0] == frametype[c_index2])
                            {
                                c_index2 = (c_index2 + 1) % frametype.Length;
                                set.Frame = frametype[c_index2].ToLower();
                                art.Print_WFM(2, 206, 1);
                                art.Change_FM(2, 206, 1);
                                art.Change_FM(3, 2, 1);
                            }
                            else if (key1.Key == ConsoleKey.X)
                            {
                                test.InOptions = false;
                                Console.SetCursorPosition(205, 0);
                                x = Console.CursorLeft;
                                y = Console.CursorTop;
                                for (int i = 0; i <= 124; i++)
                                {
                                    Console.SetCursorPosition(x, y + i);
                                    Console.Write(new string(' ', 206));
                                }
                            }
                        }
                        break;
                    case "Exit":
                        if (test.Options)
                        {
                            test.Options = false;
                        }
                        test.InMenu = false;
                        test.NewGame = false;
                        test.Continue = false;
                        test.MainMenu = true;
                        test.AskInput = false;
                        break;
                }
            }
        }

    }
    public void Options()
    {
        int x, y, c_index1 = 0, c_index2 = 0, c_index0 = 0;
        test.InMenu = true;
        string[] bordercolor = { "Border3", "Border1", "Border2" };
        string[] frametype = { "Frame3", "Frame1", "Frame2" };
        test.InOptions = true;
        art.Print_FM(2, 2, 1);
        art.Print_BD();
        switch (set.Border)
        {
            case "border1":
                c_index1 = 1;
                break;
            case "border2":
                c_index1 = 2;
                break;
            default:
                c_index1 = 0;
                break;
        }
        switch (set.Frame)
        {
            case "frame1":
                c_index2 = 1;
                break;
            case "frame2":
                c_index2 = 2;
                break;
            default:
                c_index2 = 0;
                break;
        }
        art.Print_FM(2, 2, 1);
        while (test.InOptions)
        {
            string[] opt_choices = { bordercolor[c_index1], frametype[c_index2] };
            for (int i = 0; i < opt_choices.Length; i++)
            {
                int index = (c_index0 + i) % opt_choices.Length;
                if (i == 0)
                {
                    Console.SetCursorPosition(40, 15);
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    foreach (char c in opt_choices[index])
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = "silver";
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = "black";
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
                if (i == 1)
                {
                    Console.SetCursorPosition(40, 32);
                    x = Console.CursorLeft;
                    y = Console.CursorTop;
                    foreach (char c in opt_choices[index])
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = "silver";
                        font.Print_Char(x + 1, y + 1, c);
                        font.Print_Char(x + 1, y, c);
                        set.Text_Color = "grey";
                        font.Print_Char(x, y, c);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
            }
            ConsoleKeyInfo key1 = Console.ReadKey(true);
            if (key1.Key == ConsoleKey.UpArrow)
            {
                c_index0 = (c_index0 + opt_choices.Length - 1) % opt_choices.Length;
                art.Print_WFM(2, 2, 1);
            }
            else if (key1.Key == ConsoleKey.DownArrow)
            {
                c_index0 = (c_index0 + 1) % opt_choices.Length;
                art.Print_WFM(2, 2, 1);
            }
            else if (key1.Key == ConsoleKey.RightArrow && opt_choices[c_index0] == bordercolor[c_index1])
            {
                c_index1 = (c_index1 + bordercolor.Length - 1) % bordercolor.Length;
                set.Border = bordercolor[c_index1].ToLower();
                art.Print_WFM(2, 2, 1);
                art.Change_BD();
            }
            else if (key1.Key == ConsoleKey.LeftArrow && opt_choices[c_index0] == bordercolor[c_index1])
            {
                c_index1 = (c_index1 + 1) % bordercolor.Length;
                set.Border = bordercolor[c_index1].ToLower();
                art.Print_WFM(2, 2, 1);
                art.Change_BD();
            }
            else if (key1.Key == ConsoleKey.RightArrow && opt_choices[c_index0] == frametype[c_index2])
            {
                c_index2 = (c_index2 + frametype.Length - 1) % frametype.Length;
                set.Frame = frametype[c_index2].ToLower();
                art.Print_WFM(2, 2, 1);
                art.Change_FM(2, 2, 1);
            }
            else if (key1.Key == ConsoleKey.LeftArrow && opt_choices[c_index0] == frametype[c_index2])
            {
                c_index2 = (c_index2 + 1) % frametype.Length;
                set.Frame = frametype[c_index2].ToLower();
                art.Print_WFM(2, 2, 1);
                art.Change_FM(2, 2, 1);
            }
            else if (key1.Key == ConsoleKey.X)
            {
                test.InOptions = false;
                test.Options = false;
                test.MainMenu = true;
                Console.SetCursorPosition(1, 0);
                x = Console.CursorLeft;
                y = Console.CursorTop;
                for (int i = 0; i <= 124; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(new string(' ', 206));
                }
            }
        }
    }
    public void ConfirmExit()
    {
        ConsoleKeyInfo key;
        int c, d, c_yn = 1;
        string[] y_n = { "Yes", "No" };
        test.InChoices = true;
        c_yn = 1;
        art.Choices(2, 2, 1, 2); //564
        Console.SetCursorPosition(40, 15);
        c = Console.CursorLeft;
        d = Console.CursorTop;
        foreach (char f in "Confirm?")
        {
            c = Console.CursorLeft;
            d = Console.CursorTop;
            set.Text_Color = "silver";
            font.Print_Char(c + 1, d + 1, f);
            font.Print_Char(c + 1, d, f);
            set.Text_Color = "black";
            font.Print_Char(c, d, f);
            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
        }
        for (int p = 0; p < y_n.Length; p++)
        {
            if (c_yn == p)
            {
                Console.SetCursorPosition(40 + p * 60, 32);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in y_n[p])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "black";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
            else
            {
                Console.SetCursorPosition(40 + p * 60, 32);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in y_n[p])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "grey";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
        } //Print Yes and No
        test.AskInput = true;
        while (test.AskInput)
        {
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.SetCursorPosition(40 + c_yn * 60, 32);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in y_n[c_yn])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    set.Text_Color = "grey";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                if (c_yn > 0) c_yn--;
                else c_yn = y_n.Length - 1;
                Console.SetCursorPosition(40 + c_yn * 60, 32);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in y_n[c_yn])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    set.Text_Color = "black";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(40 + c_yn * 60, 32);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in y_n[c_yn])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    set.Text_Color = "grey";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                if (c_yn < y_n.Length - 1) c_yn++;
                else c_yn = 0;
                Console.SetCursorPosition(40 + c_yn * 60, 32);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in y_n[c_yn])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    set.Text_Color = "black";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
            else if (key.Key == ConsoleKey.Z)
            {
                switch (c_yn)
                {
                    case 0: //Yes
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    case 1: //No
                        test.Exit = false;
                        test.MainMenu = true;
                        test.AskInput = false;
                        break;
                }
                art.Erase_Choices(2, 2, 1, 2);
            }
            else if (key.Key == ConsoleKey.X)
            {
                test.Exit = false;
                test.MainMenu = true;
                test.AskInput = false;
                art.Erase_Choices(2, 2, 1, 2);
            }
        }
    }
    public void Choices(string[] choices, int linenum, int x, int y, int length) //Three choices
    {
        int current_index = 0;
        int m, n;
        test.InChoices = true;
        switch (choices.Length)
        {
            case 1:
                while (test.InChoices)
                {
                    for (int i = 0; i < choices.Length; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        int index = (current_index + i) % choices.Length;
                        if (i == 0)
                        {
                            Console.SetCursorPosition(x + 38, y + 14);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "black";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                    }
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Z)
                    {
                        test.Choice = 0;
                        test.InChoices = false;
                    }
                }
                break;
            case 2:
                while (test.InChoices)
                {
                    for (int i = 0; i < choices.Length; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        int index = (current_index + i) % choices.Length;
                        if (i == 0)
                        {
                            Console.SetCursorPosition(x + 38, y + 14);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "black";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 1)
                        {
                            Console.SetCursorPosition(x + 38, y + 31);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                    }
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        current_index = (current_index + choices.Length - 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        current_index = (current_index + 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.Z)
                    {
                        switch (current_index)
                        {
                            case 0: test.Choice = 0; break;
                            case 1: test.Choice = 1; break;
                        }
                        test.InChoices = false;
                    }
                }
                break;
            case 3:
                while (test.InChoices)
                {
                    for (int i = 0; i < choices.Length; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        int index = (current_index + i) % choices.Length;
                        if (i == 0)
                        {
                            Console.SetCursorPosition(x + 38, y + 14);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "black";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 1)
                        {
                            Console.SetCursorPosition(x + 38, y + 31);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 2)
                        {
                            Console.SetCursorPosition(x + 38, y + 48);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                    }
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        current_index = (current_index + choices.Length - 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        current_index = (current_index + 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.Z)
                    {
                        switch (current_index)
                        {
                            case 0: test.Choice = 0; break;
                            case 1: test.Choice = 1; break;
                            case 2: test.Choice = 2; break;
                        }
                        test.InChoices = false;
                    }
                }
                break;
            case 4:
                while (test.InChoices)
                {
                    for (int i = 0; i < choices.Length; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        int index = (current_index + i) % choices.Length;
                        if (i == 0)
                        {
                            Console.SetCursorPosition(x + 38, y + 14);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "black";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 1)
                        {
                            Console.SetCursorPosition(x + 38, y + 31);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 2)
                        {
                            Console.SetCursorPosition(x + 38, y + 48);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 3)
                        {
                            Console.SetCursorPosition(x + 38, y + 65);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                    }
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        current_index = (current_index + choices.Length - 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        current_index = (current_index + 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.Z)
                    {
                        switch (current_index)
                        {
                            case 0: test.Choice = 0; break;
                            case 1: test.Choice = 1; break;
                            case 2: test.Choice = 2; break;
                            case 3: test.Choice = 3; break;
                        }
                        test.InChoices = false;
                    }
                }
                break;
            case 5:
                while (test.InChoices)
                {
                    for (int i = 0; i < choices.Length; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        int index = (current_index + i) % choices.Length;
                        if (i == 0)
                        {
                            Console.SetCursorPosition(x + 38, y + 14);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "black";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 1)
                        {
                            Console.SetCursorPosition(x + 38, y + 31);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 2)
                        {
                            Console.SetCursorPosition(x + 38, y + 48);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 3)
                        {
                            Console.SetCursorPosition(x + 38, y + 65);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 4)
                        {
                            Console.SetCursorPosition(x + 38, y + 82);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                    }
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        current_index = (current_index + choices.Length - 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        current_index = (current_index + 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.Z)
                    {
                        switch (current_index)
                        {
                            case 0: test.Choice = 0; break;
                            case 1: test.Choice = 1; break;
                            case 2: test.Choice = 2; break;
                            case 3: test.Choice = 3; break;
                            case 4: test.Choice = 4; break;
                        }
                        test.InChoices = false;
                    }
                }
                break;
            case 6:
                while (test.InChoices)
                {
                    for (int i = 0; i < choices.Length; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        int index = (current_index + i) % choices.Length;
                        if (i == 0)
                        {
                            Console.SetCursorPosition(x + 38, y + 14);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "black";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 1)
                        {
                            Console.SetCursorPosition(x + 38, y + 31);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 2)
                        {
                            Console.SetCursorPosition(x + 38, y + 48);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 3)
                        {
                            Console.SetCursorPosition(x + 38, y + 65);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 4)
                        {
                            Console.SetCursorPosition(x + 38, y + 82);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                        else if (i == 5)
                        {
                            Console.SetCursorPosition(x + 38, y + 99);
                            m = Console.CursorLeft;
                            n = Console.CursorTop;
                            foreach (char c in choices[index])
                            {
                                m = Console.CursorLeft;
                                n = Console.CursorTop;
                                set.Text_Color = "silver";
                                font.Print_Char(m + 1, n + 1, c);
                                font.Print_Char(m + 1, n, c);
                                set.Text_Color = "grey";
                                font.Print_Char(m, n, c);
                                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                            }
                        }
                    }
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        current_index = (current_index + choices.Length - 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        current_index = (current_index + 1) % choices.Length;
                        art.Change_WC(linenum, x, y, length);
                    }
                    else if (key.Key == ConsoleKey.Z)
                    {
                        switch (current_index)
                        {
                            case 0: test.Choice = 0; break;
                            case 1: test.Choice = 1; break;
                            case 2: test.Choice = 2; break;
                            case 3: test.Choice = 3; break;
                            case 4: test.Choice = 4; break;
                            case 5: test.Choice = 5; break;
                        }
                        test.InChoices = false;
                    }
                }
                break;
        }
    }
    public void InputName()
    {
        int c_row = 0, c_col = 0, c, d, ctr = 0, x_val = 0, c_yn = 1;
        string[] row1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", " ", "1", "2", "3", " ", ".", ",", "“", "”" };
        string[] row2 = { "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "2", "4", "6", " ", "?", "!", "/", "\\" };
        string[] row3 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", " ", "7", "8", "9", " ", "+", "-", ">", "<" };
        string[] row4 = { "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " ", " ", "0", " ", " ", "@", "*", "#", "_" };
        string[] y_n = { "Yes", "No" };
        test.InChoices = true;
        art.Choices(4, 2, 1, 5);
        art.Choices(1, 2, 86, 5);
        if (test.AskFirstName)
        {
            test.FirstName = "";
            Console.SetCursorPosition(40, 100);
            c = Console.CursorLeft;
            d = Console.CursorTop;
            foreach (char f in "Enter firstname:")
            {
                c = Console.CursorLeft;
                d = Console.CursorTop;
                set.Text_Color = "silver";
                font.Print_Char(c + 1, d + 1, f);
                font.Print_Char(c + 1, d, f);
                set.Text_Color = "black";
                font.Print_Char(c, d, f);
                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
            }
        }
        else if (test.AskNickName)
        {
            test.NickName = "";
            Console.SetCursorPosition(40, 100);
            c = Console.CursorLeft;
            d = Console.CursorTop;
            foreach (char f in "Enter nickname:")
            {
                c = Console.CursorLeft;
                d = Console.CursorTop;
                set.Text_Color = "silver";
                font.Print_Char(c + 1, d + 1, f);
                font.Print_Char(c + 1, d, f);
                set.Text_Color = "black";
                font.Print_Char(c, d, f);
                Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
            }
        }
        for (int i = 0; i < row1.Length; i++) //row 1
        {
            if (c_row == 0 && c_col == i)
            {
                Console.SetCursorPosition(40 + i * 20, 15);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in row1[i])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    if (row1[i] == "." || row1[i] == ",")
                    {
                        c += 4;
                    }
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "black";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
            else
            {
                Console.SetCursorPosition(40 + i * 20, 15);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in row1[i])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    if (row1[i] == "." || row1[i] == ",")
                    {
                        c += 4;
                    }
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "grey";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
        }
        for (int i = 0; i < row2.Length; i++)
        {
            if (c_row == 1 && c_col == i)
            {
                Console.SetCursorPosition(40 + i * 20, 32);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in row2[i])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    if (row2[i] == "!")
                    {
                        c += 4;
                    }
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "black";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
            else
            {
                Console.SetCursorPosition(40 + i * 20, 32);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in row2[i])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    if (row2[i] == "!")
                    {
                        c += 4;
                    }
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "grey";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
        }
        for (int i = 0; i < row3.Length; i++)
        {
            if (c_row == 2 && c_col == i)
            {
                Console.SetCursorPosition(40 + i * 20, 49);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in row3[i])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    if (row3[i] == "i" || row3[i] == "l")
                    {
                        c += 4;
                    }
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "black";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
            else
            {
                Console.SetCursorPosition(40 + i * 20, 49);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in row3[i])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    if (row3[i] == "i" || row3[i] == "l")
                    {
                        c += 4;
                    }
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "grey";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
        }
        for (int i = 0; i < row4.Length; i++)
        {
            if (c_row == 3 && c_col == i)
            {
                Console.SetCursorPosition(40 + i * 20, 66);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in row4[i])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    if (row4[i] == "@" || row4[i] == "#")
                    {
                        c -= 2;
                    }
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "black";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
            else
            {
                Console.SetCursorPosition(40 + i * 20, 66);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in row4[i])
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    if (row4[i] == "@" || row4[i] == "#")
                    {
                        c -= 2;
                    }
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "grey";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
            }
        }
        while (test.InChoices)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                switch (c_row)
                {
                    case 0:
                        foreach (char f in row1[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row1[c_col] == "." || row1[c_col] == ",")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_col > 0) c_col--;
                        else c_col = row1.Length - 1;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row1[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row1[c_col] == "." || row1[c_col] == ",")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 1:
                        foreach (char f in row2[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row2[c_col] == "!")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_col > 0) c_col--;
                        else c_col = row2.Length - 1;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row2[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row2[c_col] == "!")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 2:
                        foreach (char f in row3[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row3[c_col] == "i" || row3[c_col] == "l")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_col > 0) c_col--;
                        else c_col = row3.Length - 1;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row3[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row3[c_col] == "i" || row3[c_col] == "l")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 3:
                        foreach (char f in row4[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row4[c_col] == "@" || row4[c_col] == "#")
                            {
                                c -= 2;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_col > 0) c_col--;
                        else c_col = row4.Length - 1;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row4[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row4[c_col] == "@" || row4[c_col] == "#")
                            {
                                c -= 2;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                }
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                switch (c_row)
                {
                    case 0:
                        foreach (char f in row1[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row1[c_col] == "." || row1[c_col] == ",")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_col < row1.Length - 1) c_col++;
                        else c_col = 0;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row1[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row1[c_col] == "." || row1[c_col] == ",")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 1:
                        foreach (char f in row2[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row2[c_col] == "!")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_col < row2.Length - 1) c_col++;
                        else c_col = 0;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row2[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row2[c_col] == "!")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 2:
                        foreach (char f in row3[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row3[c_col] == "i" || row3[c_col] == "l")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_col < row3.Length - 1) c_col++;
                        else c_col = 0;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row3[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row3[c_col] == "i" || row3[c_col] == "l")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 3:
                        foreach (char f in row4[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row4[c_col] == "@" || row4[c_col] == "#")
                            {
                                c -= 2;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_col < row4.Length - 1) c_col++;
                        else c_col = 0;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row4[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row4[c_col] == "@" || row4[c_col] == "#")
                            {
                                c -= 2;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                }
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                switch (c_row)
                {
                    case 0:
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        foreach (char f in row1[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row1[c_col] == "." || row1[c_col] == ",")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_row > 0) c_row--;
                        else c_row = 3;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row4[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row4[c_col] == "@" || row4[c_col] == "#")
                            {
                                c -= 2;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 1:
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        foreach (char f in row2[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row2[c_col] == "!")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_row > 0) c_row--;
                        else c_row = 3;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row1[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row1[c_col] == "." || row1[c_col] == ",")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 2:
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        foreach (char f in row3[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row3[c_col] == "i" || row3[c_col] == "l")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_row > 0) c_row--;
                        else c_row = 3;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row2[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row2[c_col] == "!")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 3:
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        foreach (char f in row4[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row4[c_col] == "@" || row4[c_col] == "#")
                            {
                                c -= 2;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_row > 0) c_row--;
                        else c_row = 3;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row3[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row3[c_col] == "i" || row3[c_col] == "l")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                switch (c_row)
                {
                    case 0:
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        foreach (char f in row1[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row1[c_col] == "." || row1[c_col] == ",")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_row < 3) c_row++;
                        else c_row = 0;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row2[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row2[c_col] == "!")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 1:
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        foreach (char f in row2[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row2[c_col] == "!")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_row < 3) c_row++;
                        else c_row = 0;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row3[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row3[c_col] == "i" || row3[c_col] == "l")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 2:
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        foreach (char f in row3[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row3[c_col] == "i" || row3[c_col] == "l")
                            {
                                c += 4;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_row < 3) c_row++;
                        else c_row = 0;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row4[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row4[c_col] == "@" || row4[c_col] == "#")
                            {
                                c -= 2;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                    case 3:
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        foreach (char f in row4[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row4[c_col] == "@" || row4[c_col] == "#")
                            {
                                c -= 2;
                            }
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_row < 3) c_row++;
                        else c_row = 0;
                        Console.SetCursorPosition(40 + c_col * 20, 15 + c_row * 17);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in row1[c_col])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            if (row1[c_col] == "." || row1[c_col] == ",")
                            {
                                c += 4;
                            }
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        break;
                }
            }
            else if (key.Key == ConsoleKey.Z)
            {
                if (test.AskFirstName)
                {
                    if (ctr < 7)
                    {
                        switch (c_row)
                        {
                            case 0:
                                test.FirstName += row1[c_col];
                                break;
                            case 1:
                                test.FirstName += row2[c_col];
                                break;
                            case 2:
                                test.FirstName += row3[c_col];
                                break;
                            case 3:
                                test.FirstName += row4[c_col];
                                break;
                        }
                        Console.SetCursorPosition(240 + x_val, 100);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        char last = test.FirstName[test.FirstName.Length - 1];

                        set.Text_Color = "silver";
                        font.Print_Char(c + 1, d + 1, last);
                        font.Print_Char(c + 1, d, last);
                        set.Text_Color = "black";
                        font.Print_Char(c, d, last);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        x_val = Console.CursorLeft - 240;
                        ctr++;
                    }
                    else
                    {
                        c_yn = 1;
                        art.Choices(2, 564, 1, 2);
                        Console.SetCursorPosition(602, 15);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in "Confirm?")
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            set.Text_Color = "silver";
                            font.Print_Char(c + 1, d + 1, f);
                            font.Print_Char(c + 1, d, f);
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        for (int p = 0; p < y_n.Length; p++)
                        {
                            if (c_yn == p)
                            {
                                Console.SetCursorPosition(602 + p * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[p])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "silver";
                                    font.Print_Char(c + 1, d + 1, f);
                                    font.Print_Char(c + 1, d, f);
                                    set.Text_Color = "black";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                            }
                            else
                            {
                                Console.SetCursorPosition(602 + p * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[p])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "silver";
                                    font.Print_Char(c + 1, d + 1, f);
                                    font.Print_Char(c + 1, d, f);
                                    set.Text_Color = "grey";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                            }
                        } //Print Yes and No
                        test.AskInput = true;
                        while (test.AskInput)
                        {
                            key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.LeftArrow)
                            {
                                Console.SetCursorPosition(602 + c_yn * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[c_yn])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "grey";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                                if (c_yn > 0) c_yn--;
                                else c_yn = y_n.Length - 1;
                                Console.SetCursorPosition(602 + c_yn * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[c_yn])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "black";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                            }
                            else if (key.Key == ConsoleKey.RightArrow)
                            {
                                Console.SetCursorPosition(602 + c_yn * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[c_yn])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "grey";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                                if (c_yn < y_n.Length - 1) c_yn++;
                                else c_yn = 0;
                                Console.SetCursorPosition(602 + c_yn * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[c_yn])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "black";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                            }
                            else if (key.Key == ConsoleKey.Z)
                            {
                                switch (c_yn)
                                {
                                    case 0:
                                        test.AskInput = false;
                                        test.AskFirstName = false;
                                        test.InChoices = false;
                                        art.Erase_Choices(4, 2, 1, 5);
                                        art.Erase_Choices(1, 2, 86, 5);
                                        break;
                                    case 1:
                                        test.AskInput = false;
                                        break;
                                }
                                art.Erase_Choices(2, 564, 1, 2);
                            }
                            else if (key.Key == ConsoleKey.X)
                            {
                                test.AskInput = false;
                                art.Erase_Choices(2, 564, 1, 2);
                            }
                        }
                    }
                }
                else if (test.AskNickName)
                {
                    if (ctr < 7)
                    {
                        switch (c_row)
                        {
                            case 0:
                                test.NickName += row1[c_col];
                                break;
                            case 1:
                                test.NickName += row2[c_col];
                                break;
                            case 2:
                                test.NickName += row3[c_col];
                                break;
                            case 3:
                                test.NickName += row4[c_col];
                                break;
                        }
                        Console.SetCursorPosition(240 + x_val, 100);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        char last = test.NickName[test.NickName.Length - 1];

                        set.Text_Color = "silver";
                        font.Print_Char(c + 1, d + 1, last);
                        font.Print_Char(c + 1, d, last);
                        set.Text_Color = "black";
                        font.Print_Char(c, d, last);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        x_val = Console.CursorLeft - 240;
                        ctr++;
                    }
                    else
                    {
                        c_yn = 1;
                        art.Choices(2, 564, 1, 2);
                        Console.SetCursorPosition(602, 15);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in "Confirm?")
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            set.Text_Color = "silver";
                            font.Print_Char(c + 1, d + 1, f);
                            font.Print_Char(c + 1, d, f);
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        for (int p = 0; p < y_n.Length; p++)
                        {
                            if (c_yn == p)
                            {
                                Console.SetCursorPosition(602 + p * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[p])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "silver";
                                    font.Print_Char(c + 1, d + 1, f);
                                    font.Print_Char(c + 1, d, f);
                                    set.Text_Color = "black";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                            }
                            else
                            {
                                Console.SetCursorPosition(602 + p * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[p])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "silver";
                                    font.Print_Char(c + 1, d + 1, f);
                                    font.Print_Char(c + 1, d, f);
                                    set.Text_Color = "grey";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                            }
                        } //Print Yes and No
                        test.AskInput = true;
                        while (test.AskInput)
                        {
                            key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.LeftArrow)
                            {
                                Console.SetCursorPosition(602 + c_yn * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[c_yn])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "grey";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                                if (c_yn > 0) c_yn--;
                                else c_yn = y_n.Length - 1;
                                Console.SetCursorPosition(602 + c_yn * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[c_yn])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "black";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                            }
                            else if (key.Key == ConsoleKey.RightArrow)
                            {
                                Console.SetCursorPosition(602 + c_yn * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[c_yn])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "grey";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                                if (c_yn < y_n.Length - 1) c_yn++;
                                else c_yn = 0;
                                Console.SetCursorPosition(602 + c_yn * 60, 32);
                                c = Console.CursorLeft;
                                d = Console.CursorTop;
                                foreach (char f in y_n[c_yn])
                                {
                                    c = Console.CursorLeft;
                                    d = Console.CursorTop;
                                    set.Text_Color = "black";
                                    font.Print_Char(c, d, f);
                                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                                }
                            }
                            else if (key.Key == ConsoleKey.Z)
                            {
                                switch (c_yn)
                                {
                                    case 0: //if yes
                                        test.AskInput = false;
                                        test.AskNickName = false;
                                        test.InChoices = false;
                                        art.Erase_Choices(4, 2, 1, 5);
                                        art.Erase_Choices(1, 2, 86, 5);
                                        break;
                                    case 1: //if no
                                        test.AskInput = false;
                                        break;
                                }
                                art.Erase_Choices(2, 564, 1, 2);
                            }
                            else if (key.Key == ConsoleKey.X)
                            {
                                test.AskInput = false;
                                art.Erase_Choices(2, 564, 1, 2);
                            }
                        }
                    }
                }
            }
            else if (key.Key == ConsoleKey.X)
            {
                if (test.AskFirstName)
                {
                    test.FirstName = "";
                }
                else if (test.AskNickName)
                {
                    test.NickName = "";
                }
                ctr = 0; x_val = 0;
                for (int i = -2; i <= 13; i++)
                {
                    Console.SetCursorPosition(240, 100 + i); AnsiConsole.Markup($"[white]██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████[/]");
                }
            }
            else if (key.Key == ConsoleKey.Enter && ctr > 0)
            {
                c_yn = 1;
                art.Choices(2, 564, 1, 2);
                Console.SetCursorPosition(602, 15);
                c = Console.CursorLeft;
                d = Console.CursorTop;
                foreach (char f in "Confirm?")
                {
                    c = Console.CursorLeft;
                    d = Console.CursorTop;
                    set.Text_Color = "silver";
                    font.Print_Char(c + 1, d + 1, f);
                    font.Print_Char(c + 1, d, f);
                    set.Text_Color = "black";
                    font.Print_Char(c, d, f);
                    Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                }
                for (int p = 0; p < y_n.Length; p++)
                {
                    if (c_yn == p)
                    {
                        Console.SetCursorPosition(602 + p * 60, 32);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in y_n[p])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            set.Text_Color = "silver";
                            font.Print_Char(c + 1, d + 1, f);
                            font.Print_Char(c + 1, d, f);
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(602 + p * 60, 32);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in y_n[p])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            set.Text_Color = "silver";
                            font.Print_Char(c + 1, d + 1, f);
                            font.Print_Char(c + 1, d, f);
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                    }
                } //Print Yes and No
                test.AskInput = true;
                while (test.AskInput)
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(602 + c_yn * 60, 32);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in y_n[c_yn])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_yn > 0) c_yn--;
                        else c_yn = y_n.Length - 1;
                        Console.SetCursorPosition(602 + c_yn * 60, 32);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in y_n[c_yn])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        Console.SetCursorPosition(602 + c_yn * 60, 32);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in y_n[c_yn])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            set.Text_Color = "grey";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                        if (c_yn < y_n.Length - 1) c_yn++;
                        else c_yn = 0;
                        Console.SetCursorPosition(602 + c_yn * 60, 32);
                        c = Console.CursorLeft;
                        d = Console.CursorTop;
                        foreach (char f in y_n[c_yn])
                        {
                            c = Console.CursorLeft;
                            d = Console.CursorTop;
                            set.Text_Color = "black";
                            font.Print_Char(c, d, f);
                            Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                        }
                    }
                    else if (key.Key == ConsoleKey.Z)
                    {
                        switch (c_yn)
                        {
                            case 0: //if yes
                                test.AskInput = false;
                                test.AskNickName = false;
                                test.InChoices = false;
                                art.Erase_Choices(4, 2, 1, 5);
                                art.Erase_Choices(1, 2, 86, 5);
                                break;
                            case 1: //if no
                                test.AskInput = false;
                                break;
                        }
                        art.Erase_Choices(2, 564, 1, 2);
                    }
                    else if (key.Key == ConsoleKey.X)
                    {
                        test.AskInput = false;
                        art.Erase_Choices(2, 564, 1, 2);
                    }
                }
            }
        }
    }
}
public class WindowSizeException : Exception
{
    public WindowSizeException(string message) : base(message) { }
}