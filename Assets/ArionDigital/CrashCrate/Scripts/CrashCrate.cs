namespace ArionDigital
{
    using UnityEngine;

    public class CrashCrate : MonoBehaviour
    {
        [Header("Whole Create")]
        public MeshRenderer wholeCrate;
        public BoxCollider boxCollider;
        [Header("Fractured Create")]
        public GameObject fracturedCrate;
        [Header("Audio")]
        public AudioSource crashAudioClip;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Hacha"))
            {
                wholeCrate.enabled = false;
                boxCollider.enabled = false;
                fracturedCrate.SetActive(true);
                crashAudioClip.Play();

                // Desactivar el objeto que contiene este script
                Invoke("DeactivateGameObject", 1.5f);
            }
        }

        private void DeactivateGameObject()
        {
            // Desactivar el objeto que contiene este script
            gameObject.SetActive(false);
        }

        [ContextMenu("Test")]
        public void Test()
        {
            wholeCrate.enabled = false;
            boxCollider.enabled = false;
            fracturedCrate.SetActive(true);

           
        }
    }
}