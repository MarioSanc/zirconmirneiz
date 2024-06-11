using Library;
using Server.Envir.Commands.Exceptions;
using Server.Models;

namespace Server.Envir.Commands.Command.Admin
{
    class Revive : AbstractParameterizedCommand<IAdminCommand>
    {
        public override string VALUE => "REVIVE";
        public override int PARAMS_LENGTH => 2;

        public override void Action(PlayerObject player, string[] vals)
        {
            PlayerObject playerTarget;

            if (vals.Length < PARAMS_LENGTH)
                playerTarget = player;
            else
            {
                playerTarget = SEnvir.GetPlayerByCharacter(vals[1]);
                if (playerTarget == null)
                    throw new UserCommandException(string.Format("Could not find player: {0}", vals[1]));
            }
            // If player is dead, revive with max health.
            if (playerTarget.Dead)
            {
                playerTarget.Revive();
            }
        }
    }
}
