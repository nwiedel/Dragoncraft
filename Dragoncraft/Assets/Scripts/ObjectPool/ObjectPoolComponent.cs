using System.Collections.Generic;
using UnityEngine;

namespace Dragoncraft
{
    public class ObjectPoolComponent : MonoBehaviour
    {
        [SerializeField]
        private GameObject _prefab;
        [SerializeField]
        private int _poolSize;
        [SerializeField]
        private bool _allowCreation;
        [SerializeField]
        private List<GameObject> _gameObjects = new List<GameObject>();

        private void Awake()
        {
            for (int i = 0; i < _poolSize; i++)
            {
                _gameObjects.Add(CreateItem(false));
            }
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


