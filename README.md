# BHoM - EnergyPlus - Yet Another Toolkit
 The first toolkit that brings all EnergyPlus objects into Grasshopper. The goal of this toolkit is to offer full customizability to EnergyPlus files with native type support, integrated documentation and automatic serialization. The days of string replacement in IDF text snippets, creating manual wrapper classes and worry about proper serialization are over.

 The entire toolkit was generated through [EPJSONToFramework](https://github.com/usaluz/EPJSONToFramework) out of the offical [epJSON-Schema](https://eplus.readthedocs.io/en/latest/index.html) which was generated from the IDD of EnergyPlus V-9-5-0. As there were no manual modifications made, this offers the possbility to upgrade to future versions or if necessary compile older versions.


## Functionality

- Creating/Extending EnergyPlus simulation files
- Merging IDF + IDF, epJSON + epJSON, IDF + epJSON
- Bidirectional translation between IDF <-> epJSON

## Instalation

This toolkit only works with Windows and it's main intend is to use it with Grasshopper. Although the BHoM framework would allow to use it cross plattform, the model structure is not 
1. Download [BHoM](bhom.xyz)
1. Download "EnergyPlus_oM" and "EnergyPlus_Engine" from the release and place it it
> C:\ProgramData\BHoM\Assemblies

That's it! Now if you choose the "CreateObject" from the BHoM menu, you should find all EnergyPlus Objects under the section "Adapters/EnergyPlus".

## Advices

For quick modelling just create one "EPSimulationFile" and then go over with the cursor to the input, left click and drag into empty canvas space. Then a search box appears and it will already have the right object select, so just press enter. This spares long searching.

![Create Simulation file](/docs/Gifs/BHoM_EnergyPlus_YAT_Grasshopper_Demo.gif)

 BHoM_EnergyPlus_YAT + [Honeybee](https://github.com/ladybug-tools/honeybee-energy) = :heart: 
 
Use Honeybee to create a quick base IDF and add any further functionality with this toolkit. This way you combine the simplicity of Honeybee without loosing power of customization. 