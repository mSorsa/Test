namespace IndexerPlayground.Playground
{
    /// <summary>
    /// Dummy-class.
    /// To be filled with samples when demonstrating 'Students'
    /// </summary>
    public record Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    /// <summary>
    /// Sample class to demonstrate the use of an iterator-indexer.
    /// </summary>
    public class Students
    {
        Student[] students;
        public Students(int numberOfStudents)
        {
            students = new Student[numberOfStudents];
        }
        
        private int _totalNumberOfStudents = 0;
        /// <summary>
        /// Add a student to the collection
        /// </summary>
        /// <param name="student">Full student object (name and age)</param>
        public void Add(Student student)
        {
            students[_totalNumberOfStudents++] = student;
        }
        
        /// <summary>
        /// Creates a student-object based on name and age,
        /// then adds to collection.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public void Add(string name, int age)
        {
            students[_totalNumberOfStudents++] = new Student()
            {
                Name = name,
                Age = age
            };
        }
        
        // -------------------------------------------------
        // Here there be Monsters.

        public OmegaIterator Omega
        {
            get { return new OmegaIterator(this); }
        }

        /// <summary>
        /// Sorts the collection based on Ages.
        /// </summary>
        public void OrderByAge()
        {
            students = students.OrderBy(s => s.Age).ToArray();
        }

        /// <summary>
        /// Sorts the collection based on Names.
        /// </summary>
        public void OrderByName()
        {
            students = students.OrderBy(s => s.Name).ToArray();
        }
        
        public class OmegaIterator
        {
            readonly Students outer;
            internal OmegaIterator(Students outer)
            {
                this.outer = outer;
            }
            
            /// <summary>
            /// Length of the collection.
            /// </summary>
            public int Length { get { return outer._totalNumberOfStudents; } }
            
            /// <summary>
            /// The current Student.
            /// </summary>
            /// <param name="index"></param>
            /// <returns>Returns the currently-indexed student.</returns>
            public Student this[int index]
            {
                get { return outer.students[index]; }
            }
            
            /// <summary>
            /// Loop-mechanic.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<Student> GetEnumerator()
            {
                for (int i = 0; i < this.Length; i++)
                    yield return outer.students[i];
            }
        }
    }
}
