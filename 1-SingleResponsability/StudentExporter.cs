using System.Text;

namespace SingleResponsability
{
    public class StudentCsvExporter : IDataExporter<Student>
    {
        public void Export(string filePath, IEnumerable<Student> students)
        {
            string csv = string.Join(",", students.Select(x => x.ToString()).ToArray());
            StringBuilder sb = new();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            File.WriteAllText(filePath, sb.ToString(), Encoding.Unicode);
        }
    }
}