using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public float speed = 8f;

    private Rigidbody rb;

    private Vector3 startPosition;

    public TMP_Text countdownText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        startPosition = transform.position;

        Launch();
    }

    void Launch()
    {
        float y = Random.value > 0.5f ? 1 : -1;
        float x = Random.Range(-0.3f, 0.3f);

        Vector3 dir = new Vector3(x, y, 0).normalized;

        rb.linearVelocity = dir * speed;
    }

    public void ResetBall()
    {
        rb.linearVelocity = Vector3.zero;

        transform.position = startPosition;

        StartCoroutine(CountdownAndLaunch());
    }

    System.Collections.IEnumerator CountdownAndLaunch()
    {
        countdownText.gameObject.SetActive(true);

        for (int i = 3; i > 0; i--)
        {
            countdownText.text = i.ToString();

            yield return new WaitForSeconds(1f);
        }

        countdownText.gameObject.SetActive(false);

        Launch();
    }

    void OnTriggerEnter(Collider other)
    {
        ScoreManager sm = FindObjectOfType<ScoreManager>();

        if (other.CompareTag("Goal_Top"))
        {
            Debug.Log("GOLO TOP");

            sm.topScore++;

            sm.GoalScored();

            ResetBall();
        }
        else if (other.CompareTag("Goal_Bottom"))
        {
            Debug.Log("GOLO BOTTOM");

            sm.bottomScore++;

            sm.GoalScored();

            ResetBall();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            if (collision.gameObject.TryGetComponent<Paddle>(out var paddle))
            {
                Vector3 vel = rb.linearVelocity;

                float randomX = Random.Range(-0.7f, 0.7f);

                if (paddle.Player1)
                    vel = new Vector3(randomX, 1f, 0).normalized * speed;
                else
                    vel = new Vector3(randomX, -1f, 0).normalized * speed;

                rb.linearVelocity = vel;

                FindObjectOfType<ScoreManager>().BallHit();
            }
        }
    }
}