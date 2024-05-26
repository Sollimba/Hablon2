using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized;
        transform.Translate(movement * speed * Time.deltaTime);

        if (movement != Vector2.zero)
        {
            EventManager.RaisePlayerMove(movement);
        }
    }
}
