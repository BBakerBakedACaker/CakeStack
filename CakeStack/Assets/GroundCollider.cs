using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundCollider : MonoBehaviour
{
    public CakeSpawner cakeSpawner;

     private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.transform.gameObject.tag == "Cake" && cakeSpawner.cakeCount > 2)
         {
            SceneManager.LoadScene("MainMenu");
         }
     }
}
