public class SaveData //This is for the continue and does not apply for the MainMenu and the NewGame
{
    public int SaveSlot { get; set; }
    public string GameID { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string NickName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Route { get; set; } = string.Empty;
    public string Frame { get; set; } = string.Empty;
    public string Border { get; set; } = string.Empty;
}

public class SaveFileManager
{
    private List<SaveData> Data { get; set; }
    public SaveFileManager()
    {
        Data = new List<SaveData>();
    }
    public int GetNumSave()
    {
        string directoryPath = @"C:\Users\Josh Joaquin\Desktop\Coding\Russian Roulette\SaveSlot";
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        string[] files = Directory.GetFiles(directoryPath, "*.txt");
        return files.Length;
    }
    public void NewSaveFile(int SaveSlot, string GameID, string FirstName, string NickName, string Gender, string Route, string Frame, string Border)
    {
        string directoryPath = @"C:\Users\Josh Joaquin\Desktop\Coding\Russian Roulette\SaveSlot";
        string filePath = Path.Combine(directoryPath, $"{SaveSlot}.txt");
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        string fileContent = $"SaveSlot: {SaveSlot}\nGameID: {GameID}\nFirst Name: {FirstName}\nNickname: {NickName}\nPronouns: {Gender}\nRoute: {Route}\nFrame: {Frame}\nBorder: {Border}";
        File.WriteAllText(filePath, fileContent);
        // Add data to the Data list
        SaveData newData = new SaveData
        {
            SaveSlot = SaveSlot,
            GameID = GameID,
            FirstName = FirstName,
            NickName = NickName,
            Gender = Gender,
            Route = Route,
            Frame = Frame,
            Border = Border
        };
        Data.Add(newData);
    }
    public List<SaveData> GetAllSaveData()
    {
        return Data;
    }
    public void LoadAllSaveData()
    {
        string directoryPath = @"C:\Users\Josh Joaquin\Desktop\Coding\Russian Roulette\SaveSlot";
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        string[] files = Directory.GetFiles(directoryPath, "*.txt");
        foreach (string filePath in files)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 8)
            {
                SaveData data = new SaveData();
                data.SaveSlot = GetSaveSlotFromFileName(filePath); // Extract SaveSlot from the file name
                data.GameID = GetValueFromLine(lines[1], "GameID");
                data.FirstName = GetValueFromLine(lines[2], "First Name");
                data.NickName = GetValueFromLine(lines[3], "Nickname");
                data.Gender = GetValueFromLine(lines[4], "Pronouns");
                data.Route = GetValueFromLine(lines[5], "Route");
                data.Frame = GetValueFromLine(lines[6], "Frame");
                data.Border = GetValueFromLine(lines[7], "Border");
                Data.Add(data);
            }
            else
            {
                Console.WriteLine($"Save file {filePath} doesn't contain enough lines.");
            }
        }
    }
    public int GetSaveSlotFromFileName(string filePath)
    {
        string fileName = Path.GetFileNameWithoutExtension(filePath);
        int saveSlot;
        if (int.TryParse(fileName, out saveSlot))
        {
            return saveSlot;
        }
        return -1; 
    }
    public SaveData GetDataFromSaveFile(int SaveSlot)
    {
        string directoryPath = @"C:\Users\Josh Joaquin\Desktop\Coding\Russian Roulette\SaveSlot";
        string filePath = Path.Combine(directoryPath, $"{SaveSlot}.txt");

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length >= 8)
            {
                SaveData data = new SaveData();
                data.SaveSlot = SaveSlot;
                data.GameID = GetValueFromLine(lines[1], "GameID");
                data.FirstName = GetValueFromLine(lines[2], "First Name");
                data.NickName = GetValueFromLine(lines[3], "Nickname");
                data.Gender = GetValueFromLine(lines[4], "Pronouns");
                data.Route = GetValueFromLine(lines[5], "Route");
                data.Frame = GetValueFromLine(lines[6], "Frame");
                data.Border = GetValueFromLine(lines[7], "Border");

                Data.Add(data);
                return data;
            }
        }
        return new SaveData(); ;
    }
    private string GetValueFromLine(string line, string key)
    {
        string[] parts = line.Split(':');
        if (parts.Length >= 2)
        {
            return parts[1].Trim();
        }
        else
        {
            return string.Empty;
        }
    }
    public int GetLowestAvailableSaveSlot()
    {
        string directoryPath = @"C:\Users\Josh Joaquin\Desktop\Coding\Russian Roulette\SaveSlot";
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        string[] files = Directory.GetFiles(directoryPath, "*.txt");
        List<int> existingSaveSlots = new List<int>();
        foreach (string filePath in files)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            if (int.TryParse(fileName, out int saveSlot))
            {
                existingSaveSlots.Add(saveSlot);
            }
        }
        int lowestAvailableSlot = 1;
        while (existingSaveSlots.Contains(lowestAvailableSlot))
        {
            lowestAvailableSlot++;
        }
        return lowestAvailableSlot;
    }
    public void UpdateSaveFile(int SaveSlot, string Route, string Frame, string Border)
    {
        string directoryPath = @"C:\Users\Josh Joaquin\Desktop\Coding\Russian Roulette\SaveSlot";
        string filePath = Path.Combine(directoryPath, $"{SaveSlot}.txt");

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            lines[5] = $"Route: {Route}";
            lines[6] = $"Frame: {Frame}";
            lines[7] = $"Border: {Border}";
            File.WriteAllLines(filePath, lines);
            SaveData? existingData = Data.Find(data => data.SaveSlot == SaveSlot);
            if (existingData != null)
            {
                existingData.Route = Route;
                existingData.Frame = Frame;
                existingData.Border = Border;
            }
            else
            {
                SaveData updatedData = GetDataFromSaveFile(SaveSlot);
                if (updatedData != null)
                {
                    Data.Add(updatedData);
                }
            }
        }
    }
    public void DeleteSaveFile(int SaveSlot)
    {
        string directoryPath = @"C:\Users\Josh Joaquin\Desktop\Coding\Russian Roulette\SaveSlot";
        string filePath = Path.Combine(directoryPath, $"{SaveSlot}.txt");

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Data.RemoveAll(data => data.SaveSlot == SaveSlot);
        }
        else
        {
            Console.WriteLine($"Save file {SaveSlot}.txt does not exist.");
        }
    }
}