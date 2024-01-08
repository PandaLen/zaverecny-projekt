using UnityEngine.XR.Interaction.Toolkit;

public class SocketTagCheck : XRSocketInteractor
{
    public string targetTag = string.Empty;

    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchTag(interactable);
    }

    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return base.CanSelect(interactable) && MatchTag(interactable);
    }

    private bool MatchTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }
}
