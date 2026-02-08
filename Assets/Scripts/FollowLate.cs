using UnityEngine;

public class FollowLate : MonoBehaviour
{
    [SerializeField] Transform toFollow;

    void LateUpdate()
    {
        transform.position = toFollow.position;
        transform.rotation = toFollow.rotation ;
    }
}
