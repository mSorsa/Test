namespace IndexerPlayground.Playground
{
    /// <summary>
    /// This class is a basic usage of an indexer.
    /// </summary>
    internal class IndexerClass
    {
        // The array to store the values.
        private string[] array;

        // The indexer.
        public string this[int index]
        {
            get => array[index * 2];
            set => array[index * 2] = value;
        }

        // Constructor.
        public IndexerClass(int size)
        {
            array = new string[size * 2];
        }
    }
}
