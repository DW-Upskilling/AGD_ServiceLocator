using UnityEngine;

/**  This script demonstrates implementation of the Observer Pattern.
  *  If you're interested in learning about Observer Pattern, 
  *  you can find a dedicated course on Outscal's website.
  *  Link: https://outscal.com/courses
  **/

using ServiceLocator.Utilities;

namespace ServiceLocator.Events
{
    public class EventService : GenericMonoSingleton<EventService>
    {
        public GameEventController<int> OnMapSelected { get; private set; }

        protected override void Initialize()
        {
            OnMapSelected = new GameEventController<int>();
        }

    }
}