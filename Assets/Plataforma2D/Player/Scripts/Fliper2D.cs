using UnityEngine;

public class Fliper2D : MonoBehaviour
{
    [SerializeField]  bool isFacingRightByDefault = true;
    Rigidbody2D rb;
    SpriteRenderer sprite;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        sprite= rb.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Flip2D();
    }
    private void Flip2D()
    {
        //gestiona el Flip

        //si nos movemos a la derecha
        //if (rb.linearVelocityX)
    }
}
