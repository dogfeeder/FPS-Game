using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float mouseSensitivity = 5.0f;

    Vector3 pos1;
    Player player;


    public GameObject enemy1;

	public bool yInvert = false;

	// Use this for initialization
	void Start () {

        
	
	}
	
	// Update is called once per frame
	void Update () {
        pos1 = new Vector3(Random.Range(-50, 25), 0, Random.Range(0, 100));

        Instantiate(enemy1, pos1, enemy1.transform.rotation);
	}
}
