/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.Engine.Base;
using BH.oM.Base.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using BH.oM.Adapters.EnergyPlus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Convert
    {
        [Description(" Convert an input file (either to IDF or EPJSON) to the other format.")]
        [Input("energyPlusExeFilePath", "Filepath of energyplus.exe")]
        [Output("energyPlusString", "String representation of IDF if input was EPJson and vice versa")]
        public static string ConvertEPSimulationFile(string energyPlusExeFilePath, string input, bool isSilent = true)
        {
            bool isJson = input.StartsWith("{");
            string baseExtension = isJson ? ".epJSON" : ".idf";
            string targetExtension = isJson ? ".idf" : ".epJSON";

            string tempPath = System.IO.Path.GetTempPath();
            string tempFileBase = tempPath + Guid.NewGuid().ToString();
            string ePJsonTempFile = tempFileBase + baseExtension;
            File.WriteAllText(ePJsonTempFile, input);

            var process = new Process();
            process.StartInfo.WorkingDirectory = tempPath;
            process.StartInfo.FileName = energyPlusExeFilePath;
            process.StartInfo.CreateNoWindow = isSilent;
            process.StartInfo.Arguments = " --convert-only " + ePJsonTempFile;
            process.Start();
            process.WaitForExit();

            string result;
            try
            {
                result = File.ReadAllText(tempFileBase + targetExtension);
            }
            catch (Exception e)
            {
                result = File.ReadAllText(tempPath + "eplusout.err");
            }
            return result;
        }
    }
}


