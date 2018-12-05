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
    
//Eyes Mask Setup
    SpriteMask srEyesMask;
    public Sprite[] newSpriteEyesMask;

//Pupils Setup
    SpriteRenderer srPupils;
    public Sprite[] newSpritePupils;
    public int spriteCountMaxPupils;
    private int spriteCountPupils;


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

// Head Setup
    SpriteRenderer srHead;
    public Sprite[] newSpriteHead;
    public int spriteCountMaxHead;
    private int spriteCountHead;

// Body Setup
    SpriteRenderer srBody;
    public Sprite[] newSpriteBody;
    public int spriteCountMaxBody;
    private int spriteCountBody;

 // Color Palette Setup
    private Color32[] colorPalette = { new Color32(255, 255, 255, 255),
        new Color32(85, 239, 196, 255), new Color32(129, 236, 236, 255), new Color32(116, 185, 255, 255), new Color32(162, 155, 254, 255), new Color32(223, 230, 233, 255),
        new Color32(0, 184, 148, 255), new Color32(0, 206, 201, 255), new Color32(9, 132, 227, 255), new Color32(108, 92, 231, 255), new Color32(178, 190, 195, 255),
        new Color32(255, 234, 167, 255), new Color32(250, 177, 160, 255), new Color32(255, 118, 117, 255), new Color32(253, 121, 168, 255), new Color32(99, 110, 114, 255),
        new Color32(253, 203, 110, 255), new Color32(225, 112, 85, 255), new Color32(214, 48, 49, 255), new Color32(232, 67, 147, 255), new Color32(45, 52, 54, 255)
                                    };

// Base Color Setup 
    private Color32[] colorBase;
    public int colorCountMaxBase;
    private int colorCountBase;

// Pupils Color setup
    private Color32[] colorPupils;
    public int colorCountMaxPupils;
    private int colorCountPupils;

    private void Awake() 
    {
        // Initializes spritesheets in resources folder at game startup
//Ears
        newSpriteEars = Resources.LoadAll<Sprite>("layoutGridEars"); 

//Eyes
        newSpriteEyes = Resources.LoadAll<Sprite>("layoutGridEyes");
        newSpriteEyesMask = Resources.LoadAll<Sprite>("layoutGridEyesMask");

// Pupils
        newSpritePupils = Resources.LoadAll<Sprite>("layoutGridPupils");

//Nose
        newSpriteNose = Resources.LoadAll<Sprite>("layoutGridNose");

//Mouth
        newSpriteMouth = Resources.LoadAll<Sprite>("layoutGridMouth");

//Head
        newSpriteHead = Resources.LoadAll<Sprite>("layoutGridHead");

//Body
        newSpriteBody = Resources.LoadAll<Sprite>("layoutGridBody");

        //Setup color arrays based off colorPalette array

        colorBase = colorPalette;
        colorPupils = colorPalette;

    } //Don't ever copy this bracket

private void Start() // Initializes everything when script is first used
    {
//Ears
        spriteCountEars = 0;
        srEars = GameObject.Find("Ears").GetComponent<SpriteRenderer>();

//Eyes
        spriteCountEyes = 0;
        srEyes = GameObject.Find("Eyes").GetComponent<SpriteRenderer>();
        srEyesMask = GameObject.Find("EyesMask").GetComponent<SpriteMask>();

//Pupils
    spriteCountPupils = 0;
    srPupils = GameObject.Find("Pupils").GetComponent<SpriteRenderer>();

//Nose
    spriteCountNose = 0;
    srNose = GameObject.Find("Nose").GetComponent<SpriteRenderer>();

//Mouth
    spriteCountMouth = 0;
    srMouth = GameObject.Find("Mouth").GetComponent<SpriteRenderer>();

//Head
    spriteCountHead = 0;
    srHead = GameObject.Find("Head").GetComponent<SpriteRenderer>();

//Body
    spriteCountBody = 0;
    srBody = GameObject.Find("Body").GetComponent<SpriteRenderer>();

//Base Color
    colorCountBase = 0;

//Pupil Color
    colorCountPupils = 0;

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
        srEyesMask.sprite = newSpriteEyesMask[spriteCountEyes];
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
        srEyesMask.sprite = newSpriteEyesMask[spriteCountEyes];
    }

// Pupils Change Control
    public void PupilsForward()
    {
        Debug.Log("Moving Pupils Forward");
        if (spriteCountPupils < spriteCountMaxPupils)
        {
            spriteCountPupils++;
        }
        else
        {
            spriteCountPupils = 0;
        }

        Debug.Log(newSpritePupils[spriteCountPupils]);

        srPupils.sprite = newSpritePupils[spriteCountPupils];
    }

    public void PupilsReverse()
    {
        Debug.Log("Moving Pupils Reverse");
        if (spriteCountPupils > 0)
        {
            spriteCountPupils--;
        }
        else
        {
            spriteCountPupils = spriteCountMaxPupils;
        }

        Debug.Log(newSpritePupils[spriteCountPupils]);

        srPupils.sprite = newSpritePupils[spriteCountPupils];
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

// Head Change Control
    public void HeadForward()
    {
        Debug.Log("Moving Head Forward");
        if (spriteCountHead < spriteCountMaxHead)
        {
            spriteCountHead++;
        }
        else
        {
            spriteCountHead = 0;
        }

        Debug.Log(newSpriteHead[spriteCountHead]);

        srHead.sprite = newSpriteHead[spriteCountHead];
    }

    public void HeadReverse()
    {
        Debug.Log("Moving Head Reverse");
        if (spriteCountHead > 0)
        {
            spriteCountHead--;
        }
        else
        {
            spriteCountHead = spriteCountMaxHead;
        }

        Debug.Log(newSpriteHead[spriteCountHead]);

        srHead.sprite = newSpriteHead[spriteCountHead];
    }

// Body Change Control
    public void BodyForward()
    {
        Debug.Log("Moving Body Forward");
        if (spriteCountBody < spriteCountMaxBody)
        {
            spriteCountBody++;
        }
        else
        {
            spriteCountBody = 0;
        }

        Debug.Log(newSpriteBody[spriteCountBody]);

        srBody.sprite = newSpriteBody[spriteCountBody];
    }

    public void BodyReverse()
    {
        Debug.Log("Moving Body Reverse");
        if (spriteCountBody > 0)
        {
            spriteCountBody--;
        }
        else
        {
            spriteCountBody = spriteCountMaxBody;
        }

        Debug.Log(newSpriteBody[spriteCountBody]);

        srBody.sprite = newSpriteBody[spriteCountBody];
    }

// Base Color Control
    public void ColorBaseForward()
    {
        Debug.Log("Moving Color Base Forward");
        if (colorCountBase < colorCountMaxBase)
        {
            colorCountBase++;
        }
        else
        {
            colorCountBase = 0;
        }

        Debug.Log(colorBase[colorCountBase]);

        srBody.color = colorBase[colorCountBase];
        srEars.color = colorBase[colorCountBase];
        srHead.color = colorBase[colorCountBase];
    }

    public void ColorBaseReverse()
    {
        Debug.Log("Moving Color Base Reverse");
        if (colorCountBase > 0)
        {
            colorCountBase--;
        }
        else
        {
            colorCountBase = colorCountMaxBase;
        }

        Debug.Log(colorBase[colorCountBase]);

        srBody.color = colorBase[colorCountBase];
        srEars.color = colorBase[colorCountBase];
        srHead.color = colorBase[colorCountBase];
    }

// Pupils Color Control
    public void ColorPupilsForward()
    {
        Debug.Log("Moving Color Pupils Forward");
        if (colorCountPupils < colorCountMaxPupils)
        {
            colorCountPupils++;
        }
        else
        {
            colorCountPupils = 0;
        }

        Debug.Log(colorPupils[colorCountPupils]);

        srPupils.color = colorPupils[colorCountPupils];
    }

    public void ColorPupilsReverse()
    {
        Debug.Log("Moving Color Pupils Reverse");
        if (colorCountPupils > 0)
        {
            colorCountPupils--;
        }
        else
        {
            colorCountPupils = colorCountMaxPupils;
        }

        Debug.Log(colorPupils[colorCountPupils]);

        srPupils.color = colorPupils[colorCountPupils];
    }

} // Don't copy!
