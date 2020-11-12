using UnityEngine;

namespace Task.Scripts
{
    public class CharacterLoader : MonoBehaviour
    {
        [SerializeField] private Transform spawnPosition;
        
    
        private GameObject character;
    
        public void LoadCharacter(string id)
        {
            var config = Resources.Load<CharacterConfig>($"Config/{id}");
            var prefab = Resources.Load<GameObject>($"CharacterPrefabs/{config.PrefabName}");
        
            if (character != null)
            {
                Destroy(character);
            }

            character = Instantiate(prefab, spawnPosition);
        }
    }
}
