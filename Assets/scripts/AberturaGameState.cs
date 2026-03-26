using UnityEngine;

public class AberturaGameState: GameBaseState  
{
    private float tempo_mudança = 0.5f;
    private float timer;
    private int contador;
    private GameObject telaInicialJogo;

    private GameObject sfxTelaInicialJogo;

    public override void enterState(GameStateManager gameState)  {
        Debug.Log("Entramos na tela inicial");
        telaInicialJogo = GameObject.Find("tela_nova_inicial_Snake_1280_1060_0");
        telaInicialJogo.GetComponent<SpriteRenderer>().enabled = true;
        timer = 0;
        contador = 15;
        sfxTelaInicialJogo = GameObject.Find("snake-hissing");
        sfxTelaInicialJogo.GetComponentInParent<AudioSource>().Play();
    }
    public override void updateState(GameStateManager gameState)  {
        if (timer < tempo_mudança)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            contador--;
            timer = 0;
            if (contador < 0)  
               gameState.switchState(gameState.jogoState); 
        }
        if (Input.GetKeyDown(KeyCode.Space))  {
            gameState.switchState(gameState.jogoState);
        }
    }
    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo na tela inicial");
        telaInicialJogo.GetComponent<SpriteRenderer>().enabled = false;
        sfxTelaInicialJogo.GetComponentInParent<AudioSource>().Stop();
    }
}
