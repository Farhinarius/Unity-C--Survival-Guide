using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 3;
    public Vector3 startPosition = new Vector3 (0, 0, 0);
    Vector3 inputMovement;
    float hr, vr;

    public int maxHealth = 3;
    public int health { get { return currentHealth; } }
    int currentHealth;

    public float timeInvincible = 0.5f;
    bool isInvincible;
    float invincibleTimer;

    int totalScore;

    public int getTotalScore()
    {
        return totalScore;
    }


    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
        currentHealth = maxHealth;
        totalScore = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        Control();
        CheckInvincible();
        
        if (Input.GetKeyDown(KeyCode.P))
            GenerateWeapon();
    }

    // Add points to total score
    private void OnTriggerEnter(Collider other)
    {
        if (other!= null && other.tag == "PowerUp")
        {
            Destroy(other.gameObject);
            ChangeTotalScore(5);
            Debug.Log("Score must be changed");
        }
    }

    void OnCollisionEnter(Collision other) {
        if (other != null && other.collider.tag == "Heal")
        {
            Destroy(other.gameObject);
            ChangeHealth(1);
            Debug.Log("Healing + 1");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other != null && other.tag == "DangerZone")
        {
            ChangeHealth(-1);
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void Control()
    {
        hr = Input.GetAxis("Horizontal");
        vr = Input.GetAxis("Vertical");
        inputMovement = new Vector3(hr, 0, vr);
        transform.Translate(inputMovement * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 4 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.down * 4 * Time.deltaTime);
        }
    }

    private void ChangeHealth(int amount)
    {
        if (amount < 0)     // if damage taken
        {
            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTimer = timeInvincible;
            Debug.Log("Damage taken");
        }
        else
        {
            Debug.Log($"Heal Player on amount {amount}");
        }

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
    }

    private void ChangeTotalScore(int points)
    {
        totalScore += points;
    }

    void CheckInvincible()
    {
        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
            {
                isInvincible = false;
            }
        }
    }

    public AssaultRifle[] af;

    void GenerateWeapon()
    {
/*         Weapon longeRangeWeapon = new Weapon(5,5,5);
        longeRangeWeapon.GetData(); */

        foreach (var weapon in af)
        {
            weapon.GetData();
        }
    }
}
