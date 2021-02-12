using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;

    public bool gameOver = false;
    public float restartDelay = 5f;
    public Score score;

    public Animator levelCompleteAnimator;

    public void EndGame()
    {
        if(gameOver == false)
        {
            Debug.Log("Game Over");
            gameOver = true;
            score.enabled = false;
            Invoke("Restart", restartDelay);
            Restart();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Complete");
        completeLevelUI.SetActive(true);
        levelCompleteAnimator.SetTrigger("LevelCompleteTrigger");
    }
}
