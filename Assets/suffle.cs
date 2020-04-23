using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class suffle : MonoBehaviour
{
    public GameObject[] boxes;
    int a = 0;
    float y = 6.6f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //foreach (GameObject box in boxes)
        while (a != 1)
        {

            //float y = Random.Range(-3f, 3f);
            boxes[0].transform.position = new Vector3(-35, y, 0);
            boxes[0].transform.Rotate(0, 90, 0);
            boxes[1].transform.position = new Vector3(35, y, 0);
            boxes[1].transform.Rotate(0, 90, 0);
            boxes[2].transform.position = new Vector3(0, y, 21);
            boxes[3].transform.position = new Vector3(0, y, -21);

            a = 1;
            //boxes[4].transform.position = new Vector3(x, y);
        }


    }
}
