using UnrealBuildTool;

public class SisyphusSimulatorServerTarget : TargetRules
{
	public SisyphusSimulatorServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SisyphusSimulator");
	}
}
