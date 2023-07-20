using UnityEngine;

namespace Assets.Challenge_2.Scripts
{
    public class PlayerControllerX : MonoBehaviour
    {
        public GameObject dogPrefab;

        private float fireRate = 5.0f;
        private float nextFire = 0.0f;


        private void Start()
        {
            float randontest = Random.Range(0f, 100f);
            float testInt = Random.Range(0f, 100);
            Debug.Log("testes   " + randontest);
            Debug.Log("teste" + testInt);
        }

        // Update is called once per frame
        void Update()
        {
            // On spacebar press, send dog
            // Used Time.time to next fire dog : reference: https://docs.unity3d.com/ScriptReference/Time-time.html
            if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }

       



        }
    }
}
