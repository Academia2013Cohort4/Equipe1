var soundToPlay:AudioClip;

function OnTriggerEnter () { audio.PlayOneShot(soundToPlay);
}

TriggerTexture Script:
var Text : GUITexture;



function Start(){ Text.enabled = false;

}




function OnTriggerEnter(){ Text.enabled = true;

}




function OnTriggerExit(){ Text.enabled = false;

}