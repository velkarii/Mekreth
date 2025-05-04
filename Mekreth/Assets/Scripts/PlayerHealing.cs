using UnityEngine;

public class PlayerHealing : MonoBehaviour
{
    public KeyCode healKey = KeyCode.I;
    public int healAmount = 25;
    public float healCooldown = 5f;

    private float nextHealTime = 0f;
    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(healKey) && Time.time >= nextHealTime)
        {
            playerHealth.Heal(healAmount);
            nextHealTime = Time.time + healCooldown;
            Debug.Log("Healing used! Next heal available at: " + nextHealTime);
        }
    }
}
