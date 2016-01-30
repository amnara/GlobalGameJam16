using UnityEngine;
using System.Collections;

public class Quest
{
    string QuestDesc;
    bool QuestStatus = false;

    TextMesh QuestMesh;

    public Quest()
    {
        this.QuestDesc = "This is a new quest!";
        this.QuestStatus = false;

    }

    public Quest(string questDesc)
    {
        this.QuestDesc = questDesc;
    }

    public void BuildMesh()
    {
        this.QuestMesh = new TextMesh();
        this.QuestMesh.text = this.QuestDesc;

    }

}

public class QuestLog : MonoBehaviour {

    //List of all quests 
    Quest[] AllQuests = new Quest[2];

	// Use this for initialization
	void Start () {
	    
	}
}
