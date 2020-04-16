using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameController : MonoBehaviour
{
    public Text pontuacao;

    public InputField nome;



    // Start is called before the first frame update
    


    public void Salvar()
    {
        PlayerPrefs.SetString("nomeJogador", nome.text);
        pontuacao.text = "PONTUACAO\n"+PlayerPrefs.GetString("nomeJogador") + " : " + PlayerPrefs.GetInt("PontosAtual");
        nome.text = "";

        SceneManager.LoadScene("CenaRanking");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
