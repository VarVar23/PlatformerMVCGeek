using UnityEngine;

public class InputManager
{
    private InputString _inputString = new InputString();
    public float Horizontal;
    public float Vertical;
    public bool Jump;

    public void FixUpdateInput()
    {
        Horizontal = Input.GetAxis(_inputString.HORIZONTAL);
        Vertical = Input.GetAxis(_inputString.VERTICAL);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump = true;
        }
        else
        {
            Jump = false;
        }
    }
}
