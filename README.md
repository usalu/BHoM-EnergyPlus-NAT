# BHoM - EnergyPlus - Not Another Toolkit
 The first toolkit that brings all EnergyPlus objects into Grasshopper. The goal of this toolkit is to offer full customizability to EnergyPlus files with native type support, integrated documentation and automatic serialization. The days of string replacement in IDF text snippets, creating manual wrapper classes and worry about proper serialization are over.

 The entire toolkit was generated through [EPJSONToFramework](https://github.com/usaluz/EPJSONToFramework) out of the offical [epJSON-Schema](https://eplus.readthedocs.io/en/latest/index.html) which was generated from the IDD of EnergyPlus V9-5-0. As there were no manual modifications made, this offers the possbility to upgrade to future versions or if necessary compile older versions.

## BHoM without oM

Although this is a BHoM toolkit it offers no functionality regarding the BH object Model. The only purpose of this toolkit is to bring the EnergyPlus object model into Grasshopper. The amazing architecture of BHoM allows for the framework to be useful even outside of the intended use-case. Especially UI generation, search bar and the morph components are very handy for such a large plugin. In a traditional Grasshopper plugin this would have created about 2200 components which would have completly cluttered the UI.

## Functionality

- Creating/Modifying/Extending EnergyPlus simulation files
- Merging IDF + IDF, epJSON + epJSON, IDF + epJSON
- Bidirectional translation between IDF <-> epJSON

## Instalation

This toolkit only works with Windows and it's main intend is to use it with Grasshopper. Technically you could use the same plugin inside all supported platforms of BHoM (Dynamo, Excel, ...) altough for a non visual scripting enviroment, I recommend [EnergyPlusDotNet](https://github.com/usaluz/EnergyPlusDotNet) as it has a more straightforward structure (no groups but therefore the EPSimulation class has 820 properties which would have resulted in a huge component in visual scripting).
1. Download & Install [BHoM](bhom.xyz)
1. Download "EnergyPlus_oM" and "EnergyPlus_Engine" from the release and place it inside:
> C:\ProgramData\BHoM\Assemblies

That's it! Now if you choose the "CreateObject" component from the BHoM menu inside Grasshopper, you should find all EnergyPlus Objects under the menu section "Adapters/EnergyPlus".

## Advices

For quick modelling just create one "EPSimulationFile" and then go over with the cursor to the input, left click and drag into empty canvas space. Then a search box appears and it will already have the right object select, so just press enter. This spares long searching.

![Create Simulation file](/docs/Gifs/BHoM_EnergyPlus_YAT_Grasshopper_Demo.gif)

 BHoM_EnergyPlus_YAT + [Honeybee](https://github.com/ladybug-tools/honeybee-energy) = :heart: 
 
Use Honeybee to create a quick base IDF and add any further functionality with this toolkit. This way you combine the simplicity of Honeybee without loosing power of customization. 

## Acknowledgement
This project emerged as part of the DFG project [_Knowledge Base and Machine-Learning Assistance for Performance-oriented Building_](https://gepris.dfg.de/gepris/projekt/317653109) inside of the DFG  research unit [_FOR 2363: Evaluation of building design variants in early phases on the basis of adaptive detailing strategies_](https://gepris.dfg.de/gepris/projekt/271444440?language=en). 