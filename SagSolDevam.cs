using System.Collections;
using UnityEngine;

public class SagSolDevam : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 10f;

    IEnumerator Start()
    {
        while (true)
        {
            do yield return null; while (MoveTowards(pointA));
            do yield return null; while (MoveTowards(pointB));
        }
    }

    bool MoveTowards(Transform target)
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime);
        return transform.position != target.position;
    }
}
