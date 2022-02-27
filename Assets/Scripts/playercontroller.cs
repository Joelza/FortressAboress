using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
public class playercontroller : MonoBehaviour
{
 
    public Camera cam;
    public NavMeshAgent agent;
   // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())   {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Debug.Log("Fired");

            if (Physics.Raycast(ray, out hit))  {
                agent.SetDestination(hit.point);
                Debug.Log("hit");
            }

            
        }        
    }
}
