using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Criador : MonoBehaviour
{
    public GameObject pokemon;

    public Text contador;
    
    public float TempoRestante = 60f;

    private int limite = 10;

    public pokemon[] pokemons;

    private int quantidade = 5;

    public Text PontosVisor;

    private int PontosJogador = 0;


    public void AumentaPontos()
    {
        PontosJogador++;
        PontosVisor.text = "Pontos: " + PontosJogador;

    }

    public void chocaPokemon()
    {
        pokemons = FindObjectsOfType<pokemon>();
        if(pokemons.Length < limite)
        {
            
                for (int i = 0; i < quantidade; i++)
                {
                    Vector3 pokemonPosicao = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
                    Instantiate(pokemon, pokemonPosicao, Quaternion.identity);
                }
            
        }
       
    }
    
    void Start()
    {
        InvokeRepeating("chocaPokemon", 0.0f, 2.0f);
    }

    private void Update()
    {
        TempoRestante -= Time.deltaTime;
        contador.text = "Tempo Restante \n" + Mathf.Round(TempoRestante) + " Segundos";

        if(TempoRestante < -5)
        {
            PlayerPrefs.SetInt("PontosAtual", PontosJogador);
            SceneManager.LoadScene("CenaFim");

        }else if(TempoRestante < 0)
        {
            contador.text = "Tempo\nEsgotado";
        }else if(TempoRestante < 10)
        {
            limite = 10;
            quantidade = 15;
            contador.color = Color.red;
        }else if(TempoRestante < 30)
        {
            limite = 20;
            quantidade = 10;
            contador.color = Color.yellow;
        }
    }

}
