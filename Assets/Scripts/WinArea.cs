using UnityEngine;
using UnityEngine.SceneManagement;

public class WinArea : MonoBehaviour
{
    // Start is called before the first frame update
    public string level;
    public RectTransform winPanel;
    


    void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<PlayerController>().points >= 10)
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
