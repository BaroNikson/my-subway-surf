
using UnityEngine;
using UnityEngine.UI;



public class Controller : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text coinsText;
    private int coinsCount = 0;
    private int scoreCount = 0;
     void Start()
    {
        scoreText.text = scoreCount.ToString();
        coinsText.text = coinsCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {

            coinsCount += 1;
            coinsText.text = coinsCount.ToString();
            Destroy(other.gameObject);

        }
    }
     void Update()
    {
        scoreCount += 1;
        scoreText.text = scoreCount.ToString();
    }
}
