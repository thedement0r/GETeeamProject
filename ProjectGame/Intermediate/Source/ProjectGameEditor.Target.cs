using UnrealBuildTool;

public class ProjectGameEditorTarget : TargetRules
{
	public ProjectGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ProjectGame");
	}
}
