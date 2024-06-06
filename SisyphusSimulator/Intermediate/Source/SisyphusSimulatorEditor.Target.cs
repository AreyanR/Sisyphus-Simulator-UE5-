using UnrealBuildTool;

public class SisyphusSimulatorEditorTarget : TargetRules
{
	public SisyphusSimulatorEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SisyphusSimulator");
	}
}
