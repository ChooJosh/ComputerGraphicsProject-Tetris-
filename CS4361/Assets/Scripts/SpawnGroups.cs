using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGroups : MonoBehaviour
{
	//array of game objects
	public GameObject[] groups;

	public void nextGroup()
	{
		int index = Random.Range(0, groups.Length);
		Instantiate(groups[index], transform.position, Quaternion.identity);
	}
	// Start is called before the first frame update
	void Start()
    {
		//start the 1st group
		nextGroup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
