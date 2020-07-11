using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PicSorter
{
    class Helpers
    {
        public static void MoveImages(string[] AllFilePaths, string SortMethod, string DirPath)
        {
            Dictionary<string, List<string>> PicList = new Dictionary<string, List<string>>();
            if (SortMethod == "Day")
            {
                PicList = GroupPicturesByDay(AllFilePaths);
            }
            else if (SortMethod == "Month")
            {
                PicList = GroupPicturesByMonth(AllFilePaths);
            }
            
            Parallel.ForEach(PicList, (x) =>
            { 
                DirectoryInfo directoryInfo = Directory.CreateDirectory(DirPath + @"\" + x.Key);
                foreach (string img in x.Value)
                {
                    try
                    {
                        string fileName = Path.GetFileName(img);
                        File.Move(img, DirPath + @"\" + x.Key + @"\" + fileName);
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine($"Exception thrown on file: {img}");
                    }
                }
            });
        }


        public static Dictionary<string, List<string>> GroupPicturesByDay(string[] AllFilePaths)
        {
            DateTime? DateTaken;
            Dictionary<string, List<string>> Results = new Dictionary<string, List<string>>();
            

            foreach (string filePath in AllFilePaths)
            {
                DateTaken = ProcessImage(filePath);
                if (DateTaken != null)
                {
                    string GroupByTime = $"{DateTaken.Value.Year.ToString()}-{DateTaken.Value.Month.ToString()}-{DateTaken.Value.Day.ToString()}";
                    //Check if Date already exists as key
                    if (Results.ContainsKey(GroupByTime))
                    {
                        //Add filePath to existing list
                        Results[GroupByTime].Add(filePath);
                    }
                    else
                    {
                        Results.Add(key: GroupByTime, value: new List<string> { filePath });
                    }
                }
            }
            return Results;
        }
        public static Dictionary<string, List<string>> GroupPicturesByMonth(string[] AllFilePaths)
        {
            DateTime? DateTaken;
            Dictionary<string, List<string>> Results = new Dictionary<string, List<string>>();

            foreach (string filePath in AllFilePaths)
            {
                DateTaken = ProcessImage(filePath);
                if (DateTaken != null)
                {
                    string GroupByTime = DateTaken.Value.Year.ToString() + "-" + DateTaken.Value.Month.ToString();
                    //Check if Date already exists as key
                    if (Results.ContainsKey(GroupByTime))
                    {
                        //Add filePath to existing list
                        Results[GroupByTime].Add(filePath);
                    }
                    else
                    {
                        Results.Add(key: GroupByTime, value: new List<string> { filePath });
                    }
                }
            }
            return Results;
        }

        public static DateTime? ProcessImage(string filePath)
        {
            try
            {
                string extension = Path.GetExtension(filePath);
                if (extension != ".JPG" && extension != ".BMP" && extension != ".PNG")
                {
                    Console.WriteLine($"{filePath} is not a supported image format. File has been skipped");
                    return null;
                }

                // Create an Image object.
                using (Image image = new Bitmap(filePath))
                {

                    // Get the PropertyItems property from image.
                    PropertyItem[] propItems = image.PropertyItems;


                    Dictionary<string, string> ImgProperties = new Dictionary<string, string>();
                    System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                    foreach (PropertyItem propItem in propItems)
                    {
                        ImgProperties.Add(key: $"0x{propItem.Id.ToString("x")}", value: encoding.GetString(propItem.Value));
                    }

                    string dateTaken = ImgProperties["0x132"];
                    DateTime DateTaken = Helpers.ParseImageTime(dateTaken);
                    string Make = ImgProperties["0x10f"];
                    string Model = ImgProperties["0x110"];

                    return DateTaken;
                }
            }
            catch
            {
                Console.WriteLine($"An error occurred attempting to parse {filePath}. File has been skipped.");
                return null;
            }
        }
        public static DateTime ParseImageTime(string dateTaken)
        {
            int year = int.Parse(dateTaken.Substring(0, 4));
            int month = int.Parse(dateTaken.Substring(5, 2));
            int day = int.Parse(dateTaken.Substring(8, 2));
            int hour = int.Parse(dateTaken.Substring(11, 2));
            int minute = int.Parse(dateTaken.Substring(14, 2));
            int second = int.Parse(dateTaken.Substring(17, 2));

            DateTime DateTaken = new DateTime(year, month, day, hour, minute, second);
            return DateTaken;
        }
    }
}
