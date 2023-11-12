using UnityEngine;

namespace ServiceLocator.Utilities
{
    public abstract class GenericMonoSingleton<T> : MonoBehaviour where T : GenericMonoSingleton<T>
    {
        public static T Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = (T)this;
                Initialize();
            }
            else
            {
                Destroy(gameObject);
            }
        }

        protected abstract void Initialize();
    }
}
