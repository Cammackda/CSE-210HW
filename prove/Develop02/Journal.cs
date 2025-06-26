using System.Security.Cryptography;

namespace JournalEntry
{

    public class Journal
    {
        public List<Entry> Entries { get; private set; } = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            Entries.Add(entry);
        }

        public void DisplayEntries()
        {
            if (Entries.Count == 0)
            {
                Console.WriteLine("No journal entries yet.");
                return;
            }

            foreach (Entry entry in Entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {

                foreach (Entry entry in Entries)
                {
                    writer.WriteLine(entry.Date);
                    writer.WriteLine(entry.Prompt);
                    writer.WriteLine(entry.Response);
                    writer.WriteLine();
                }
            }

            Console.WriteLine($"Journal saved to {filename}");
        }
        public void LoadFromFile(string filename)
        {
            {
                Entries.Clear();

                if (!File.Exists(filename))
                {
                    Console.WriteLine("No file as is Detected.");
                    return;
                }

                string[] lines = File.ReadAllLines(filename);

                for (int i = 0; i < lines.Length; i += 4)
                {
                    if (i + 2 < lines.Length)
                    {
                        string date = lines[i];
                        string prompt = lines[i + 1];
                        string response = lines[i + 2];

                        Entries.Add(new Entry
                        {
                            Date = date,
                            Prompt = prompt,
                            Response = response
                        });
                    }
                }

                Console.WriteLine($"Journal loaded from {filename}.");
            }
        }
    }
}

