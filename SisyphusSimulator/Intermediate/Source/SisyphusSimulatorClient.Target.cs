using UnrealBuildTool;

public class SisyphusSimulatorClientTarget : TargetRules
{
	public SisyphusSimulatorClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SisyphusSimulator");
	}
}
