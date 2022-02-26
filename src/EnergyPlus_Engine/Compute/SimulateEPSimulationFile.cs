using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Engine.Adapters.EnergyPlus
{
    //public static string Simulate(string energyPlusExeFilePath, string inputFile, string weatherFilePath = "", bool isSilent = true)
    //{
    //    string tempPath = System.IO.Path.GetTempPath();
    //    string tempFileBase = tempPath + Guid.NewGuid().ToString();
    //    string ePJsonTempFile = tempFileBase + ".epJSON";
    //    File.WriteAllText(ePJsonTempFile, ePJson);

    //    var process = new Process();
    //    process.StartInfo.WorkingDirectory = tempPath;
    //    process.StartInfo.FileName = energyPlusExeFilePath;
    //    process.StartInfo.CreateNoWindow = isSilent;
    //    process.StartInfo.Arguments = " --convert-only " + ePJsonTempFile;
    //    process.Start();
    //    process.WaitForExit();

    //    string result;
    //    try
    //    {
    //        result = File.ReadAllText(tempFileBase + ".idf");
    //    }
    //    catch (Exception e)
    //    {
    //        result = File.ReadAllText(tempPath + "eplusout.err");
    //    }

    //    return result;
    //}
}
