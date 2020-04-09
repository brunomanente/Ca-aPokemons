using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{
    public DontDestroyThis objetoMusica;

    AudioSource minhaMusica;

    public float volume = 100f;

    public Text volumeVisor;

    public AudioClip musica1;
    public AudioClip musica2;


    void Start()
    {
        minhaMusica = FindObjectOfType<DontDestroyThis>().GetComponent<AudioSource>();

    }

    public void Play()
    {
        minhaMusica.Play();
    }
    public void Stop()
    {
        minhaMusica.Stop();
    }
    public void Aumentar()
    {
        if(volume < 100)
        {
            volume += 10;
            volumeVisor.text = "Volume: " + volume;
            minhaMusica.volume = volume/100;
        }


    }

    public void Diminuir()
    {
        if(volume > 0)
        {
            volume -= 10;
            volumeVisor.text = "Volume:" + volume;
            minhaMusica.volume = volume / 100;
        }
    }

    public void TocarMusica1()
    {
        minhaMusica.Stop();
        minhaMusica.clip = musica1;
        minhaMusica.Play();
    }
    public void TocarMusica2()
    {
        minhaMusica.Stop();
        minhaMusica.clip = musica2;
        minhaMusica.Play();
    }
    public void AbrirConfiguracoes()
    {
        SceneManager.LoadScene("CenaConfiguracoes");
    }

    public void AbrirRanking()
    {
        SceneManager.LoadScene("CenaRanking");
    }

    public void AbrirInicio()
    {
        SceneManager.LoadScene("CenaInicio");
    }

    public void AbrirCenaTutorial()
    {
        SceneManager.LoadScene("CenaTutorial");
    }

    public void AbrirCenaFim()
    {
        SceneManager.LoadScene("CenaFim");
    }

    public void AbrirCenaJogo()
    {
        SceneManager.LoadScene("CenaJogo");
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
