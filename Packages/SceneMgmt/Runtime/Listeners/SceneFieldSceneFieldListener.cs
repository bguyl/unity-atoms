using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SceneField - SceneField")]
    public sealed class SceneFieldSceneFieldListener : AtomListener<
        SceneField,
        SceneField,
        SceneFieldSceneFieldAction,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldUnityEvent>
    { }
}
