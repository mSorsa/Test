namespace IndexerPlayground.Playground
{
    /// <summary>
    /// This class is a basic usage of an indexer.
    /// </summary>
    internal class IndexerClass
    {
        // The array to store the values.
        private string[] array;

        public string this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public IndexerClass(int size)
        {
            array = new string[size * 2];
        }
    }
}
