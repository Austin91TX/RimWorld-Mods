# Blind, basic steps to create a RimWorld mod

#This area is where you'd modify and adjust attributes
1. Create a folder for the mod in %\Steam\steamapps\common\RimWorld\Mods

2. Create About.xml in %\RimWorld\Mods\$YourModName$\About

3. Create a Defs folder in %\RimWorld\Mods\$YourModName$

4. Copy code from a desired ThingDef from $\Steam\steamapps\common\RimWorld\Data\Core\Defs
	Example: copy lines starting from <ThingDef to </ThingDef> located in: $\Steam\steamapps\common\RimWorld\Data\Core\Defs\ThingDefs_Misc\Weapons\RangedIndustrial.xml
		paste into %\RimWorld\Mods\$YourModName$\Defs\$ModNameDefs$
		
#This is where you'll create the C# code
1. Create a .NET Framework project for creating C#

2. Right click the project name
	Select Properties
		Select Build tab
			Scroll down, Select Advanced
				Debugging Information: None
			Right above Advanced, change Output path to (example) D:\Steam\steamapps\common\RimWorld\Mods\PlagueGun\Assemblies
3. Right click the project on the right side
	Add References:
		Assembly-CSharp
		UnityEngine
		UnityEngine.CoreModule
	from D:\Steam\steamapps\common\RimWorld\RimWorldWin64_Data\Managed
4. Right click Properties for both of those references
	Turn Copy Local to False