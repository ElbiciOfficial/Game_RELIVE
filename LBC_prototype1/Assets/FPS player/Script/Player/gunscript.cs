
using UnityEngine;

public class gunscript : MonoBehaviour {

    //public Interactor Escript;
   
    public GameObject paintballprefab;
    private GameObject _paintball;

    public float damage = 10f;
    public float range = 100f;
    public float firerate = 20f;

    AudioSource source;
    public AudioClip clip1;
    public AudioClip clip2;
    public GameObject gun;

    public Animator firee;
    public float ammo;
    public Camera fpscam;
    public ParticleSystem flash;
    public GameObject impacteffect;
    public float impactforce;

   
    private float nexttimetofire = 2f;

    void Start()
    {
        firee = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    public void Energy(float energy)
    {
            ammo = energy;
            Debug.Log("energy: " + ammo);
         
    }

    void Update () {


        if (ammo != 0)
        {
            if (Input.GetButton("Fire1") && Time.time >= nexttimetofire)
            {
                nexttimetofire = Time.time + 3f / firerate;
                    _paintball = Instantiate(paintballprefab) as GameObject;
                    _paintball.transform.position = gun.transform.TransformPoint(Vector3.forward * 0.1f);
                    _paintball.transform.rotation = gun.transform.rotation;                     
                ammo = ammo - 1;
                playshot();             
                shoot();
            }
            else
            {
                firee.SetBool("fire", false);
            }
        }
        else if (ammo == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                outofammo();
                noammo();
            }
            else
            {
                firee.SetBool("outofammo", false);
            }
        }

    }

    void shoot()
    {
        flash.Play();

        firee.SetBool("fire", true);

        RaycastHit hit;
        
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range)){

            Debug.Log(hit.transform.name);

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactforce);
            }          
        }
    }

    void playshot()
    {
        source.PlayOneShot(clip1, 0.7f);
    }

    void outofammo()
    {
        source.PlayOneShot(clip2, 0.7f);
    }

    void noammo()
    {
        firee.SetBool("outofammo", true);
    }
}
