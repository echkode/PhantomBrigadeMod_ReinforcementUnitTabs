using System.Collections.Generic;

using HarmonyLib;

namespace EchKode.PBMods.ReinforcementUnitTabs
{
	static class LandingSystem
	{
		private static List<int> unitsToRemove;

		internal static void Initialize()
		{
			var fi = AccessTools.DeclaredField(typeof(PhantomBrigade.Combat.Systems.CombatLandingSystem), nameof(unitsToRemove));
			unitsToRemove = (List<int>)fi.GetValue(null);
		}

		internal static void RefreshTabs()
		{
			if (unitsToRemove.Count == 0)
			{
				return;
			}
			CIViewCombatMode.ins.RedrawUnitTabs();
		}
	}
}
