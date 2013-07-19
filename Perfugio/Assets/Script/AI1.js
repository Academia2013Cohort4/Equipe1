var distance;
    var target : Transform;    
    var lookAtDistance = 15.0;
    var attackRange = 10.0;
    var moveSpeed = 5.0;
    var damping = 6.0;
    private var isItAttacking = false;
 
    function Update () 
    {
    distance = Vector3.Distance(target.position, transform.position);
 
    if(distance < lookAtDistance)
    {
    isItAttacking = false;
    renderer.material.color = Color.yellow;   // He sees you... you shouldn't get any closer. Just sayin'.
    lookAt ();
    }   
    if(distance > lookAtDistance)
    {
    renderer.material.color = Color.green;  // So now he just doesn't give a damn about you.
    }
    if(distance < attackRange)
    {
    attack ();
    }
    if(isItAttacking)
    {
    renderer.material.color = Color.red;   // When it's actually chasing you 'n shit. S'pretty awesome. Paul loves it. Michael too.
    }
}
 
 
function lookAt ()
{
var rotation = Quaternion.LookRotation(target.position - transform.position);
transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
}
 
function attack ()
{
    isItAttacking = true;
    renderer.material.color = Color.red;
 
    transform.Translate(Vector3.forward * moveSpeed *Time.deltaTime);
    
    
}

function OnTriggerEnter ( Enemy: Collider )
{
    if (Enemy.tag == "Player")
    {
        Application.LoadLevel ("GameOver");
    }
}