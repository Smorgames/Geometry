using UnityEngine;

public class HexagonScript : MonoBehaviour
{
    private float shrinkSpeed = 4f;
    public Rigidbody2D rb;

    private PlayerController playerController;

    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
        GameObject playerControllerObject = GameObject.FindWithTag("Player");
        playerController = playerControllerObject.GetComponent<PlayerController>();
    }

    void Update()
    {
        int playerScore = playerController.ScoreReturn();
        int remainderOfDivisionByTwenty = playerScore / 20;

        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime; //decrease size of hexagon

        if (playerScore >= 0 + remainderOfDivisionByTwenty && playerScore < 20 + remainderOfDivisionByTwenty) //by each 20 points increase hexagon speed by 1
            shrinkSpeed = 4f + remainderOfDivisionByTwenty;

        if (transform.localScale.x <= 0.2f)
        {
            playerController.ScoreUpdate(1);
            Destroy(gameObject);
        }
    }
}
