using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{

    public int goalCountdown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (goalCountdown == 0)
        {
            StartCoroutine(Wait());
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.collider.gameObject);
            //Destroy(gameObject, 5);
            goalCountdown -= 1;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
    }
}
