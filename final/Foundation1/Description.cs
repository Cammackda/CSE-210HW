using System.Security.Cryptography;
using ProductReview;

namespace DescriptionInput
{

    public class Description
    {
        public List<Review> Reviews { get; private set; } = new List<Review>();

        public void AddEntry(Review review)
        {
            Reviews.Add(review);
        }

        public void DisplayEntries()
        {
            if (Reviews.Count == 0)
            {
                Console.WriteLine("No product descriptions made yet.");
                return;
            }

            foreach (Review review in Reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {

                foreach (Review review in Reviews)
                {
                    writer.WriteLine(review.Date);
                    writer.WriteLine(review.Prompt);
                    writer.WriteLine(review.Response);
                    writer.WriteLine();
                }
            }

            Console.WriteLine($"Product Review/Description saved to {filename}");
        }
        public void LoadFromFile(string filename)
        {
            {
                Reviews.Clear();

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

                        Reviews.Add(new Review
                        {
                            Date = date,
                            Prompt = prompt,
                            Response = response
                        });
                    }
                }

                Console.WriteLine($"Product Review loaded from {filename}.");
            }
        }
    }
}

