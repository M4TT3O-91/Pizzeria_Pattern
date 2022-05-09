namespace PizzeriaLibrary.Reader_Writer
{
    public class OrderFileWriter
    {
        public void WriteToFile(string path, string content)
        {
   
            using (var stream = new StreamWriter(path, true))
            {
                stream.WriteLine(content);
            }
        }
    }
}
