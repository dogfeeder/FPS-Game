using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public GameObject focusPoint;
    public Slider healthSlider;
    public float health = 100.0f;

	public int currentAmmo = 30;

    private float timer = 2.5f;
    private float time = 0;

    public GameObject loseText;
    private bool lose;

	// Use this for initialization
	void Start () {
        healthSlider.value = health;
	}
	
	// Update is called once per frame
	void Update () {
        //print (currentAmmo);

        if (lose)
        {
            time += Time.deltaTime;
            if (time > timer)
            {
                SceneManager.LoadScene("fps base");
            }
        }
	}

    void takeDamage(float dmg) {
        health -= dmg;
        healthSlider.value = health;

        if (health <= 0)
        {
            lose = true;
            loseText.SetActive(true);
        }
    }
}
