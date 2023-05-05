using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{

    public Transform RestartPoint;

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.R))
            {
                transform.position = RestartPoint.position;
                GetComponent<Transform> ().eulerAngles = new Vector3 (0, 0, 0);
            }
    }
}
