using PulsarModLoader.Chat.Commands.CommandRouter;

namespace Freecam
{
    class Command : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[] { "freecam" };
        }

        public override string Description()
        {
            return "removes the camera from the local pawn";
        }

        public override void Execute(string arguments)
        {
            if (PLCameraSystem.Instance.CurrentCameraMode != null && PLCameraSystem.Instance.CurrentCameraMode.GetType() == typeof(PLCameraMode_Scripted))
            {
                PLCameraSystem.Instance.ChangeCameraMode(new PLCameraMode_LocalPawn());
            }
            else
            {
                PLCameraSystem.Instance.ChangeCameraMode(new PLCameraMode_Scripted());
            }
        }
    }
}
