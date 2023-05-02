using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateConesCity2 : MonoBehaviour
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

        IEnumerator ConeDrop()
    {
        while (coneCount < 10)
        {
            xPos = Random.Range(-72, -192);
            zPos = Random.Range(-209, -220);
            Instantiate(theCone, new Vector3(xPos, -0.7f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            coneCount += 1;
        }
    }
}
