using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public GameObject focusPoint;
    public Slider healthSlider;
    public float health = 100.0f;

	public int currentAmmo = 30;

	// Use this for initialization
	void Start () {
        healthSlider.value = health;
	}
	
	// Update is called once per frame
	void Update () {
		//print (currentAmmo);
	}

    void takeDamage(float dmg) {
        health -= dmg;
        healthSlider.value = health;

        if (health <= 0)
        {
            SceneManager.LoadScene("fps base");
        }
    }
}
