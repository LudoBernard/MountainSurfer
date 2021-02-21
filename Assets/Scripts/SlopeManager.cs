using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SlopeManager : MonoBehaviour
{

    [SerializeField] private List<GameObject> slopes_;
    private float offsetZ_ = 50f;
    
    // Start is called before the first frame update
    void Start()
    {
        if (slopes_ != null && slopes_.Count > 0)
        {
            slopes_ = slopes_.OrderBy(s => s.transform.position.z).ToList();
        }
    }

    public void MoveSlope()
    {
        GameObject movedSlope = slopes_[0];
        slopes_.Remove(movedSlope);
        float newZ = slopes_[slopes_.Count - 1].transform.position.z + offsetZ_;
        var position = transform.position;
        movedSlope.transform.position = new Vector3(position.x, position.y - 1, newZ);
        slopes_.Add(movedSlope);
    }
}
