using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startState;

    private State state;

    // Start is called before the first frame update
    void Start()
    {
        this.state = this.startState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                this.state = nextStates[index];
            }
        }

        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            this.state = nextStates[0];

        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            this.state = nextStates[1];
        }*/

        this.textComponent.text = this.state.GetStateStory();
    }
}
