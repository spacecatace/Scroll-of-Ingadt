using UnityEngine;

public class EnemyStats : Stats
{
    protected override void Start() {
        base.Start();
        moveSpeed = 5f;
    }
    // Override the Die() function to add enemy death logic
    public override void Die()
    {
        base.Die();
    }
}
