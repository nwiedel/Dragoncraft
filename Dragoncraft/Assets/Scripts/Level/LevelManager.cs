using UnityEngine;
using UnityEngine.SceneManagement;

namespace Dragoncraft
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _miniMapCameraPrefab;

        // Start is called before the first frame update
        void Start()
        {
            Instantiate(_miniMapCameraPrefab);
            SceneManager.LoadScene("GameUI", LoadSceneMode.Additive);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

