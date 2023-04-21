using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCones : MonoBehaviour
{
    public GameObject theCone;
    public int xPos;
    public int zPos;
    public int coneCount;
    // Start is called before the first frame update
    void Start()
    {
            StartCoroutine(ConeDrop());
    }

    // Update is called once per frame
    IEnumerator ConeDrop()
    {
        while (coneCount < 3)
        {
            xPos = Random.Range(328, 335);
            zPos = Random.Range(466, 496);
            Instantiate(theCone, new Vector3(xPos, 0.2f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            coneCount += 1;
        }
    }
}
