using UnityEngine;
public class Food : MonoBehaviour    {
    public BoxCollider2D gridArea;

    private void Start()   {
        // comida nasce em um local aleatório.
        RandomizePosition();
    }
    public void RandomizePosition()    {
        Bounds bounds = gridArea.bounds;
        // Escolhe uma posição aleatória dentro dos limites do gridArea
        // Arredonda os valores para garantir o alinhamento com o grid
        int x = Mathf.RoundToInt(Random.Range(bounds.min.x, bounds.max.x));
        int y = Mathf.RoundToInt(Random.Range(bounds.min.y, bounds.max.y));
        // move a comida para a nova posição aleatória (dentro do 	// gridArea definido para o jogo)
	    transform.position = new Vector2(x, y);
    }
    // chamado toda vez que o isTrigger sinaliza, ou seja, quando uma    
    // colisão ocorre de alguém com o objeto Food.
    private void OnTriggerEnter2D(Collider2D other)    {
        // toda vez que a comida for capturada (colidir) pela cobra
        // ela é movida para (“ressurge em”) outro local.
        if (other.tag == "Player")    {
            RandomizePosition();
        }
    }
}

