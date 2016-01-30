using UnityEngine;
using System.Collections;

public class QuestPlane : MonoBehaviour {
    
    private MeshRenderer planeRenderer;

    [SerializeField]
    private Texture DoneTexture;


    void Start()
    {
        planeRenderer = gameObject.GetComponent<MeshRenderer>();
    }

	// Update is called once per frame
	void Update () {
        //Object doneTexture = Resources.Load("./Materials/quest_dummy_texture_DONE.png");

        planeRenderer.material.mainTexture = this.DoneTexture;

    }
}
