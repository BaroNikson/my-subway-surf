
using UnityEngine;
using UnityEngine.SceneManagement;

public class RUn : MonoBehaviour
{
    private Animator anim;
    private CharacterController controller;
    private float positionX = 0f;
    private float speed = 2f;
    [SerializeField] private GameObject endUI;
    private void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        controller.Move(new Vector3(positionX - transform.position.x, 0, speed * Time.deltaTime));
    }
    public void SwipeLeft()
    {
        if (transform.position.x == 0 || transform.position.x == 1)
        {
            
            positionX -= 1;
            anim.Play("Left");
        }
    }
    public void SwipeRight()
    {
        
        if (transform.position.x == 0 || transform.position.x == -1)
        {
            
            positionX += 1;
            anim.Play("Right");
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            anim.Play("Death");
            endUI.SetActive(true);
            GetComponent<Controller>().enabled = false;
            GetComponent<RUn>().enabled = false;

        }
    }
   

}
