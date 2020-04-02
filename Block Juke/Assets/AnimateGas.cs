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
        var particlesMain = particles.main;
        particlesMain.loop = _rightLoop;
        _rightLoop = false;
    }
}
