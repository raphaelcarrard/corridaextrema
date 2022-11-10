using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public static CarController instance;
    public float carSpeed, velocidade = 15f, maximo = 4f, mapaLargura = 1f;
    Vector3 position;
    public UIManager ui;
    public AudioManager am;
    public TrackMove trackMov;
    private Rigidbody2D rigidbody;

    void Awake()
    {
        Instance();
    }

    void Instance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCarro();
    }

    void MoveCarro()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * velocidade;
        Vector2 novaPosicao = rigidbody.position + Vector2.right * x;
        novaPosicao.x = Mathf.Clamp(novaPosicao.x, -mapaLargura, mapaLargura);
        rigidbody.MovePosition(novaPosicao);
    }

// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartSound", 9f, 12000f);
        position = transform.position;
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void StartSound()
    {
        am.carSound.Play();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);
            ui.gameOver();
            am.carSound.Stop();
            trackMov.speed = 0;
        }
    }
}

