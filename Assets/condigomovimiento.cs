using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condigomovimiento : MonoBehaviour
{
    Transform _transformcomponent;
    SpriteRenderer _spriteRenderercomponent;
    public int direccionx = 1;
    public int direcciony = 1;
    public int velocity;
    // Start is called before the first frame update
    void Start()
    {
        _transformcomponent = GetComponent<Transform>();
        _spriteRenderercomponent = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(_transformcomponent.position.x + velocity * direccionx * Time.deltaTime, _transformcomponent.position.y + velocity * direcciony * Time.deltaTime);
        if(_transformcomponent.position.x >= 6.85f || _transformcomponent.position.x <= -6.85f)
        {
            direccionx = direccionx * -1;
            _spriteRenderercomponent.flipX = !_spriteRenderercomponent.flipX;
            _spriteRenderercomponent.flipY = !_spriteRenderercomponent.flipY;
        }
        if (_transformcomponent.position.y >= 4.0f || _transformcomponent.position.y <= -4.00f)
        {
            _spriteRenderercomponent.flipY = !_spriteRenderercomponent.flipY;
            _spriteRenderercomponent.flipX = !_spriteRenderercomponent.flipX;
            direcciony = direcciony * -1;
        }
    }
}
