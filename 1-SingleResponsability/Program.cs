using SingleResponsability;

StudentRepository studentRepository = new();
IDataExporter<Student> exporter = new StudentCsvExporter();

string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv");
exporter.Export(filePath, studentRepository.GetAll());
Console.WriteLine($"Proceso Completado, archivo = {filePath}");