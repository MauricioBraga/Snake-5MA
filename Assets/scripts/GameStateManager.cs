using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject player;
    public GameObject food;
    public GameObject parede1;
    public GameObject parede2;
    public GameObject parede3;
    public GameObject parede4;

    GameBaseState currentState;

    public AberturaGameState telaInicialState = new AberturaGameState();
    public CreditosGameState telaCreditosState = new CreditosGameState();
    public JogoGameState jogoState = new JogoGameState();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = telaInicialState;
        currentState.enterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.updateState(this);
    }

    public void switchState(GameBaseState state)  {
        currentState.leaveState(this);
        currentState = state;
        currentState.enterState(this);
    }

    public void AtivarElementosJogo(bool interruptor)      {
        player.GetComponent<SpriteRenderer>().enabled = interruptor;
        player.GetComponent<Snake>().setAtivo(interruptor);
        food.GetComponent<SpriteRenderer>().enabled = interruptor;
        parede1.GetComponent<SpriteRenderer>().enabled = interruptor;
        parede2.GetComponent<SpriteRenderer>().enabled = interruptor;
        parede3.GetComponent<SpriteRenderer>().enabled = interruptor;
        parede4.GetComponent<SpriteRenderer>().enabled = interruptor;
    }


}
