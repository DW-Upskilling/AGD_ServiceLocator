using UnityEngine;

/**  This script demonstrates implementation of the Observer Pattern.
  *  If you're interested in learning about Observer Pattern, 
  *  you can find a dedicated course on Outscal's website.
  *  Link: https://outscal.com/courses
  **/

namespace ServiceLocator.Events
{
    public class EventService : MonoBehaviour
    {
        public static EventService Instance { get; private set; }

        public GameEventController<int> OnMapSelected { get; private set; }

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
                OnMapSelected = new GameEventController<int>();
            } else
            {
                Destroy(gameObject);
            }
        }
        
    }
}