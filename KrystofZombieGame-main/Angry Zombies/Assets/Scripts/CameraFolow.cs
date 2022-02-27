using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    
    public Transform playerTransform;
    

    public Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = playerTransform.position + offSet;
    }
   
}
