using UnityEngine;
using System.Collections;


/*
 *		Author: 	Craig Lomax
 *		Date: 		25.12.2011
 *		URL:		clomax.me.uk
 *		email:		crl9@aber.ac.uk
 *
 */

/*
 *	Handles events that happen between multiple
 *	Objects of the same type.
 */
public class CollisionMediator : MonoBehaviour {
	
	public static CollisionMediator instance;
	public static GameObject container;	
	public CollEvent evt;
	public ArrayList collision_events = new ArrayList();
	public Spawner spw;
	
	void Start () {
		spw = Spawner.getInstance();
	}
	
	public static CollisionMediator getInstance () {
		if(!instance) {
			container = new GameObject();
			container.name = "Collision Observer";
			instance = container.AddComponent(typeof(CollisionMediator)) as CollisionMediator;
		}
		return instance;
	}
	
	public void observe (GameObject a, GameObject b) {
		this.collision_events.Add(new CollEvent(a, b));
	}
	
}
