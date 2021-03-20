using UnityEngine;

public class DaireAlan : MonoBehaviour
{
    public Transform player; 
    public Vector3 circleCenter;
    public float radius ; 
        
    void Update()
    {
        float dist = Vector3.Distance(player.position, circleCenter); 

        if (dist > radius)
        {
            Vector3 fromOrigintoObject = player.position - circleCenter;
            fromOrigintoObject *= radius / dist;
            player.position = circleCenter + fromOrigintoObject;
            transform.position = player.position;
        }
    }
}
