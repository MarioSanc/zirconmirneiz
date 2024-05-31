using Library;
using Server.DBModels;
using Server.Envir.Commands.Exceptions;
using Server.Models;
using System;
using System.IO;

namespace Server.Envir.Commands.Command.Admin
{
    class GlobalMessage : AbstractParameterizedCommand<IAdminCommand>
    {
        public override string VALUE => "@";
        public override int PARAMS_LENGTH => 2;

        public override void Action(PlayerObject player, string[] vals)
        {
            if (vals.Length < PARAMS_LENGTH)
                ThrowNewInvalidParametersException();

            foreach (SConnection con in SEnvir.Connections)
                con.ReceiveChat(vals[1], MessageType.Notice);

        }
    }
}