using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ioetSolutionMarceloRomero
{
    class ConnectionFile
    {
        public StreamReader ReadFile()
        {
            StreamReader file = new StreamReader(@"c:\\prueba.txt");
            return file;
        }

        public void CloseFile(StreamReader file)
        {
            file.Close();
        }
        


    }
}
