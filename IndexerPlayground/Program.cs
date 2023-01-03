using CenterSpace.NMath.Core;
using IndexerPlayground.Playground;
using System.Text;

namespace IndexerPlayground
{
    internal class Program
    {
        // Number of students we will generate and work with.
        private static readonly short numberOfStudents = 20;
        
        static void Main(string[] args)
        {
            #region IterIndexClass
            // MyIndexerClass-stuff
            // Instantiate and give size of array.
            IndexerClass myIndexerClass = new IndexerClass(3);

            // Set values in the array.
            myIndexerClass[0] = "Hello";
            myIndexerClass[1] = "World";
            myIndexerClass[2] = "!";

            // Get values from the array.
            StringBuilder buf = new();      // See StringBuilder-project.
            buf.Append(myIndexerClass[0]);
            buf.Append(' ');
            buf.Append(myIndexerClass[1]);
            buf.Append(' ');
            buf.Append(myIndexerClass[2]);

            // Print the string.
            Console.WriteLine(buf.ToString());


            Console.WriteLine("\n----------------------------------------------\n");

            
            // IterIndexClass-stuff
            Students s = new Students(numberOfStudents);
            PopulateStudents(s);
            s.OrderByAge();

            Students.ChadIterator iterator = s.Omega;
            {
                using (var student = iterator.GetEnumerator())
                {
                    while (student.MoveNext())
                    {
                        Console.WriteLine($"{student.Current.Name, -10}" + " is " + student.Current.Age + " years old.");
                    }
                }
            }
            #endregion

            foreach (int number in YieldRet.GetNumbers())
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Generate random students and add them to the collection.
        /// </summary>
        /// <param name="students"></param>
        private static void PopulateStudents(Students students)
        {
            // Generate Students with Name and Age properties.
            for (int i = 0; i < numberOfStudents; i++)
            {
                students.Add(GetRandomName(), GetRandomAge());
            }
        }

        /// <summary>
        /// Get a random name.
        /// </summary>
        /// <returns>A name.</returns>
        private static string GetRandomName()
        {
            Random random = new();
            string[] names = new string[] { "John", "Jane", "Bob", "Alice", "Peter",
                                            "Mary", "Paul", "Sarah", "Mike", "Sue",
                                            "Larry", "Sven", "Linda", "Clara", "Karen",
                                            "Morgan", "Fred", "Benny", "Liza", "Charles",
                                            "Michael", "Michelle", "Nils", "Jorge", "Miles" };
            
            return names[random.Next(0, names.Length)];
        }

        /// <summary>
        /// Get a random age.
        /// Triangular Distribution.
        /// Lowest age: 0.
        /// Highest age: 70.
        /// Mode age: 30.
        /// </summary>
        /// <returns>Integer age.</returns>
        private static int GetRandomAge()
        {
            RandGenTriangular triangular = new(lb:10, ub:70, m:30); 
            return (int)triangular.Next();
        }
    }
}