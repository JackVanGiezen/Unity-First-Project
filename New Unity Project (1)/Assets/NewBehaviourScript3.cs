using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	public int Int2 = 0;
    // Update is called once per frame
    void Update()
    {
	Int2 ++;
	if(Int2 > 200) {
	Vector3 newScale = transform.localScale;
	newScale *= 1.002f;
	transform.localScale = newScale;
	}
    }
}
