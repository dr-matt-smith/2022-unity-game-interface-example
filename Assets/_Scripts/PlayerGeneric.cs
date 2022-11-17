using UnityEngine;
using UnityEngine.UI;
using _Scripts;
using Tudublin;

public class PlayerGeneric : MonoBehaviour
{		
	// reference to a UI Text object
	// public - so we have to assign via the Inspector
	public Text textProperties;
	
	// number of stars
	// NOTE: Unity C# convention of prefixing private variables with an underscore...
	private int _totalStars = 0;
	
	// health
	private int _health = 100;	
		
	// reference to AudioSource component in Player GameObject
	private AudioSource _audioSource;
	
	//------------------------
	// assign _audioSource to the AudioSource component in the GameObject
	// the instance of this script is in (i.e. the Player character GameObject)
	private void Awake()
	{
		_audioSource = GetComponent<AudioSource>();
	}


	//------------------------
	// Ensure UI display matches this initial state
	// of whether we are carrying a star or not
	void Start()
	{
		this.UpdateUI();
	}

    //--------------------------
	// when we hit a star, update carrying flag
	// and update the display
	// (and remove the star GameObject)
	void OnTriggerEnter2D(Collider2D hit)
	{
		// IF we hit something tagged 'Star'
		if (hit.CompareTag("Star"))
		{
			// destroy the star object that we collided with
			Destroy(hit.gameObject);
			
			this.GetStarAction();
		}
	}

	private void GetStarAction()
	{
		// set our flag to TRUE
		this._totalStars++;

		// update the UI display of our star carrying status
		this.UpdateUI();
						
		// play the sound effect in the AudioSource component
		this._audioSource.Play();		
	}


	//------------------------------
	// update the text message on screen
	// to indicate how many stars we are carrying
	public void UpdateUI()
	{
		// build & display total message
		string propertiesMessage = "PLAYER 1: total stars = " + this._totalStars;
		propertiesMessage += " / health = " + this._health;
		textProperties.text = propertiesMessage;

	}
}
