using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace serial_test
{
    internal class Csv_file_writer
    {
        public string folder_path;
        public string file_name;
        private string author;

        public bool check_state = false;

        private string[] titles = new string[] {
            "rolik_weight",
            "total_weight",
            "unit_gram",
            "meter",
            "result",
            "hostname",
            "datetime"};

        public Csv_file_writer(string folder_path, string file_name, string author)
        {
            this.folder_path = folder_path+ @"\";
            this.file_name = file_name;
            this.author = author;

            this.create_csv();
        }

        public bool create_csv()
        {
            DirectoryInfo dir = new DirectoryInfo(this.folder_path);
            FileInfo[] Files = dir.GetFiles(this.file_name);

            if (Files.Length <= 0)
            {
                this.check_state = true;

                File.WriteAllText(this.folder_path + this.file_name,
                    this.titles[0]
                    + "," + this.titles[1]
                    + "," + this.titles[2]
                    + "," + this.titles[3]
                    + "," + this.titles[4]
                    + "," + this.titles[5]
                    + "," + this.titles[6]);
            }

            return this.check_state;
        }

        public bool add_row(string r, string k, string b, string m, string result)
        {
            // Not: veri girisi sirasinda float degerlerde bulunan virgul, nokta ile degistirilmelidir.
            // csv icerisinde virgul ile tanimlanacak degerler problem cikartir.
            bool state = false;

            File.AppendAllText(this.folder_path + this.file_name,
                    '\n'+ r.Replace(',', '.')
                    + "," + k.Replace(',', '.')
                    + "," + b.Replace(',', '.')
                    + "," + m.Replace(',', '.')
                    + "," + result.Replace(',', '.')
                    + "," + this.author
                    + "," + DateTime.Now);

            return state;
        }
    }
}
