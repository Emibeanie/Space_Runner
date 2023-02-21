using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitController : MonoBehaviour
{
    public List<SkinnedMeshRenderer> m_headRenderers;
    public List<Renderer> m_suitRenderers;
    public List<Transform> m_visors;

    [Header("Suit Settings")]
    public MaterialPropertyBlock m_pb;
    public Color m_lightColor = Color.cyan;
    public float m_lightPulse = 1f;
    [Range(0.0f, 1.0f)]
    public float m_visorOpen = 0f;
    Vector3 m_visorOpenAngle = new Vector3(-90, 0, 0);
    public bool m_Helmet = true;

    // Start is called before the first frame update
    void Start()
    {
        m_pb = new MaterialPropertyBlock();
        m_pb.SetColor("_Emission", m_lightColor);

        m_visors[1].localRotation = Quaternion.Euler(Vector3.Lerp(Vector3.zero, m_visorOpenAngle, m_visorOpen));
        m_visors[1].parent.gameObject.SetActive(m_Helmet);
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    void LateUpdate()
    {
        for (int i = 0; i < m_suitRenderers.Count; i++)
        {
            m_pb.SetColor("_EmissionColor", m_lightColor * Mathf.Abs(Mathf.Sin(m_lightPulse * Time.time)));
            m_suitRenderers[i].SetPropertyBlock(m_pb);
        }
    }
    
}
