using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public void EndGame () 
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Debug.Log("Ended");
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
