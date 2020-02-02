using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
    	{

	}
	public int Int = 100;
	// Update is called once per frame
	void Update()
	{
		Debug.Log(Int);
		transform.Translate(Vector3.down * Time.deltaTime);
		if(Int == 0)
		{
			transform.Translate(Vector3.up * Time.deltaTime * 100);
                	Int = 100;
		}
        	else if(Int != 0){
			Int -= 1;
		}
	}
}