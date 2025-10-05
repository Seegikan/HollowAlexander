using UnityEngine;

public class Attack : MonoBehaviour
{
    [Header("Ajustes de ataque")]
    public float attackRange = 0.8f;
    public int attackDamage = 1;
    public float attackCooldown = 0.3f;

    [Header("Puntos de ataque")]
    public Transform attackPointSide;
    public Transform attackPointUp;

    [Header("Capas de enemigos")]
    public LayerMask enemyLayers;

    private float nextAttackTime = 0f;
    private bool attckRight = true; // cambia según tu movimiento

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Control del cooldown
        if (Time.time < nextAttackTime) return;

        // Detectar entrada de ataque
        if (Input.GetButtonDown("Fire1")) // puedes mapearlo en Input Manager
        {
            AttackInterraction();
        }
    }

    private void AttackInterraction()
    {
        nextAttackTime = Time.time + attackCooldown;

        // Detectar dirección
        Vector2 inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Transform attackPoint = attackPointSide;

        if (inputDir.y > 0.5f)
        {
            attackPoint = attackPointUp;
            animator.SetTrigger("AttackUp");
        }
        else
        {
            animator.SetTrigger("AttackSide");
        }

        // Detectar enemigos en rango
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            // Daño al enemigo
            enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPointSide != null)
            Gizmos.DrawWireSphere(attackPointSide.position, attackRange);
        if (attackPointUp != null)
            Gizmos.DrawWireSphere(attackPointUp.position, attackRange);
    }

    // Método auxiliar para girar el personaje (puedes integrarlo con tu script de movimiento)
    public void Flip(bool faceRight)
    {
        attckRight = faceRight;
        Vector3 scale = transform.localScale;
        scale.x = attckRight ? Mathf.Abs(scale.x) : -Mathf.Abs(scale.x);
        transform.localScale = scale;
    }
}
