using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public bool isGameEnd = false;
    public float endDelay = 2f;

    public void EndGame() 
    {
        if (isGameEnd == false)
        {
            isGameEnd = true;
            Invoke("Restart", endDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
