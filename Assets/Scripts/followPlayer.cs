using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;
    public Quaternion offset2;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offSet;

    }
}
