# Creating the plague gun mod following this guide https://www.youtube.com/watch?v=UgCOhFzeX4A&ab_channel=Eck314
# which followed https://ludeon.com/forums/index.php?topic=33219.0

# Noteable steps to remember:
1. Create a .NET framework for 3.5(outdated, do 4 or higher)
2. Right click the project on the right side
	Properties
		Build tab
			Scroll down, Advanced
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