using UnityEngine;
using UnityEngine.SceneManagement;

public class WinArea : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int pointsToWin = 10;
    public string level;
    public RectTransform winPanel;

    private PlayerController playerController;



    void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<PlayerController>().points >= pointsToWin)
        {
            if (other.CompareTag("Player") == true)
            {
                winPanel.gameObject.SetActive(true);
                playerController.enabled = false;
            }
        }
    }

    public void LoadNewLevel()
    {
        SceneManager.LoadScene(level);
    }

    void Start()
    {
        winPanel.gameObject.SetActive(false);
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        Resume();

    }

    public void Resume()
    {
        playerController.enabled = true;

    }

 

    // Update is called once per frame
    void Update()
    {

    }
}
