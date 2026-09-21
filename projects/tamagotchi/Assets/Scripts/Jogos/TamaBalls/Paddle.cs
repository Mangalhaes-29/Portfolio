using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10f;

    public bool Player1 = false;

    public Transform ball;

    void Update()
    {
        if (Player1)
        {
            float move = GameInput.Instance.horizontal;

            transform.position +=
                new Vector3(move, 0, 0) *
                speed *
                Time.deltaTime;
        }
        else
        {
            Vector3 pos = transform.position;

            pos.x = Mathf.Lerp(
                pos.x,
                ball.position.x,
                Time.deltaTime * 4f
            );

            transform.position = pos;
        }

        Vector3 clampPos = transform.position;

        clampPos.x = Mathf.Clamp(clampPos.x, -101f, 100f);

        transform.position = clampPos;
    }
}