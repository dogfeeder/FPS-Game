using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    public GameObject winText;

    private float restartTimer = 2.5f;
    private float currentTimer = 0;

    private bool win;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            win = true;
        }
    }

    void Update()
    {
        if (win)
        {
            winText.SetActive(true);
            currentTimer += Time.deltaTime;
            if (currentTimer >= restartTimer)
            {
                SceneManager.LoadScene("fps base");
            }
        }
    }
}
