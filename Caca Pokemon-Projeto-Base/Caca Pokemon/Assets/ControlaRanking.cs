using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaRanking : MonoBehaviour
{

    public Text ListaCampioes;

   

    // Start is called before the first frame update
    void Start()
    {
        /*PlayerPrefs.SetString("nomeJogador1", "Joao");
        PlayerPrefs.SetInt("PontosJogador1", 300);

        PlayerPrefs.SetString("nomeJogador2", "Maria");
        PlayerPrefs.SetInt("PontosJogador2", 150);

        PlayerPrefs.SetString("nomeJogador3", "Fro");
        PlayerPrefs.SetInt("PontosJogador3", 100);*/

        MontaListaCampeoes();




        //ListaCampioes.text = PlayerPrefs.GetString("NomeJogador") + " - " + PlayerPrefs.GetInt("PontosAtual");
    }

   public void MontaListaCampeoes()
    {
        string suaPontuacao = "";

        if(PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador1"))
        {
            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosJogador2"));
            PlayerPrefs.SetInt("PontosJogador2", PlayerPrefs.GetInt("PontosJogador1"));
            PlayerPrefs.SetInt("PontosJogador1", PlayerPrefs.GetInt("PontosAtual"));

            PlayerPrefs.SetString("nomeJogador3", PlayerPrefs.GetString("nomeJogador2"));
            PlayerPrefs.SetString("nomeJogador2", PlayerPrefs.GetString("nomeJogador1"));
            PlayerPrefs.SetString("nomeJogador1", PlayerPrefs.GetString("nomeJogador"));

        }else if(PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador2"))
        {
            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosJogador2"));
            PlayerPrefs.SetInt("PontosJogador2", PlayerPrefs.GetInt("PontosAtual"));

            PlayerPrefs.SetString("nomeJogador3", PlayerPrefs.GetString("nomeJogador2"));
            PlayerPrefs.SetString("nomeJogador2", PlayerPrefs.GetString("nomeJogador"));
        }else if(PlayerPrefs.GetInt("PontosAtual")> PlayerPrefs.GetInt("PontosJogador3"))
        {
            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosAtual"));
            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosAtual"));
        }
        else
        {
            suaPontuacao = "\nSua Pontuacao: " + PlayerPrefs.GetInt("PontosAtual");
        }

        ListaCampioes.text = "1 - " + PlayerPrefs.GetString("nomeJogador1");
        ListaCampioes.text += " - " + PlayerPrefs.GetInt("PontosJogador1");

        ListaCampioes.text += "\n2 - " + PlayerPrefs.GetString("nomeJogador2");
        ListaCampioes.text += " - " + PlayerPrefs.GetInt("PontosJogador2");

        ListaCampioes.text += "\n3 - " + PlayerPrefs.GetString("nomeJogador3");
        ListaCampioes.text += " - " + PlayerPrefs.GetInt("PontosJogador3");

        ListaCampioes.text += suaPontuacao;


        PlayerPrefs.SetString("nomeJogador", "");
        PlayerPrefs.SetInt("PontosAtual", 0);
    }

    public void LimparRanking()
    {
        PlayerPrefs.SetString("nomeJogador1", "");
        PlayerPrefs.SetInt("PontosJogador1", 0);

        PlayerPrefs.SetString("nomeJogador2", "");
        PlayerPrefs.SetInt("PontosJogador2", 0);

        PlayerPrefs.SetString("nomeJogador3", "");
        PlayerPrefs.SetInt("PontosJogador3", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
