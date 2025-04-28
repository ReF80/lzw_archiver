using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LWZ
{
    public partial class Form1 : Form
    {
        private string inputFile;
        private const string outputFile = @"C:\Users\denis\OneDrive\Рабочий стол\LZW Folder\output.lzw";
        private const string decompressedFile = @"C:\Users\denis\OneDrive\Рабочий стол\LZW Folder\decompress.txt";
        private string readStringInputFile;
        List<int> readStringOutputFile = new List<int>();
        List<int> compressed = new List<int>();
        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = openFileDialog.FileName;
                messegeLabel.Text = "Выбран файл: " + inputFile;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (inputFile == null || !inputFile.EndsWith(".txt"))
            {
                messegeLabel.Text = "Неверный формат или файл не выбран. Повторите попыту.";
                return;
            }
            readStringInputFile = File.ReadAllText(inputFile);
            Console.WriteLine(readStringInputFile);
            // build the dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < 256; i++)
                dictionary.Add(((char)i).ToString(), i);

            string w = string.Empty;
            compressed = new List<int>();

            foreach (char c in readStringInputFile)
            {
                string wc = w + c;
                if (dictionary.ContainsKey(wc))
                {
                    w = wc;
                }
                else
                {
                    // write w to output
                    compressed.Add(dictionary[w]);
                    // wc is a new sequence; add it to the dictionary
                    dictionary.Add(wc, dictionary.Count);
                    w = c.ToString();
                }
            }

            // write remaining output if necessary
            if (!string.IsNullOrEmpty(w))
                compressed.Add(dictionary[w]);

            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Create)))
            {
                foreach (int code in compressed)
                {
                    writer.Write(code);
                }
            }
            messegeLabel.Text = "Сжатие прошло успешно!";
            foreach (var a in compressed)
            {
                Console.WriteLine(a.ToString());
            }
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            if (inputFile == null || !inputFile.EndsWith(".lzw"))
            {
                messegeLabel.Text = "Неверный формат или файл не выбран. Повторите попыту.";
                return;
            }
            using (BinaryReader reader = new BinaryReader(File.Open(inputFile, FileMode.Open), Encoding.ASCII))
            {
                while (reader.PeekChar() > -1)
                {
                    int v = reader.ReadInt32();
                    readStringOutputFile.Add(v);
                }
            }

            foreach (var b in readStringOutputFile)
            {
                Console.WriteLine($"{b}");
            }


                // build the dictionary
                Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < 256; i++)
                dictionary.Add(i, ((char)i).ToString());
            

            string w = dictionary[readStringOutputFile[0]];
            readStringOutputFile.RemoveAt(0);
            StringBuilder decompressed = new StringBuilder(w);

            foreach (int k in readStringOutputFile)
            {
                string entry = null;
                if (dictionary.ContainsKey(k))
                    entry = dictionary[k];
                else if (k == dictionary.Count)
                    entry = w + w[0];

                decompressed.Append(entry);

                // new sequence; add it to the dictionary
                dictionary.Add(dictionary.Count, w + entry[0]);

                w = entry;
            }
            File.WriteAllText(decompressedFile, decompressed.ToString());
            messegeLabel.Text = "Разархивирование прошло успешно!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            inputFile = null;
            messegeLabel.Text = "Выберите файл";
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
