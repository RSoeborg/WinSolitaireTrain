using Alturos.Yolo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSolitaireTrain
{
    public class AITrainer
    {
        public readonly string[] names;
        readonly string fileDir = "solitaire_images";

        public AITrainer(string[] names)
        {
            this.names = names.Select(name => name
                    .Replace("å", "aa")
                    .Replace("æ", "ae")
                    .Replace("ø", "oe")
                    .Replace(" ", "_")).ToArray();

            if (!File.Exists($"trainfiles/{fileDir}.cfg") || !File.Exists($"trainfiles/{fileDir}.weights") || !File.Exists($"trainfiles/{fileDir}.names"))
            {
                PrepareFiles(fileDir);
            }
        }

        public void BeginTraining()
        {
            File.WriteAllText($"darknet/{fileDir}.cfg", File.ReadAllText($"darknet/{fileDir}.cfg").Replace("NUMBER", names.Count().ToString()).Replace("FILTERNUM", ((names.Count() + 5) * 3).ToString()));
            File.WriteAllText($"darknet/{fileDir}.cfg", File.ReadAllText($"darknet/{fileDir}.cfg").Replace("batch=1", "batch=64").Replace("subdivisions=1", "subdivisions=8"));
            File.WriteAllText($"darknet/data/{fileDir}.data", File.ReadAllText($"darknet/data/{fileDir}.data").Replace("NUMBER", names.Count().ToString()).Replace("GAME", fileDir));
            File.WriteAllText($"darknet/{fileDir}.cmd", File.ReadAllText($"darknet/{fileDir}.cmd").Replace("GAME", fileDir));
            File.WriteAllText($"darknet/{fileDir}_trainmore.cmd", File.ReadAllText($"darknet/{fileDir}_trainmore.cmd").Replace("GAME", fileDir));
            File.WriteAllText($"darknet/data/{fileDir}.names", string.Join("\n", names));

            FileInfo[] Files = new DirectoryInfo(Application.StartupPath + @"\darknet\data\img").GetFiles($"{fileDir}*.png"); //Getting Text files
            string PathOfImg = "";
            foreach (FileInfo file in Files)
            {
                PathOfImg += $"data/img/{file.Name}\r\n";
            }
            File.WriteAllText($"darknet/data/{fileDir}.txt", PathOfImg);

            if (File.Exists($"trainfiles/{fileDir}.weights"))
            {
                File.Copy($"trainfiles/{fileDir}.weights", $"darknet/{fileDir}.weights", true);
                Process.Start("cmd", @"/C cd " + Application.StartupPath + $"/darknet/ & {fileDir}_trainmore.cmd");
            }
            else Process.Start("cmd", @"/C cd " + Application.StartupPath + $"/darknet/ & {fileDir}.cmd");

        }

        public void Save(Bitmap bitmap, Card[] cards)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var card in cards)
            {
                float relative_center_x = ((float)card.Bounds.X + card.Bounds.Width / 2) / bitmap.Width;
                float relative_center_y = ((float)card.Bounds.Y + card.Bounds.Height / 2) / bitmap.Height;
                float relative_width = (float)card.Bounds.Width / bitmap.Width;
                float relative_height = (float)card.Bounds.Height / bitmap.Height;

                builder.AppendLine($"{card.Type} {relative_center_x} {relative_center_y} {relative_width} {relative_height}".Replace(",", "."));
            }

            int rand = new Random().Next(5000, 999999);
            bitmap.Save($"darknet/data/img/{fileDir}{rand}.png", System.Drawing.Imaging.ImageFormat.Png);
            File.WriteAllText($"darknet/data/img/{fileDir}{rand}.txt", builder.ToString());
            
            Console.Beep();
        }

        private void PrepareFiles(string fileDir)
        {
            try
            {
                File.Copy("defaultfiles/default_trainmore.cmd", $"darknet/{fileDir}_trainmore.cmd", true);
                if (File.Exists($"trainfiles/{fileDir}.cfg")) File.Copy($"trainfiles/{fileDir}.cfg", $"darknet/{fileDir}.cfg", true);
                else File.Copy("defaultfiles/default.cfg", $"darknet/{fileDir}.cfg", true);

                File.Copy("defaultfiles/default.conv.15", $"darknet/{fileDir}.conv.15", true);
                File.Copy("defaultfiles/default.data", $"darknet/data/{fileDir}.data", true);

                if (File.Exists($"trainfiles/{fileDir}.names")) File.Copy($"trainfiles/{fileDir}.names", $"darknet/{fileDir}.names", true);
                else File.Copy("defaultfiles/default.names", $"darknet/data/{fileDir}.names", true);

                File.Copy("defaultfiles/default.txt", $"darknet/data/{fileDir}.txt", true);
                File.Copy("defaultfiles/default.cmd", $"darknet/{fileDir}.cmd", true);
            }
            catch (DirectoryNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show($"Looks like you are missing the mainfiles! Do you want to download them?", "Mainfiles missing", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    System.Diagnostics.Process.Start("https://mega.nz/#F!e5FUnQRS!vpVjMjmeNnU0lHUWieOR4A");
                Process.GetCurrentProcess().Kill();
            }
        }
    }        
}
