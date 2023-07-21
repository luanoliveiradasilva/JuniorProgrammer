
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Prototype_3.Scripts
{
    internal class SpawnManager : MonoBehaviour
    {
        [SerializeField] GameObject obstaclePrefab;
        private Vector3 spawnPos = new Vector3 (25, 0, 0);
        private float startDelay = 2;
        private float repeatRate = 2;

        private void Start()
        {
            InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        }

        private void SpawnObstacle()
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
