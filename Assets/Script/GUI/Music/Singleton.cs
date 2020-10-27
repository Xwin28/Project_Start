
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static GameObject m_InstanceSound;

    private void Awake()
    {

        // Create instance
        if (m_InstanceSound == null)
        {
            m_InstanceSound = this.gameObject;
        }
        else
        {
            Destroy(gameObject);
            return;

        }
    }
}
