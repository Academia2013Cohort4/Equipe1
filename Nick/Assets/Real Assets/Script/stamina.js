/*var regenStaminaSpeed : float = 1.0;
var staminaLossWhilstWalking : float = 1.0;
var staminaLossWhilstRunning : float = 5.0;
var regenStaminaSpeed : float = 1.0;

// It would be clever to use a property here and clamp it between 0 and staminaMax.
var stamina : float = 1.0; 
var staminaMax : float = 1.0;
var tiredSpeed: float = 10.0;
var walkSpeed: float = 30.0;
var runSpeed: float = 50.0;
private enum MovementType{ Walking, Running, Still };
var moveType: MovementType = MovementType.Still ; // The kind of movement your char is doing
                                                  // It's related to the key pressed


function StaminaEvolution()
{
    while( Application.IsPlaying )
    {
        var staminaDelta = moveType == MovementType.Still ? Time.deltaTime * regenStaminaSpeed
        : moveType == MovementType.Walking ? -Time.deltaTime * staminaLossWhilstWalking
        : moveType == MovementType.Running ? -Time.deltaTime * staminaLossWhilstRunning
       
        : stamina = Mathf.Clamp( stamina + staminaDelta, 0, staminaMax );
        yield null;
    }
}


// ...
if( stamina < 0.01 ) // Beware of float imprecision with ==
    speed = tiredSpeed;
else
    speed = Input.GetKey (KeyCode.LeftShift) ? runSpeed : walkSpeed;*/