using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Rigidbody ball;
    bool dead = false;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        ball =  GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = ball.transform.position.z ;
        float y = x + 13.56f;
        score.text = ((int)y).ToString();
        print((int)y);

        if (ball.transform.position.y < -2f && !dead)
        {
            print("Dead");
            die();
        }
    }


    public void die()
    {
        dead = true;
        Invoke(nameof(Reset_Level), 1f);
    }


    private void Reset_Level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
