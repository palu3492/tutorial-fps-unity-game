using UnityEngine;

public class AnimateGas : MonoBehaviour
{
    public ParticleSystem particles;
    private bool _rightLoop;

    public void EmitGasRight()
    {
        _rightLoop = true;
    }

    private void Update()
    {
        Debug.Log(_rightLoop);
        if(_rightLoop && !particles.isPlaying)
        {
            var main = particles.main;
            main.loop = true;
            particles.Play();
        }

        if (!_rightLoop)
        {
            var main = particles.main;
            main.loop = false;
        }
        
        _rightLoop = false;
    }
}
