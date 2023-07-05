using UnityEngine;

namespace Assets.Scripts
{
    
    internal class FollowPlayer: MonoBehaviour
    {

        [SerializeField] private GameObject player;


        private void LateUpdate()
        {
            // Offset the camera behind the player by adding to the player´s position
            transform.position = player.transform.position + new Vector3(32, 3, 6);
        }

    }
}
