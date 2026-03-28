// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class gittest : ModuleRules
{
	public gittest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"gittest",
			"gittest/Variant_Platforming",
			"gittest/Variant_Platforming/Animation",
			"gittest/Variant_Combat",
			"gittest/Variant_Combat/AI",
			"gittest/Variant_Combat/Animation",
			"gittest/Variant_Combat/Gameplay",
			"gittest/Variant_Combat/Interfaces",
			"gittest/Variant_Combat/UI",
			"gittest/Variant_SideScrolling",
			"gittest/Variant_SideScrolling/AI",
			"gittest/Variant_SideScrolling/Gameplay",
			"gittest/Variant_SideScrolling/Interfaces",
			"gittest/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
