using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class DataHandler
    {
        // Field
        private string dataFileName;

        //Properties
        public string DataFileName { get { return dataFileName; } }

        /// <summary>
        /// DataHandler constructor
        /// </summary>
        /// <param name="dataFileName"></param>
        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }

        /// <summary>
        /// Method to save person information to a text file.
        /// </summary>
        /// <param name="person"></param>
        public void SavePerson(Person person)
        {
            using (StreamWriter file = new StreamWriter(DataFileName))
            {
                file.WriteLine(person.MakeTitle());
            }
 
        }

        public void SavePersons(Person[] persons)
        {
            using (StreamWriter file = new StreamWriter(DataFileName))
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    file.WriteLine(persons[i].MakeTitle());
                }
            }
        }

        /// <summary>
        /// Method which reads the file and returns the person object.
        /// </summary>
        /// <returns> Person object </returns>
        public Person LoadPerson()
        {
            using (StreamReader fileReader = new StreamReader(DataFileName))
            {
                string input = fileReader.ReadToEnd();
                string[] result = input.Split(";");
                Person person = new Person(result[0], DateTime.Parse(result[1]), double.Parse(result[2]), bool.Parse(result[3]), int.Parse(result[4]));
                return person;
            }
        }

        public Person[] LoadPersons()
        {
            Person[] result = new Person[10];

            using (StreamReader fileReader = new StreamReader(DataFileName))
            {
                string input = fileReader.ReadLine();
                int count = 0;

                while (input != null)
                {
                    string[] inputSplitted = input.Split(";");
                    Person person = new Person(inputSplitted[0], DateTime.Parse(inputSplitted[1]), double.Parse(inputSplitted[2]), bool.Parse(inputSplitted[3]), int.Parse(inputSplitted[4]));
                    result[count++] = person;
                    input = fileReader.ReadLine();
                }
            }
            return result;
        }
    }
}