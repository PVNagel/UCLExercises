using System;
using System.IO;
using System.Threading.Tasks;

namespace ToUpper
{

    class Program
    {
        private const string _infilesFolder = "infiles";
        private const string _outfilesFolder = "outfiles";
        private const string _infilenameBasis = _infilesFolder + "\\splitfile";
        private const string _outfilenameBasis = _outfilesFolder + "\\UPPERsplitfile";
        private const string _fileExtension = ".txt";
        private int _sheepCount = default;

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.MainThread();
        }

        private void MainThread()
        {
            int fileCount = Directory.GetFiles(_infilesFolder).Length;
            Console.WriteLine($"Starting job - {fileCount} files");
            Job(fileCount);
            Console.WriteLine("Job is done");
            Console.ReadKey();
        }

        public void Job(int fileCount)
        {
            for (int i = 1; i <= fileCount; i++)
            {
                FileInfo fi = new FileInfo(_infilenameBasis + i + _fileExtension);
                int fileSize = (int)fi.Length;
                char[] charbuf = new char[fileSize];

                using (StreamReader sr = fi.OpenText())
                {
                    using (StreamWriter sw = File.CreateText(_outfilenameBasis + i + _fileExtension))
                    {
                        // - create a Task<?> that reads file into charbuf
                        Task task = sr.ReadAsync(charbuf, 0, fileSize);

                        // - call CountSheep(…),
                        CountSheep(task);

                        // - convert charbuf to upper case (Char.ToUpper(…);)
                        for (int j = 0; j < fileSize; j++)
                        {
                            charbuf[j] = char.ToUpper(charbuf[j]);
                        }

                        // - write charbuf to disk using the StreamWriter
                        sw.WriteAsync(charbuf);
                    }
                }
            }
        }

        private void CountSheep(Task job)
        {
            while ((job.Status != TaskStatus.RanToCompletion))
            {
                Console.WriteLine(_sheepCount + " sheep");
                _sheepCount++;
            }
        }
    }
}
