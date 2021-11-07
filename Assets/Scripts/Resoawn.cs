using UnityEngine;

public class Resoawn : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
