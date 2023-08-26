using UnityEngine.SceneManagement;
using UnityEngine;

public class Changer : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "back")
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if(collision.collider.tag == "front")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
