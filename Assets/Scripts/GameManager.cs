using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float mouseSensitivity = 5.0f;

    Vector3 pos1;
    Player player;

    public int enemyAmount = 0;
    public GameObject enemy1;

    private float respawnTimer = 5.0f;
    private float respawnElapsed = 0;

	public bool yInvert = false;

	// Use this for initialization
	void Start () {

        pos1 = new Vector3(Random.Range(-20, 20), 0, Random.Range(0, 100));
        Instantiate(enemy1, pos1, enemy1.transform.rotation);

        pos1 = new Vector3(Random.Range(-20, 20), 0, Random.Range(0, 100));
        Instantiate(enemy1, pos1, enemy1.transform.rotation);

    }
	
	// Update is called once per frame
	void Update () {

        respawnElapsed += Time.deltaTime;
        if (respawnElapsed >= respawnTimer)
        {
            addEnemy();
            respawnElapsed = 0;
        }
    }

    void addEnemy()
    {
        pos1 = new Vector3(Random.Range(-20, 20), 0, Random.Range(0, 100));
        Instantiate(enemy1, pos1, enemy1.transform.rotation);
    }
}
