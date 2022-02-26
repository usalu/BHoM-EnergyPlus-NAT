# BHoM - EnergyPlus - Yet Another Toolkit
 The first toolkit that brings all EnergyPlus objects into Grasshopper. The goal of this toolkit is to offer full customizability to EnergyPlus files with native type support and integrated documentation. The days of string replacement in IDF text snippets, creating manual wrapper classes and worry about proper serialization are over.

 The entire toolkit was generated through [EPJSONToFramework](https://github.com/usaluz/EPJSONToFramework) out of the offical [epJSON-Schema](https://eplus.readthedocs.io/en/latest/index.html) which was generated from the IDD of EnergyPlus V-9-5-0. As there were no manual modifications made, this offers the possbility to upgrade to future versions or if necessary compile older versions.


## Functionality

- Creating/Extending EnergyPlus simulation files
- Merging IDF + IDF, epJSON + epJSON, IDF + epJSON
- Bidirectional translation between IDF <-> epJSON

## Demo

![Create Simulation file](/docs/Gifs/BHoM_EnergyPlus_YAT_Grasshopper_Demo.gif)