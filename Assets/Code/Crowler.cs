using UnityEngine;

public class Crowler : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed = 2f;             // Velocidad de movimiento
    public bool movingRight = true;      // Dirección inicial

    [Header("Detección")]
    public Transform groundCheck;        // Punto desde donde se lanza el raycast hacia abajo
    public Transform wallCheck;          // Punto desde donde se lanza el raycast hacia adelante
    public float checkDistanceX = 1f;   // Distancia del raycast
    public float checkDistanceY = 0.3f;   // Distancia del raycast
    public LayerMask ayerMaskWall;       // Capas consideradas suelo/pared

    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        // Operador ternario para dirección, primer valor si es true, segundo si es false
        float moveDir = movingRight ? 1f : -1f;
        rb.linearVelocity = new Vector2(moveDir * speed, rb.linearVelocity.y);

        // Detectar pared y falta de suelo
        bool hitWall = Physics2D.Raycast(wallCheck.position, movingRight ? Vector2.right : Vector2.left, checkDistanceX, ayerMaskWall);
        bool noGround = !Physics2D.Raycast(groundCheck.position, Vector2.down, checkDistanceY, ayerMaskWall);



        // Cambiar dirección
        if (hitWall || noGround)
        {
            Flip();
        }
    }

    private void Update()
    {
        // Debug Rays
        Debug.DrawRay(wallCheck.position, (movingRight ? Vector2.right : Vector2.left) * checkDistanceX, Color.red);
        //CircleCast
        Debug.DrawRay(groundCheck.position, Vector2.down * checkDistanceY, Color.blue);
        
    }

    void Flip()
    {
        Debug.Log("Flip");
        //rb.linearVelocity = new Vector2(0, rb.linearVelocity.y); // Detener el movimiento horizontal antes de girar
        movingRight = !movingRight;
        // Invierte solo el sprite (no el transform completo)
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }

   

   
}
