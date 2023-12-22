public class _1_Boolean__Values
{
    private bool ingame;
    private bool inmenu;
    private bool inchoices;
    private bool inoptions;
    private bool start_menu;
    private bool main_menu;
    private bool new_game;
    private bool continue_;
    private bool options;
    private bool delete;
    private bool exit;
    private bool intro;
    private bool ask_input;
    private bool ask_firstname;
    private bool ask_nickname;
    private bool ask_gender;
    private bool once;

    public _1_Boolean__Values()
    {
        ingame = true;
        inmenu = false;
        inchoices = false;
        inoptions = false;
        start_menu = true;
        main_menu = false;
        new_game = false;
        continue_ = false;
        options = false;
        delete = false;
        exit = false;
        intro = false;
        ask_input = true;
        ask_firstname = false;
        ask_nickname = false;
        ask_gender = false;
        once = false;
    }
    public int Choice = 0;
    public int temp_currentindex = 0;

    public bool InGame { get { return ingame; } set { ingame = value; } }
    public bool InMenu { get { return inmenu; } set { inmenu = value; } }
    public bool InChoices { get { return inchoices; } set { inchoices = value; } }
    public bool InOptions { get { return inoptions; } set { inoptions = value; } }
    public bool StartMenu { get { return start_menu; } set { start_menu = value; } }
    public bool MainMenu { get { return main_menu; } set { main_menu = value; } }
    public bool NewGame { get { return new_game; } set { new_game = value; } }
    public bool Continue { get { return continue_; } set { continue_ = value; } }
    public bool Options { get { return options; } set { options = value; } }
    public bool Delete { get { return delete; } set { delete = value; } }
    public bool Exit { get { return exit; } set { exit = value; } }
    public bool Intro { get { return intro; } set { intro = value; } }
    public bool AskInput { get { return ask_input; } set { ask_input = value; } }
    public bool AskFirstName { get { return ask_firstname; } set { ask_firstname = value; } }
    public bool AskNickName { get { return ask_nickname; } set { ask_nickname = value; } }
    public bool AskGender { get { return ask_gender; } set { ask_gender = value; } }
    public bool Once { get { return once; } set { once = value; } }

    //Progress

    public string costume = "0";

    public string FirstName = "Alexei"; //All default
    public string NickName = "Alyosha";
    public string Gender = "Male";
    public string GameID = "1000";
    public string Route = "Chapter 1.0";
    public int SaveSlot = 1;
    public string Pronoun1
    {
        get
        {
            if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return "He";
            }
            else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                return "She";
            }
            else
            {
                return "They";
            }
        }
    }
    public string Pronoun1_1
    {
        get
        {
            if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return "he";
            }
            else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                return "she";
            }
            else
            {
                return "they";
            }
        }
    }
    public string Pronoun2
    {
        get
        {
            if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return "His";
            }
            else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                return "Her";
            }
            else
            {
                return "Their";
            }
        }
    }
    public string Pronoun2_1
    {
        get
        {
            if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return "his";
            }
            else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                return "her";
            }
            else
            {
                return "their";
            }
        }
    }
    public string Pronoun3
    {
        get
        {
            if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return "Him";
            }
            else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                return "Her";
            }
            else
            {
                return "Them";
            }
        }
    }
    public string Pronoun3_1
    {
        get
        {
            if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return "him";
            }
            else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                return "her";
            }
            else
            {
                return "them";
            }
        }
    }
    public string Pronoun4
    {
        get
        {
            if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return "Himself";
            }
            else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                return "Herself";
            }
            else
            {
                return "Themself";
            }
        }
    }
    public string Pronoun4_1
    {
        get
        {
            if (Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return "himself";
            }
            else if (Gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                return "herself";
            }
            else
            {
                return "themself";
            }
        }
    }
}