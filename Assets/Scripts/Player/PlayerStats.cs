using UnityEngine;

public class PlayerStats : Stats
{
    // Override the Die() function to add a game over screen
    public override void Die()
    {
        // Death sounds, animations, respawn logic etc. can go here
        Debug.Log(gameObject.name + " died.");
        // Add a game over screen here
        Destroy(gameObject);
    }
}
