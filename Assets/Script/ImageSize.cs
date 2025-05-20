using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Graphic))]
[ExecuteAlways]
public class ImageSize : MonoBehaviour
{
    private Image m_myCanvasImage;
    void Start()
    {
        m_myCanvasImage = GetComponent<Image>();
    }

   private void FixedUpdate()
    {
        UpdateMaterial();
    }

    void UpdateMaterial()
    {
        if (m_myCanvasImage != null && m_myCanvasImage.material != null)
        {
            var imageRect = m_myCanvasImage.rectTransform.rect;
            var widthHeight = new Vector2(x: imageRect.width, y: imageRect.height);
            m_myCanvasImage.material.SetVector(name: "_Size", widthHeight);
        }
    }
}
