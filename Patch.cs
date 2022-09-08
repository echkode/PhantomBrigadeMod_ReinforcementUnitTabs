// Copyright (c) 2022 EchKode
// SPDX-License-Identifier: BSD-3-Clause

using HarmonyLib;

namespace EchKode.PBMods.ReinforcementUnitTabs
{
	[HarmonyPatch]
	static class Patch
	{
		[HarmonyPatch(typeof(PhantomBrigade.Combat.Systems.CombatLandingSystem), "Execute")]
		[HarmonyPostfix]
		static void Cls_ExecutePostfix()
		{
			LandingSystem.RefreshTabs();
		}
	}
}
