**ReinforcementUnitTabs**
----
A library mod for [Phantom Brigade (Alpha)](https://braceyourselfgames.com/phantom-brigade/) which fixes a bug in the combat view where new tabs above the timeline are not created for reinforcement units when they first land.

It is compatible with game version **0.21.0**. All library mods are fragile and susceptible to breakage whenever a new version is released.

See this [detailed guide](https://github.com/NBKRedSpy/PB_EquipmentTypeRarity#installation) about how to enable and install mods in Phantom Brigade.

Keep in mind that the tab list is limited to a maximum of 15 tabs. Units beyond that number will **not** have tabs.

**Technical Discussion**
----
Units in the combat view are normally assigned a UI "tab" above the timeline. This is sorted with the player-controlled units first, then the enemy mech units and finally enemy tank units. The display is dynamic: tabs are removed for units that are disabled, either by being destroyed or by its pilot ejecting. The first eight tabs are assigned hotkeys, F1 through F8, which makes it easy to switch between your units and target units with the keyboard.

It seems logical, therefore, to assume that new tabs would be assigned to units arriving via reinforcements but that doesn't usually happen. What I discovered is that it _will_ happen if a unit is destroyed in the same turn that the reinforcements land. That event triggers the logic to refresh the tab list and the reinforcement units are then included in the list.

This appears to be a simple oversight. The logic that handles the landing of reinforcement units is missing the call to refresh the tab list.
