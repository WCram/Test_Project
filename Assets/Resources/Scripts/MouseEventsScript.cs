using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEventsScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 worldPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Input.mousePosition, Vector2.);
        
        
        

        Debug.Log($"x: {hit.transform.gameObject}");
    }


}
