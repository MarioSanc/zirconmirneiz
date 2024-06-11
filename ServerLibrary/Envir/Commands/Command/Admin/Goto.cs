using Server.Envir.Commands.Exceptions;
using Server.Models;

namespace Server.Envir.Commands.Command.Admin
{
    class Goto : AbstractParameterizedCommand<IAdminCommand>
    {
        public override string VALUE => "GOTO";
        public override int PARAMS_LENGTH => 2;

        public override void Action(PlayerObject player, string[] vals)
        {
            if (vals.Length < PARAMS_LENGTH)
                ThrowNewInvalidParametersException();

            PlayerObject playerTarget = SEnvir.GetPlayerByCharacter(vals[1]);

            if (playerTarget == null)
                throw new UserCommandException(string.Format("Could not find player: {0}", vals[1]));
            player.Teleport(playerTarget.CurrentMap, playerTarget.CurrentLocation);
        }
    }
}
