using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(UnityEditor.DefaultAsset))]
public class DefaultAssetInspector : Editor
{
    public static UnityEngine.Events.UnityEvent<UnityEngine.Object> OnSelectAsset = new  UnityEngine.Events.UnityEvent<Object>();
    public static UnityEngine.Events.UnityEvent onInspectorGUIHander = new UnityEngine.Events.UnityEvent();
    public static UnityEngine.Events.UnityEvent onDestroyGUIHander = new UnityEngine.Events.UnityEvent();


    void OnEnable()
    {
        OnSelectAsset?.Invoke(target);
    }
    public override void OnInspectorGUI()
    {
        onInspectorGUIHander?.Invoke();
    }

    void OnDestroy()
    {
        onDestroyGUIHander?   . Invoke();
        onDestroyGUIHander?   . RemoveAllListeners();
        onInspectorGUIHander? . RemoveAllListeners();
    }
}
