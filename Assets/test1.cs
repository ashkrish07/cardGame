using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    string []texts = {"1","2","3","4"};
    void Start()
    {
        
       
    
    }

    // Update is called once per frame
    void Update()
    {
 // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < texts.Length; t++ )
        {
            string tmp = texts[t];
            int r = Random.Range(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
        }
     	Debug.Log(texts[0]);   
    }
}
