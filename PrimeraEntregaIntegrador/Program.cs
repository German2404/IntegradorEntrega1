using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimeraEntregaIntegrador
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea = "";
            for (int k = 0; k < 10; k++)
            {

            for (int i = 10; i >0; i --)
            {

                Analyzer a1 = new Analyzer(0.2, 0.8);
                a1.readTransactions("./" + i + ".txt");
                var timer = System.Diagnostics.Stopwatch.StartNew();
                var assoBF = a1.giveBruteForceRefinedAssotiations(0, 100, 0, 100);
                linea+=("BF " + i + " " + timer.Elapsed.TotalMilliseconds+"\n");

                a1 = new Analyzer(0.2, 0.8);
                a1.readTransactions("./" + i + ".txt");
                var timer3 = System.Diagnostics.Stopwatch.StartNew();
                var assoAP1 = a1.giveAPrioriRefinedAssotiations(0, 100, 0, 100);
                    linea += ("AP " + i + " " + timer3.Elapsed.TotalMilliseconds+"\n");
            }
            }

            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/corridas.txt";
            File.WriteAllText(path, linea);

            

            //Analyzer a = new Analyzer(0.2 ,0.8);
            //a.readTransactions("./transacciones.txt");
            //var timer3 = System.Diagnostics.Stopwatch.StartNew();
            //var assoBF = a.giveAPrioriRefinedAssotiations(0, 100, 0, 100);
            //Console.WriteLine("BF (" + "" + "):" + timer3.Elapsed.TotalMilliseconds + "\n");
            //var timer2 = System.Diagnostics.Stopwatch.StartNew();
            //var assoAP = a.giveAPrioriRefinedAssotiations(0, 100, 0, 100);
            //Console.WriteLine("AP (" + "" + "):" + timer2.Elapsed.TotalMilliseconds + "\n");
        }
    }
}
