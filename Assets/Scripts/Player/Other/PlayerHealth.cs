using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public enum HealthStates {full, first, second, third}
    public HealthStates HealthState;

    private SpriteRenderer _sprite;

    [SerializeField]
    private GameObject[] _lives;
    [SerializeField]
    private float _health;

    private float _damage = 1f;
    [SerializeField]
    private float _damageTimer = 10f;

    private bool isHurt;

    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _health = 3;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Hazard")
        {
            if (!isHurt)
                StartCoroutine(InvinsibleTimer());
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Death")
        {
            Destroy(gameObject);
            transform.position = new Vector2(-15, -20);
            Application.LoadLevel(Application.loadedLevel);
            _health = 3;
            
        }
    }

    IEnumerator InvinsibleTimer()
    {
        float timer = 0;
        isHurt = true;
        _health -= _damage;

        while (timer<_damageTimer)
        {
            timer += Time.deltaTime;
            _sprite.color = Color.red;

            //Debug.Log(timer);
            yield return null;
        }
        _sprite.color = Color.white;
        isHurt = false;    
    }

    void Health()
    {
        if (HealthState == HealthStates.first)
        {
            Destroy(_lives[2]);
        }
        else if (HealthState == HealthStates.second)
        {
            Destroy(_lives[1]);
        }
        else if (HealthState == HealthStates.third)
        {
            Destroy(gameObject);
            transform.position = new Vector2(-15, -20);
            Application.LoadLevel(Application.loadedLevel);
            _health = 3;
            Destroy(_lives[0]);
            //Destroy(gameObject);
            //Debug.Log("You died.");
        }
    }

    void Update()
    {
        if (_health == 3)
        {
            HealthState = HealthStates.full;
        }
        else if (_health == 2)
        {
            HealthState = HealthStates.first;
        }
        else if (_health == 1)
        {
            HealthState = HealthStates.second;
        }
        else if (_health <= 0)
        {
            HealthState = HealthStates.third;
        }

         Health();
    }
}
