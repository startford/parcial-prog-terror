using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Player : MonoBehaviour
{
	public float speed = 10.0f;


	public static Player instance;
	public static int num = 0;
	public int activGan = 0;
	public int numObjetos;
	public bool denom = false;
	public bool denom2 = true;
	public bool denom3 = true;
	public bool denom4 = true;
	Animator _animator;


	//private MouseLook m_MouseLook;



	public GameObject Compu;
	public GameObject dinero;
	public GameObject celular;
	public GameObject tablet;
	public GameObject diamante;
	public GameObject lingote;
	public GameObject reloj;
	public GameObject dvd;
	public GameObject maletin;
	public GameObject puertaCaja;
	public GameObject cajaFuerte;


	public GameObject camara2;
	public Transform puertaCoch;

	public GameObject Linterna;
	public GameObject lightDay;
	public GameObject camara;

	public Transform puerta;
	public Transform puerta2;
	public Transform puerta3;
	public Transform puerta4;
	public Transform puerta5;
	public GameObject niñaT;
	public GameObject trampas;
	public GameObject trampas2;
	public Transform coliLint;
	public 	GameObject susto;

	public AudioSource music;
	public AudioSource music2;

	private AudioSource m_Audio;

	public AudioClip m_LandSounds;

	public bool hasPaused;
	void Start () 
	{
		m_Audio = GetComponent<AudioSource>();

		Cursor.lockState = CursorLockMode.Locked;


		music2.Stop ();
		if (!instance) instance = this;
		else Destroy(this);

	}
	

	public void FixedUpdates () 
	{
		
	

			AnimatorM.instance.FixedUpda ();
			MouseLook.instance.FixedUpda ();
			Enemy.instance.FixedUpda ();
			float translation = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
			float straffe = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
			if (Input.GetKey(KeyCode.W)) 
			{
				//m_Audio.clip = m_LandSounds;
				//m_Audio.Play();
			}
			transform.Translate (straffe, 0, translation);
			if (Input.GetKeyDown ("escape")) 
			{
				Cursor.lockState = CursorLockMode.None;
			}


			if (Input.GetMouseButton (1))
			{
				//print ("asasa");
			}
			if(Input.GetKeyUp(KeyCode.O)&& denom2 == true)
			{

				coliLint.transform.Rotate (90, 0, 0);
				denom2 = false;
			}
			if(Input.GetKeyDown(KeyCode.P)&& denom2 == false)
			{
				coliLint.transform.Rotate (-90, 0, 0);
				denom2 = true;
			}
			if (numObjetos == 10) 
			{
				puerta.transform.Rotate(0,0 ,90);
				numObjetos = 11;
			}
			if (Input.GetKey (KeyCode.R)) 
			{
				Application.Quit ();
			}
	

	}

	void OnTriggerEnter(Collider c)
	{
        // en esta parte del codigo controlo colicion y a la vez borro objetos de mi canvas menu




        //aaaaaaaaaaaaaaaaaa






        if (c.gameObject.layer == 12)
        {
            if (activGan == 1)
            {
                //print("ganaste wachinnnn");
                activGan = 2;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(3);

            }
        }
        switch (c.gameObject.layer)
        {
            case 11:
                Destroy(c.gameObject);
                break;
            case 12:
                if (Input.GetKey(KeyCode.H))
                {
                    num = 7;

                }
                break;
            case 18:
                Destroy(c.gameObject);
                Destroy(trampas);
                Destroy(trampas2);
                num = 40;
                //print("entre");
                susto.SetActive(true);
                camara2.SetActive(true);
                puerta.Rotate(0, 0, 180);
                denom = true;
                break;
            case 19:
                Destroy(c.gameObject);
                num = 9;
                break;
            case 20:
                num = 20;
                break;
            case 21:
                //print("locooooo mama miaaa");

                Destroy(c.gameObject);
                num = 3;
                break;
        }
       
    }

    void OnTriggerExit(Collider c)
	{
		if(c.gameObject.layer == 20 )
		{
			print ("locooooo");
			num = 21;
		
		}
	}
    void OnTriggerStay(Collider c)
    {
        if (c.tag == "trampa3")
        {
            num = 70;
        }
        if (Input.GetMouseButton(0))
        {
        switch (c.gameObject.layer)
        {
            case 8:
                    Destroy(c.gameObject);
                    Destroy(Compu);
                    numObjetos++;
                    break;
                case 23:
                    numObjetos++;
                    Destroy(c.gameObject);
                    Destroy(dinero);
                    break;
                case 24:
                    numObjetos++;
                    Destroy(c.gameObject);
                    Destroy(celular);
                    break;
                case 25:
                    numObjetos++;
                    Destroy(c.gameObject);
                    Destroy(tablet);
                    break;
                case 26:
                    numObjetos++;
                    Destroy(c.gameObject);
                    Destroy(diamante);
                    break;
                case 27:
                    numObjetos++;
                    Destroy(c.gameObject);
                    Destroy(lingote);
                    break;

                case 28:
                    numObjetos++;
                    Destroy(c.gameObject);
                    Destroy(reloj);
                    break;
                case 29:
                    numObjetos++;
                    Destroy(c.gameObject);
                    Destroy(dvd);
                    break;

                case 30:
                    numObjetos++;
                    Destroy(c.gameObject);
                    Destroy(maletin);
                    break;

            }
        
        }
         
        if (Input.GetMouseButton (0) && c.gameObject.layer == 31 &&  numObjetos == 9) 
		{
			//music.volume = 0;
			//music.Stop ();
			//music2.Play ();
			Destroy (c.gameObject);
			denom3 = false;
			activGan = 1;
			num = 50;
			//num = 1;
		}
		if (Input.GetMouseButton (0) && c.tag == "CajaFuerte" && denom4 == false) 
		{
			numObjetos++;
			Destroy (c.gameObject);
			Destroy (cajaFuerte);
			puertaCoch.transform.Rotate (90, 0, 0);
		}



		//colicion doors

		if (c.gameObject.layer == 13 && denom == false && (Input.GetMouseButton (1))) 
		{
			puerta.transform.Rotate (0, 0, 180);
			denom = true;
		}
		if(c.gameObject.layer == 14  && (Input.GetMouseButton (1))) puerta2.transform.Rotate(0, 0 ,180);

		if (c.gameObject.layer == 15 && (Input.GetMouseButton (1)))puerta3.transform.Rotate (0, 0, 180);


		if(c.gameObject.layer == 16  && (Input.GetMouseButton (1)))
		{
			puerta4.transform.Rotate(0, 0 ,-90);
			num = 60;	
		}
		if (c.gameObject.layer == 17 && (Input.GetMouseButton (1)))puerta5.transform.Rotate (0, 0, 180);
		
		//colision  box door

		if (Input.GetMouseButton (1) && c.tag == "puerta" && denom3 != true ) 
		{
			puertaCaja.transform.Rotate(0,0 ,90);
			denom3 = false;
			denom4 = false;

		}

		//colision con la niña

		if (c.tag == "enemy") 
		{
			print ("q ondaaa");
			SceneManager.LoadScene(5);
		}

	}
	public void land()
	{
		m_Audio.clip = m_LandSounds;
		m_Audio.Play();
	}
	public void reinicio()
	{

		 num = 0;
	     activGan = 0;
		 numObjetos = 0;
			
		 denom = false;
		 denom2 = true;
		 denom3 = true;
		 denom4 = true;

	}
		
		

	void destroy()
	{
		Destroy (gameObject);
	}
}
