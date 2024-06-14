using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    int hits = 0;
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name == "Dropper")
        {
             hits++;
            // Your collision handling code here
            Debug.Log("Collision detected with " + hits);
        }

        if(collision.gameObject.tag != "Hit" && collision.gameObject.name != "Plane")
        {
                hits++;
                // Your collision handling code here
                Debug.Log("Collision detected with " + hits);
        }


    }
}
