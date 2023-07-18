using UnityEngine;

namespace Assets.Scripts
{ 
    internal class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] animalPrefabs;
        private float spawnRangeX = 20.0f;
        private float spawnPositionZ = 20.0f;

        private void Start()
        {
            
        }

        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.S))
            {
                //Lenght animals with Random.
                int animalIndex = Random.Range(0, animalPrefabs.Length);

                //Position animal with ranfom.
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

                //Instantiate animal with prefabs 
                Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
            }
            
        }
    }
}
