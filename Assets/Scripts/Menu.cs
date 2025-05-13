using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private AudioSource player; //Refer�ncia ao componente AudioSource
    [SerializeField] private AudioClip som; //Arquivo (Clip) de �udio a ser reproduzido

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<AudioSource>(); //Guarda a refer�ncia do AudioSource
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Personagens"); //Chama a fun��o SelecionaPersonagens ap�s 1 segundo
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void PapaMike()
    {
        SceneManager.LoadScene("PapaMike");   
    }

    public void GHOST()
    {
        SceneManager.LoadScene("GHOST");
    }

    public void CAUSSANG()
    {
        SceneManager.LoadScene("CAUSSANG");
    }

    public void CALL()
    {
        SceneManager.LoadScene("Call");
    }

    public void combate()
    {
        SceneManager.LoadScene("Combate");
    }

    private void TocarSom()
    {
        player.PlayOneShot(som);
    }

    public void SairDaFloresta()
    {
        TocarSom(); //Chama a fun��o para tocar o som
        Invoke("EscolhaFloresta", 1f); //Chama a fun��o EscolhaFloresta ap�s 1 segundo
    }

    private void EscolhaFloresta()
    {
        SceneManager.LoadScene("EscolhaFloresta");
    }

    public void BatalhaDaFlorestaEsquerda()
    {
        TocarSom(); //Chama a fun��o para tocar o som
        Invoke("FlorestaEsquerdaBatalha", 1f); //Chama a fun��o EscolhaFloresta ap�s 1 segundo
    }

    private void FlorestaEsquerdaBatalha()
    {
        SceneManager.LoadScene("FlorestaEsquerdaBatalha");
    }

    public void FlorestaEsquerda()
    {
        SceneManager.LoadScene("FlorestaEsquerda");
    }

    //Metodo gererico para carregar a cena

    public void CarregarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

}