
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Prototype_3.Scripts
{
    internal class SpawnManager : MonoBehaviour
    {
        [SerializeField] GameObject obstaclePrefab;
        private Vector3 spawnPos = new Vector3(25, 0, 0);
        private float startDelay = 2;
        private float repeatRate = 2;
        private PlayerController playerControllerScript;

        private void Start()
        {
            InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
            playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        }

        private void SpawnObstacle()
        {
            if (playerControllerScript.gameOver == false)
            {
                Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            }
        }
    }
}
