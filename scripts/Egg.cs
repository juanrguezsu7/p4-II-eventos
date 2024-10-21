using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    private EggController eggController;
    // Start is called before the first frame update
    void Start()
    {
        eggController = GetComponent<EggController>();
        Cube.OnCollisionEgg += (name) => {
            if (name == this.name) {
                eggController.Destroy();
            }
            
        };
    }

    public bool IsDestroyed() {
        return eggController.IsDestroyed();
    }
}
