using UnrealBuildTool;

public class SisyphusSimulatorTarget : TargetRules
{
	public SisyphusSimulatorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SisyphusSimulator");
	}
}
