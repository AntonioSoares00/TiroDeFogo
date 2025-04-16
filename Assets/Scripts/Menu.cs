using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [SerializeField] private AudioClip Som;
    private AudioSource player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Jogar()
    {
        TocarSom();
        Invoke("Personagens", 1f);
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Call()
    {
        SceneManager.LoadScene("Call");
    }

    public void PapaMike()
    {
        SceneManager.LoadScene("PapaMike");
    }

    public void Caussang()
    {
        SceneManager.LoadScene("Caussang");
    }

    public void Ghost()
    {
        SceneManager.LoadScene("Ghost");
    }

    private void TocarSom()
    {
        player.PlayOneShot(Som);
    }

    public void Personagens()
    {
        SceneManager.LoadScene("Personagens");
    }
}


