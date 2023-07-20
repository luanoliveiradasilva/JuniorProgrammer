using UnityEngine;

namespace Assets.Prototype_2.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float horizontalInput;
        [SerializeField] private float moveSpeed = 10.0f;
        [SerializeField] private float xRange = 10.0f;

        [SerializeField] private GameObject projectilePrefab;


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

            horizontalInput = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * horizontalInput);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Clona a pizza original e retorna clone assim que clicado no barra de spaço. : https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
        }
    }
}
