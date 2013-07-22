#pragma strict
    /// This script moves the character controller forward 
    /// and sideways based on the arrow keys.
    /// It also jumps when pressing space.
    /// Make sure to attach a character controller to the same game object.
    /// It is recommended that you make only one call to Move or SimpleMove per frame.        
    var speed :   float = 3.0;
    var runSpeed: float = 5.0;
    var rotateSpeed : float = 3.0;
    var stamina : int = 100;
    function Update () {
        var controller : CharacterController = GetComponent(CharacterController);
        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
        
        // Move forward / backward
        var forward : Vector3 = transform.TransformDirection(Vector3.forward);
       
        var curSpeed : float = speed * Input.GetAxis ("Vertical");
        
        if(Input.GetKey(KeyCode.LeftShift)) {
        	curSpeed = runSpeed * Input.GetAxis ("Vertical");
        }
        controller.SimpleMove(forward * curSpeed);
    }
    @script RequireComponent(CharacterController)