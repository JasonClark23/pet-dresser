using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeParts : MonoBehaviour {

// Ears Setup
    SpriteRenderer srEars;
    public Sprite[] newSpriteEars;
    public int spriteCountMaxEars;
    private int spriteCountEars;

// Eyes Setup
    SpriteRenderer srEyes;
    public Sprite[] newSpriteEyes;
    public int spriteCountMaxEyes;
    private int spriteCountEyes;

// Nose Setup
    SpriteRenderer srNose;
    public Sprite[] newSpriteNose;
    public int spriteCountMaxNose;
    private int spriteCountNose;

// Mouth Setup
    SpriteRenderer srMouth;
    public Sprite[] newSpriteMouth;
    public int spriteCountMaxMouth;
    private int spriteCountMouth;

    private void Awake() // Initializes spritesheets in resources folder at game startup
    {
//Ears
        newSpriteEars = Resources.LoadAll<Sprite>("layoutGridEars"); 

//Eyes
        newSpriteEyes = Resources.LoadAll<Sprite>("layoutGridEyes");

//Nose
    newSpriteNose = Resources.LoadAll<Sprite>("layoutGridNose");

//Mouth
    newSpriteMouth = Resources.LoadAll<Sprite>("layoutGridMouth");


    } //Don't copy

private void Start() // Initializes everything when script is first used
    {
//Ears
        spriteCountEars = 0;
        srEars = GameObject.Find("Ears").GetComponent<SpriteRenderer>();

//Eyes
        spriteCountEyes = 0;
        srEyes = GameObject.Find("Eyes").GetComponent<SpriteRenderer>();

//Nose
    spriteCountNose = 0;
    srNose = GameObject.Find("Nose").GetComponent<SpriteRenderer>();

//Mouth
    spriteCountMouth = 0;
    srMouth = GameObject.Find("Mouth").GetComponent<SpriteRenderer>();


} //Don't copy



// EARS Change Control
    public void EarsForward()
    {
        Debug.Log ("Moving Ears Forward");
        if (spriteCountEars < spriteCountMaxEars)
        {
            spriteCountEars++;
        }
        else
        {
            spriteCountEars = 0;
        }

        Debug.Log(newSpriteEars[spriteCountEars]);

        srEars.sprite = newSpriteEars[spriteCountEars];   
    }

    public void EarsReverse()
    {
        Debug.Log("Moving Ears Reverse");
        if (spriteCountEars > 0)
        {
            spriteCountEars--;
        }
        else
        {
            spriteCountEars = spriteCountMaxEars;
        }

        Debug.Log(newSpriteEars[spriteCountEars]);

        srEars.sprite = newSpriteEars[spriteCountEars];
    }


// Eyes Change Control
    public void EyesForward()
    {
        Debug.Log("Moving Eyes Forward");
        if (spriteCountEyes < spriteCountMaxEyes)
        {
            spriteCountEyes++;
        }
        else
        {
            spriteCountEyes = 0;
        }

        Debug.Log(newSpriteEyes[spriteCountEyes]);

        srEyes.sprite = newSpriteEyes[spriteCountEyes];
    }

    public void EyesReverse()
    {
        Debug.Log("Moving Eyes Reverse");
        if (spriteCountEyes > 0)
        {
            spriteCountEyes--;
        }
        else
        {
            spriteCountEyes = spriteCountMaxEyes;
        }

        Debug.Log(newSpriteEyes[spriteCountEyes]);

        srEyes.sprite = newSpriteEyes[spriteCountEyes];
    }


// Nose Change Control
    public void NoseForward()
    {
        Debug.Log("Moving Nose Forward");
        if (spriteCountNose < spriteCountMaxNose)
        {
            spriteCountNose++;
        }
        else
        {
            spriteCountNose = 0;
        }

        Debug.Log(newSpriteNose[spriteCountNose]);

        srNose.sprite = newSpriteNose[spriteCountNose];
    }

    public void NoseReverse()
    {
        Debug.Log("Moving Nose Reverse");
        if (spriteCountNose > 0)
        {
            spriteCountNose--;
        }
        else
        {
            spriteCountNose = spriteCountMaxNose;
        }

        Debug.Log(newSpriteNose[spriteCountNose]);

        srNose.sprite = newSpriteNose[spriteCountNose];
    }

// Mouth Change Control
    public void MouthForward()
    {
        Debug.Log("Moving Mouth Forward");
        if (spriteCountMouth < spriteCountMaxMouth)
        {
            spriteCountMouth++;
        }
        else
        {
            spriteCountMouth = 0;
        }

        Debug.Log(newSpriteMouth[spriteCountMouth]);

        srMouth.sprite = newSpriteMouth[spriteCountMouth];
    }

    public void MouthReverse()
    {
        Debug.Log("Moving Mouth Reverse");
        if (spriteCountMouth > 0)
        {
            spriteCountMouth--;
        }
        else
        {
            spriteCountMouth = spriteCountMaxMouth;
        }

        Debug.Log(newSpriteMouth[spriteCountMouth]);

        srMouth.sprite = newSpriteMouth[spriteCountMouth];
    }

} // Don't copy!
