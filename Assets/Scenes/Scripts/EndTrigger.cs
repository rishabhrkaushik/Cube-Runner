using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
