#if UNITY_2018_1_OR_NEWER
using UnityEditor.Build.Reporting;
#endif
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;

public class UnityWebViewPostprocessBuild : 
#if UNITY_2018_1_OR_NEWER
    IPreprocessBuildWithReport
#else
    IPreprocessBuild
#endif
{
    public int callbackOrder => 0;

#if UNITY_2018_1_OR_NEWER
    public void OnPreprocessBuild(BuildReport report)
    {
        Debug.Log($"Building for target: {report.summary.platform}");
    }
#else
    public void OnPreprocessBuild(BuildTarget target, string path)
    {
        Debug.Log($"Building for target: {target}, path: {path}");
    }
#endif
}
