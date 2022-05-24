using UnityEngine;
using UnityEngine.SceneManagement;

public class WinArea : MonoBehaviour
{
    // Start is called before the first frame update
    public int pointsToWin = 10;
    public string level;
    public RectTransform winPanel;
    


    void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<PlayerController>().points >= pointsToWin)
        {
            if (other.CompareTag("Player") == true)
            {
                winPanel.gameObject.SetActive(true);
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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
