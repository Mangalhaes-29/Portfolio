using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public bool isPlayer = true;
    public Transform ball;

    void Update()
    {
        if (isPlayer)
        {
            float move = Input.GetAxis("Vertical");
            transform.Translate(Vector3.up * move * speed * Time.deltaTime);
        }
        else
        {
            Vector3 pos = transform.position;
            pos.y = Mathf.Lerp(pos.y, ball.position.y, Time.deltaTime * 5f);
            transform.position = pos;
        }
    }
}
