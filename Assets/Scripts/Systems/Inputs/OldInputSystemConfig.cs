using UnityEngine;

[CreateAssetMenu(fileName = nameof(OldInputSystemConfig), menuName = "Create old input system config", order = 51)]
public class OldInputSystemConfig : ScriptableObject
{
    [field: SerializeField] public KeyCode LeftButton { get; private set; }
    [field: SerializeField] public KeyCode RightButton { get; private set; }
}