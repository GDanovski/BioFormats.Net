using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using loci.formats;
using loci.formats.meta;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get image directory
            string dir = "";

            do
            {
                Console.WriteLine("Input file directory:");
                dir = Console.ReadLine();
            }
            while (!File.Exists(dir));
            
            // create format reader
            IFormatReader reader = new ImageReader();
            // initialize file
            reader.setId(dir);

            int seriesCount = reader.getSeriesCount();
           
            printPixelDimensions(reader);

            Console.ReadLine();
        }
    /// <summary>
    /// Outputs dimensional information.
    /// </summary> 
    public static void printPixelDimensions(IFormatReader reader)
        {
            // output dimensional information
            int sizeX = reader.getSizeX();
            int sizeY = reader.getSizeY();
            int sizeZ = reader.getSizeZ();
            int sizeC = reader.getSizeC();
            int sizeT = reader.getSizeT();
            int imageCount = reader.getImageCount();
            byte[] pixels = reader.openBytes(0);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Pixel dimensions:");
            Console.WriteLine("\tWidth = " + sizeX);
            Console.WriteLine("\tHeight = " + sizeY);
            Console.WriteLine("\tFocal planes = " + sizeZ);
            Console.WriteLine("\tChannels = " + sizeC);
            Console.WriteLine("\tTimepoints = " + sizeT);
            Console.WriteLine("\tTotal planes = " + imageCount);
            Console.WriteLine("\tImage frame size in bytes:\t" + pixels.LongLength);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
