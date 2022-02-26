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

        public static string GetIDF(string energyPlusExeFilePath, EPSimulationFile ePJson, bool isSilent = true) =>
            ConvertEPSimulationFile(energyPlusExeFilePath, GetEPJsonString(ePJson), isSilent);

        public static string GetIDF(string energyPlusExeFilePath, string baseIDF, string ePJson, bool isSilent = true) =>
            ConvertEPSimulationFile(energyPlusExeFilePath, GetMergedEPJsonString(ConvertEPSimulationFile(energyPlusExeFilePath, baseIDF), ePJson), isSilent);

        public static string GetIDF(string energyPlusExeFilePath, string baseIDF, EPSimulationFile ePJson, bool isSilent = true) =>
            ConvertEPSimulationFile(energyPlusExeFilePath, GetMergedEPJsonString(ConvertEPSimulationFile(energyPlusExeFilePath, baseIDF, isSilent), GetEPJsonString(ePJson)), isSilent);
        public static string GetIDF(string energyPlusExeFilePath, EPSimulationFile baseEPJson, EPSimulationFile ePJson, bool isSilent = true) =>
            ConvertEPSimulationFile(energyPlusExeFilePath, GetMergedEPJsonString(baseEPJson, ePJson), isSilent);

    }
}


