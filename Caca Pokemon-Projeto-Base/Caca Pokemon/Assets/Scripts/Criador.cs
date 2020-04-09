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

    public void chocaPokemon()
    {
        int quantidade = 3;
        for(int i = 0; i < quantidade ; i++)
        {
            Vector3 pokemonPosicao = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            Instantiate(pokemon, pokemonPosicao, Quaternion.identity);
        }
    }


    private void Update()
    {
        TempoRestante -= Time.deltaTime;
        contador.text = "Tempo Restante \n" + Mathf.Round(TempoRestante) + " Segundos";

        if(TempoRestante < -5)
        {
            SceneManager.LoadScene("CenaFim");

        }else if(TempoRestante < 0)
        {
            contador.text = "Tempo\nEsgotado";
        }else if(TempoRestante < 10)
        {
            contador.color = Color.red;
        }else if(TempoRestante < 30)
        {
            contador.color = Color.yellow;
        }
    }

}
