using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 myPos;
    // Start is called before the first frame update
    void Start()
    {
        myPos = new Vector3(x: 0, y: 0, z: 0);
        transform.position = myPos;
    }

    // Update is called once per frame
    void Update()
    {
        ScaleToDirection(KeyCode.W, Vector3.right);
        ScaleToDirection(KeyCode.W, Vector3.up);
        ScaleToDirection(KeyCode.W, Vector3.forward);

        RotationToDirection(KeyCode.R, axis: new Vector3(x: 45, 0, 0));
        RotationToDirection(KeyCode.R, axis: new Vector3(x: 0, 0, 45));

    }
    public void ScaleToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale +=  2 * axis;
        }
    }

    public void RotationToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(axis);
        }
    }

}


