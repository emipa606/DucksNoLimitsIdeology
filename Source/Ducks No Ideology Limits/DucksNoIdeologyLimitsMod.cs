﻿using Mlie;
using UnityEngine;
using Verse;

namespace DucksNoIdeologyLimits;

[StaticConstructorOnStartup]
internal class DucksNoIdeologyLimitsMod : Mod
{
    /// <summary>
    ///     The instance of the settings to be read by the mod
    /// </summary>
    public static DucksNoIdeologyLimitsMod Instance;

    private static string currentVersion;

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="content"></param>
    public DucksNoIdeologyLimitsMod(ModContentPack content) : base(content)
    {
        Instance = this;
        Settings = GetSettings<DucksNoIdeologyLimitsSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    /// <summary>
    ///     The instance-settings for the mod
    /// </summary>
    internal DucksNoIdeologyLimitsSettings Settings { get; }

    /// <summary>
    ///     The title for the mod-settings
    /// </summary>
    /// <returns></returns>
    public override string SettingsCategory()
    {
        return "Ducks No Ideology Limits";
    }

    /// <summary>
    ///     The settings-window
    ///     For more info: https://rimworldwiki.com/wiki/Modding_Tutorials/ModSettings
    /// </summary>
    /// <param name="rect"></param>
    public override void DoSettingsWindowContents(Rect rect)
    {
        var listingStandard = new Listing_Standard();
        listingStandard.Begin(rect);
        listingStandard.Gap();
        listingStandard.CheckboxLabeled("DNIL.OnlyPlayer".Translate(), ref Settings.OnlyPlayer,
            "DNIL.OnlyPlayerTT".Translate());
        if (currentVersion != null)
        {
            listingStandard.Gap();
            GUI.contentColor = Color.gray;
            listingStandard.Label("DNIL.CurrentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listingStandard.End();
    }
}