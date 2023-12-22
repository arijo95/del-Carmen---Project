public class _7_Settings
{
    private string bg_color; //will be edited???
    private string fg_color; //can be edited
    private string sd_Color; //can be edited
    private string text_color; //temporary holder
    private string border;
    private string frame;
    private string spectrum;
    private int delay;
    public _7_Settings()
    {
        bg_color = "White";
        fg_color = "black";
        sd_Color = "silver";
        text_color = "black";
        border = "border3";
        frame = "frame2";
        spectrum = "Default";
        delay = 0;
    }

    public string BG_Color { get { return bg_color; } set { bg_color = value; } }
    public string FG_Color { get { return fg_color; } set { fg_color = value; } }
    public string SD_Color { get { return sd_Color; } set { sd_Color = value; } }
    public string Text_Color { get { return text_color; } set { text_color = value; } }
    public string Border { get { return border; } set { border = value; } }
    public string Frame { get { return frame; } set { frame = value; } }
    public string Spectrum
    {
        get { return spectrum; }
        set
        {
            switch (value)
            {
                case "1":
                    spectrum = "#cbebe4";
                    break;
                case "2":
                    spectrum = "#b6d3cd";
                    break;
                case "3":
                    spectrum = "#a2bcb6";
                    break;
                case "4":
                    spectrum = "#8ea49f";
                    break;
                case "5":
                    spectrum = "#798d88";
                    break;
                case "6":
                    spectrum = "#657572";
                    break;
                case "7":
                    spectrum = "#515e5b";
                    break;
                case "8":
                    spectrum = "#3c4644";
                    break;
                case "9":
                    spectrum = "#282f2d";
                    break;
                case "10":
                    spectrum = "#141716";
                    break;
                case "11":
                    spectrum = "#000000";
                    break;
                case "12":
                    spectrum = "#000000";
                    break;
                default:
                    spectrum = "#000000";
                    break;
            }
        }
    }
    public int Delay { get { return delay; } set { delay = value; } }
}