using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create a ray from the camera to the mouse position
            RaycastHit hit = new RaycastHit(); // Create a RaycastHit object to store information about what was hit

            if (Physics.Raycast(ray, out hit, 1000))     // Cast a ray from the camera to the mouse position
            {
                GetComponent<NavMeshAgent>().SetDestination(hit.point); // Set the destination of the NavMeshAgent to the point that was hit
            }
        }
    }
}
