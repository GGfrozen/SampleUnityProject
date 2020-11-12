using UnityEngine;

namespace Task.Scripts
{
    [CreateAssetMenu]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private string characterName;
        [SerializeField] private string prefabName;

        public string CharacterName => characterName;
        public string PrefabName => prefabName;
    
    }
}
