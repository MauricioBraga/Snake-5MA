using UnityEngine;

public class AberturaGameState: GameBaseState  
{
    public override void enterState(GameStateManager gameState)  {
        Debug.Log("Entramos na tela inicial");
    }
    public override void updateState(GameStateManager gameState)  {
        
    }
    public override void leaveState(GameStateManager gameState)  {
        Debug.Log("Saindo na tela inicial");
    }
}
