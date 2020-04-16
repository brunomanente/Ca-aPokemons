using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemon : MonoBehaviour
{
    public Sprite[] Modelos;

    private SpriteRenderer sr;

    private Criador criador;

    public void OnMouseDown()
    {
        criador.AumentaPontos();
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = Modelos[Random.RandomRange(0, Modelos.GetLength(0))];
        criador = FindObjectOfType<Criador>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
