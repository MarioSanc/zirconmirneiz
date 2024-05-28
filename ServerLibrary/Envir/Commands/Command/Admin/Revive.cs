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

            if (vals.Length < PARAMS_LENGTH)
                ThrowNewInvalidParametersException();
            else
            {
                player = SEnvir.GetPlayerByCharacter(vals[1]);
                if (player == null)
                    throw new UserCommandException(string.Format("Could not find player: {0}", vals[1]));

                // If player is dead, revive with max health.
                if (player.Dead)
                {
                    player.Revive();
                }
            }
        }
    }
}
