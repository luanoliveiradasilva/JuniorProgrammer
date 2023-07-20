using UnityEngine;

namespace Assets.Prototype_2.Scripts
{
    internal class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] animalPrefabs;
        private float spawnRangeX = 20.0f;
        private float spawnPositionZ = 20.0f;

        private float startDelay = 2;
        private float spawnInterval = 1.5f;

        private void Start()
        {
            //Classe Invoke Method SpawnRandomAnimal: Reference: https://docs.unity3d.com/ScriptReference/MonoBehaviour.InvokeRepeating.html
            InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        }

        private void Update()
        {

        }

        private void SpawnRandomAnimal()
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
