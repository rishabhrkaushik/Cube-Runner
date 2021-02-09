using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public float restartDelay = 5f;
    public void EndGame()
    {
        if(gameOver == false)
        {
            Debug.Log("Game Over");
            gameOver = true;
            Invoke("Restart", restartDelay);
            Restart();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
