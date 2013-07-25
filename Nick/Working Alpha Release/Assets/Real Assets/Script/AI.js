var distance;
    var target : Transform;    
    var lookAtDistance = 200;
    var attackRange = 200;
    var moveSpeed = 2.5;
    var damping = 6.0;
    private var isItAttacking = false;
 
    function Update () 
    {
    distance = Vector2.Distance(target.position, transform.position);

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
 
     transform.position += transform.forward * moveSpeed * Time.deltaTime;   
    
}

