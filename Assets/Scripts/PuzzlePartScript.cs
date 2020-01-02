using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePartScript : MonoBehaviour
{
    [Tooltip("List of animations that this puzzlePart can do, based on what color orb is used")] public Dictionary<string, Animation> actions = new Dictionary<string, Animation>(5);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate(string OrbColor)
    {
        if (actions.ContainsKey(OrbColor))
        {
            //Play animation with key OrbColor from dict actions
            Debug.Log("playAnimation" + OrbColor);
        }
    }
}
