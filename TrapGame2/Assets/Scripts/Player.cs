using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Player : MonoBehaviour
{

    [SerializeField] float runSpeed = 8f;
    [SerializeField] float jumpSpeed = 10f;
    [SerializeField] float trapCD = 1f;
    [SerializeField] float projectileCD = 3f;

    bool hasJumped = false;
    float flippedSprite;
    bool canMove = true;
    bool projectileOnCD = false;
    bool trapOnCD = false;
    bool projectileCDChecked = false;
    bool trapCDChecked = false;

    public GameObject projectilePrefab;
    public GameObject trap1Prefab;
    public GameObject trap2Prefab;
    Rigidbody2D myRigidBody;
    Animator myAnimator;
    CapsuleCollider2D myBodyCollider;
    BoxCollider2D myFeet;
    Transform playerFront;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myBodyCollider = GetComponent<CapsuleCollider2D>();
        myFeet = GetComponent<BoxCollider2D>();
        playerFront = transform.Find("Front").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
        FlipSprite();
        ThrowProjectile();
        PlaceTrap1();
        PlaceTrap2();
        StartCoroutine(TrapCooldown(trapCD));
        StartCoroutine(ProjectileCooldown(projectileCD));
    }

    private void Run()
    {
        if (canMove == true)
        {
            if (gameObject.tag == "Player1")
            {
                float controlThrow = CrossPlatformInputManager.GetAxis("HorizontalPlayer1"); //value is between -1 to +1
                Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
                myRigidBody.velocity = playerVelocity;

                bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
                myAnimator.SetBool("Running", playerHasHorizontalSpeed);
            }
            if (gameObject.tag == "Player2")
            {
                float controlThrow = CrossPlatformInputManager.GetAxis("HorizontalPlayer2"); //value is between -1 to +1
                Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
                myRigidBody.velocity = playerVelocity;

                bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
                myAnimator.SetBool("Running", playerHasHorizontalSpeed);
            }
            if (gameObject.tag == "Player3")
            {
                float controlThrow = CrossPlatformInputManager.GetAxis("HorizontalPlayer3"); //value is between -1 to +1
                Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
                myRigidBody.velocity = playerVelocity;

                bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
                myAnimator.SetBool("Running", playerHasHorizontalSpeed);
            }
            if (gameObject.tag == "Player4")
            {
                float controlThrow = CrossPlatformInputManager.GetAxis("HorizontalPlayer4"); //value is between -1 to +1
                Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
                myRigidBody.velocity = playerVelocity;

                bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
                myAnimator.SetBool("Running", playerHasHorizontalSpeed);
            }
        }
    }

    private void Jump()
    {
        if (canMove == true)
        {
            if (gameObject.tag == "Player1")
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) && hasJumped == true)
                {
                    return;
                }

                if (CrossPlatformInputManager.GetButtonDown("JumpPlayer1"))
                {
                    Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
                    myRigidBody.velocity = jumpVelocityToAdd;

                    if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
                    {
                        hasJumped = true;
                    }
                }
                if (myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
                {
                    hasJumped = false;
                }
            }

            if (gameObject.tag == "Player2")
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) && hasJumped == true)
                {
                    return;
                }

                if (CrossPlatformInputManager.GetButtonDown("JumpPlayer2"))
                {
                    Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
                    myRigidBody.velocity = jumpVelocityToAdd;

                    if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
                    {
                        hasJumped = true;
                    }
                }
                if (myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
                {
                    hasJumped = false;
                }
            }
            if (gameObject.tag == "Player3")
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) && hasJumped == true)
                {
                    return;
                }

                if (CrossPlatformInputManager.GetButtonDown("JumpPlayer3"))
                {
                    Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
                    myRigidBody.velocity = jumpVelocityToAdd;

                    if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
                    {
                        hasJumped = true;
                    }
                }
                if (myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
                {
                    hasJumped = false;
                }
            }
            if (gameObject.tag == "Player4")
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) && hasJumped == true)
                {
                    return;
                }

                if (CrossPlatformInputManager.GetButtonDown("JumpPlayer4"))
                {
                    Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
                    myRigidBody.velocity = jumpVelocityToAdd;

                    if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
                    {
                        hasJumped = true;
                    }
                }
                if (myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
                {
                    hasJumped = false;
                }
            }
        }
    }

    private void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;

        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(myRigidBody.velocity.x), 1f);
            flippedSprite = Mathf.Sign(myRigidBody.velocity.x);
        }
    }

    public void ThrowProjectile()
    {
        if (gameObject.tag == "Player1")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire1_1"))
            {
                if (projectileOnCD != true)
                {
                    GameObject projectile = Instantiate(projectilePrefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    if (flippedSprite > 0)
                    {
                        projectile.transform.Rotate(0f, 1f, 0f);
                    }
                    if (flippedSprite < 0)
                    {
                        projectile.transform.Rotate(0f, -1f, 0f);
                    }
                    projectileOnCD = true;
                }
            }
        }
        if (gameObject.tag == "Player2")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire1_2"))
            {
                if (projectileOnCD != true)
                {
                    GameObject projectile = Instantiate(projectilePrefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    if (flippedSprite > 0)
                    {
                        projectile.transform.Rotate(0f, 1f, 0f);
                    }
                    if (flippedSprite < 0)
                    {
                        projectile.transform.Rotate(0f, -1f, 0f);
                    }
                    projectileOnCD = true;
                }
            }
        }
        if (gameObject.tag == "Player3")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire1_3"))
            {
                if (projectileOnCD != true)
                {
                    GameObject projectile = Instantiate(projectilePrefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    if (flippedSprite > 0)
                    {
                        projectile.transform.Rotate(0f, 1f, 0f);
                    }
                    if (flippedSprite < 0)
                    {
                        projectile.transform.Rotate(0f, -1f, 0f);
                    }
                    projectileOnCD = true;
                }
            }
        }
        if (gameObject.tag == "Player4")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire1_4"))
            {
                if (projectileOnCD != true)
                {
                    GameObject projectile = Instantiate(projectilePrefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    if (flippedSprite > 0)
                    {
                        projectile.transform.Rotate(0f, 1f, 0f);
                    }
                    if (flippedSprite < 0)
                    {
                        projectile.transform.Rotate(0f, -1f, 0f);
                    }
                    projectileOnCD = true;
                }
            }
        }
    }

    public IEnumerator Stun(float duration)
    {
        float timer = 0;
        while (duration > timer)
        {
            timer += Time.deltaTime;
            myRigidBody.velocity = new Vector2(0, 0);
            canMove = false;
        }
        yield return new WaitForSeconds(duration);
        canMove = true;
    }

    public IEnumerator Knockback(float duration, Vector3 knockbackDirection)
    {
        float timer = 0;
        while (duration > timer)
        {
            timer += Time.deltaTime;
            myRigidBody.velocity = new Vector3(0, 0, 0);
            myRigidBody.AddForce(knockbackDirection);
        }
        yield return new WaitForSeconds(duration);
    }

    public void PlaceTrap1()
    {
        if (gameObject.tag == "Player1")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire2_1"))
            {
                if (trapOnCD != true)
                {
                    GameObject projectile = Instantiate(trap1Prefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    trapOnCD = true;
                }
            }
        }
        if (gameObject.tag == "Player2")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire2_2"))
            {
                if (trapOnCD != true)
                {
                    GameObject projectile = Instantiate(trap1Prefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    trapOnCD = true;
                }
            }
        }
        if (gameObject.tag == "Player3")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire2_3"))
            {
                if (trapOnCD != true)
                {
                    GameObject projectile = Instantiate(trap1Prefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    trapOnCD = true;
                }
            }
        }
        if (gameObject.tag == "Player4")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire2_4"))
            {
                if (trapOnCD != true)
                {
                    GameObject projectile = Instantiate(trap1Prefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    trapOnCD = true;
                }
            }
        }
    }

    public void PlaceTrap2()
    {
        if (gameObject.tag == "Player1")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire3_1"))
            {
                if (trapOnCD != true)
                {
                    GameObject projectile = Instantiate(trap2Prefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    trapOnCD = true;
                }
            }
        }
        if (gameObject.tag == "Player2")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire3_2"))
            {
                if (trapOnCD != true)
                {
                    GameObject projectile = Instantiate(trap2Prefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    trapOnCD = true;

                }
            }
        }
        if (gameObject.tag == "Player3")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire3_3"))
            {
                if (trapOnCD != true)
                {
                    GameObject projectile = Instantiate(trap2Prefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    trapOnCD = true;

                }
            }
        }
        if (gameObject.tag == "Player4")
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire3_4"))
            {
                if (trapOnCD != true)
                {
                    GameObject projectile = Instantiate(trap2Prefab) as GameObject;
                    projectile.transform.position = playerFront.position;
                    trapOnCD = true;

                }
            }
        }
    }

    public IEnumerator TrapCooldown(float cd)
    {
        if (trapOnCD == true && trapCDChecked == false)
        {
            trapCDChecked = true;
            yield return new WaitForSeconds(cd);
            trapCDChecked = false;
            trapOnCD = false;
        }
    }

    public IEnumerator ProjectileCooldown(float cd)
    {
        if (projectileOnCD == true && projectileCDChecked == false)
        {
            projectileCDChecked = true;
            yield return new WaitForSeconds(cd);
            projectileCDChecked = false;
            projectileOnCD = false;
        }
    }

}