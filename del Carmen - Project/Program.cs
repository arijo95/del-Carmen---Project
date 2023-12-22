namespace del_Carmen___Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            _1_Boolean__Values test = new _1_Boolean__Values();
            _7_Settings set = new _7_Settings();
            SaveFileManager savefile = new SaveFileManager();
            SaveData data = new SaveData();
            _42_Game_Script script = new _42_Game_Script(test, set);
            _22_Font font = new _22_Font(test, set);
            _52_Sprites art = new _52_Sprites(test, set);
            _8_Ease ease = new _8_Ease(test, set, script);
            _3_Screen_Display screenDisplay = new _3_Screen_Display(test, set, ease, script, savefile, data);
            _6_Printing print = new _6_Printing(test, script, set, font, art);
            test.AskInput = true;
            while (test.AskInput)
            {
                try
                {
                    Console.WriteLine("Adjust the window size please!");
                    int requiredWidth = 798;
                    int requiredHeight = 180;
                    Console.ReadKey(intercept: true);
                    CheckWindowSize(requiredWidth, requiredHeight);
                    test.AskInput = false;
                    Console.Clear();
                    Console.SetCursorPosition(20, 142);
                    int x = Console.CursorLeft;
                    int y = Console.CursorTop;
                    set.FG_Color = "white";
                    foreach (char f in "Console window size is acceptable.")
                    {
                        x = Console.CursorLeft;
                        y = Console.CursorTop;
                        set.Text_Color = "#ccb48a";
                        font.Print_Char(x + 1, y + 1, f);
                        font.Print_Char(x + 1, y, f);
                        set.Text_Color = "#FFE1AD";
                        font.Print_Char(x, y, f);
                        Console.SetCursorPosition(Console.CursorLeft + 2, Console.CursorTop - 10);
                    }
                }
                catch (WindowSizeException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            Console.ReadKey(intercept: true);
            while (test.InGame)
            {
                screenDisplay.Disp_StartMenu();
            }
        }
        public static void CheckWindowSize(int x, int y)
        {
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;

            if (consoleWidth < x || consoleHeight < y)
            {
                throw new WindowSizeException($"Console window size should be at least {x}x{y}. Current window size is {consoleWidth}x{consoleHeight}");
            }
        }
    }
}