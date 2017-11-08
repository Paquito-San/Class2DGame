using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {

    //State
    [Header("State")]
     public bool isGrounded;
     public bool wasGroundedLastFrame;
     public bool justGotGrounded;
     public bool justNOTGrounded;
     public bool isFalling;

     public bool isTouchingWall;
     public bool wasTouchingWallLastFrame;
     public bool justTouchingWall;
     public bool justNOTTouchingWall;

     public bool isTouchingCeil;
     public bool wasTouchingCeilLastFrame;
     public bool justTouchingCeilLastFrame;
     public bool justNOTTouchingCeil;
	
	[Header("Variables")]
    public ContactFilter2D groundFilter;
    public int maxHits;

    public Vector2 groundBoxPositon;
    public Vector2 groundBoxSize;

	public Vector2 wallBoxPosition;
	public Vector2 wallBoxSize;

	public Vector2 ceilBoxPosition;
	public Vector2 ceilBoxSize;

    public Collider2D [] results;
    public ContactFilter2D filter;

    public LayerMask mask;


    // Use this for initialization

    public void MyStart()
    {

    }

    public void MyFixedUpdate()
    {

    }

    public void Flip(bool isFacingRight)
    {

    }

    void ResetState ()
    {
        isGrounded = false;
        wasGroundedLastFrame = false;
        justGotGrounded = false;
        justNOTGrounded = false;
        isFalling = !isGrounded;
		isTouchingWall = false;
		wasTouchingWallLastFrame = false;
		justNOTTouchingWall = false;
		justTouchingWall = false;
		isTouchingCeil = false;
		wasTouchingCeilLastFrame = false;
		justTouchingCeilLastFrame = false;
		justNOTTouchingCeil = false;    
	}
	

    private void FixedUpdate()
    {

        ResetState();

        GroundDetection();

        WallDetection();

        CeilDetection();

	}

    public void GroundDetection()
    {
        results = new Collider2D[5];
        Vector2 position = this.transform.position;
        Collider2D colliderGround = Physics2D.OverlapBox(position + groundBoxPositon, groundBoxSize, 0, mask);
        int numHits = Physics2D.OverlapBox(this.transform.position, groundBoxSize, 0, filter, results);
        if(colliderGround != null) Debug.Log("Se ha detectado un collider");

        if(numHits > 0)
        {
            isGrounded = true;
        }
        else isGrounded = false;

        isFalling = !isGrounded;
    }

    public void WallDetection()
    {
        results = new Collider2D[5];
        Vector2 position = this.transform.position;
        Collider2D colliderWall = Physics2D.OverlapBox(position + wallBoxPosition, wallBoxSize, 0, mask);
        int numHits = Physics2D.OverlapBox(this.transform.position, wallBoxSize, 0, filter, results);
        if(colliderWall != null) Debug.Log("Se ha detectado un collider");

        if(numHits > 0)
        {
            isTouchingWall = true;
        }
        else isTouchingWall = false;
    }

    public void CeilDetection()
    {
        results = new Collider2D[5];
        Vector2 position = this.transform.position;
        Collider2D colliderCeil = Physics2D.OverlapBox(position + ceilBoxPosition, ceilBoxSize, 0, mask);
        int numHits = Physics2D.OverlapBox(ceilBoxPosition, ceilBoxSize, 0, filter, results);
        if(colliderCeil != null) Debug.Log("Se ha detectado un collider");

        if(numHits > 0)
        {
            isTouchingCeil = true;
        }
        else isTouchingCeil = false;
    }
    private void OnDrawGizmosSelected()
	{
        Vector2 position = this.transform.position;

		Gizmos.DrawWireCube(position + groundBoxPositon, groundBoxSize);

		Gizmos.DrawWireCube(position + wallBoxPosition, wallBoxSize);

		Gizmos.DrawWireCube(position + ceilBoxPosition, ceilBoxSize);
	}

}


