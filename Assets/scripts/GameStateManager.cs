using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    GameBaseState currentState;

    public AberturaGameState telaInicialState = new AberturaGameState();
    public CreditosGameState telaCreditosState = new CreditosGameState();
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


}
