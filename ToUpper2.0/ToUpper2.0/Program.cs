using System;
using System.IO;

namespace ToUpper2._0
{

    class Program
    {
        private const string _infilesFolder = "infiles";
        private const string _outfilesFolder = "outfiles";
        private const string _infilenameBasis = _infilesFolder + "\\splitfile";
        private const string _outfilenameBasis = _outfilesFolder + "\\UPPERsplitfile";
        private const string _fileExtension = ".txt";
        private bool _jobIsRunning = default;

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
            CountSheep();
            Console.WriteLine("Job is done");
            Console.ReadKey();
        }

        async public void Job(int fileCount)
        {
            _jobIsRunning = true;
            for (int i = 1; i <= fileCount; i++)
            {
                FileInfo fi = new FileInfo(_infilenameBasis + i + _fileExtension);
                int fileSize = (int)fi.Length;
                char[] charbuf = new char[fileSize];

                using (StreamReader sr = new StreamReader(_infilenameBasis + i + _fileExtension))
                {
                    using (StreamWriter sw = new StreamWriter(_outfilenameBasis + i + _fileExtension))
                    {
                        await sr.ReadAsync(charbuf, 0, fileSize);
                        for (int j = 0; j < fileSize; j++)
                        {
                            charbuf[j] = char.ToUpper(charbuf[j]);
                        }
                        await sw.WriteAsync(charbuf);
                    }
                }
            }
            _jobIsRunning = false;
        }

        private void CountSheep()
        {
            int i = 1;
            while (_jobIsRunning)
            {
                Console.WriteLine(i + " sheep");
                i++;
            }
        }
    }
}