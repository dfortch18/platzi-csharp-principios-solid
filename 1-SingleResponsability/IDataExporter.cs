namespace SingleResponsability
{

    public interface IDataExporter<T>
    {
        public void Export(string filePath, IEnumerable<T> data);
    }
}