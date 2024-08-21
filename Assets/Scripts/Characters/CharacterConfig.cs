using UnityEngine;

[CreateAssetMenu(fileName = nameof(CharacterConfig), menuName = "Create character data", order = 51)]
public class CharacterConfig : ScriptableObject
{
    [field: SerializeField] public float Speed { get; private set; }
}