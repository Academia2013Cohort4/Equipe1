var CrosshairTexture : Texture2D;
 
var UseTexture : Texture2D;
 
var NormalTexture : Texture2D;
     
var ShowCrosshair : boolean = true;
 
var CanChange : boolean = false;
         
function Start()
{      
        Screen.lockCursor = true;
}
         
function OnGUI()
{
        if(ShowCrosshair == true)
        {
        GUI.Label(Rect((Screen.width - CrosshairTexture.width) /2, (Screen.height -
                        CrosshairTexture.height) /2, CrosshairTexture.width, CrosshairTexture.height), CrosshairTexture);
        }
 
}
 
 
function OnTriggerEnter(other : Collider)
{
        if(other.gameObject.tag == "Door")
        {
                CanChange = false;
       
                CrosshairTexture = UseTexture;
       
        }
 
}
 
function OnTriggerExit(other : Collider)
{
        if(other.gameObject.tag == "Door")
        {
                CanChange = true;
       
                CrosshairTexture = NormalTexture;
               
               
        }
 
}
 
function TextureChange(){
 
if(!CanChange)
{
 
CrosshairTexture = UseTexture;
 
CanChange = true;
 
}
 
}
 
function BackToNormal(){
 
if(CanChange)
{
 
CanChange = false;
 
CrosshairTexture = NormalTexture;
}
 
}