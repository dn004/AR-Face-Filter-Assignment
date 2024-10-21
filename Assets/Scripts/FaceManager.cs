using UnityEngine;
using UnityEngine.UI;


public class FaceManager : MonoBehaviour
{
    public Button goBlue;
    public Button goYellow;
    public Button goGreen;


    private GameObject myFilter;
    private MeshRenderer myMesh;

    private void Start()
    {
        goBlue.onClick.AddListener(() =>
        {
            Transformer();
            myMesh.material.color = Color.blue;
        });

        goYellow.onClick.AddListener(() =>
        {
            Transformer();
            myMesh.material.color = Color.yellow;
        }
        );

        goGreen.onClick.AddListener(() =>
        {
            Transformer();
            myMesh.material.color = Color.green;
        });
    }

    public void Transformer()
    {
        myFilter = GameObject.FindGameObjectWithTag("face");
        if(myFilter != null)
        {
            myMesh = myFilter.GetComponent<MeshRenderer>(); 
        }
    }



}


