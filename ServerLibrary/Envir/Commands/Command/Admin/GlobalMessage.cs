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

            var Message = "";
            for (int i = 1; i < vals.Length; i++)
            {
                Message += vals[i] + " ";
            }
            foreach (SConnection con in SEnvir.Connections)
                con.ReceiveChat(Message, MessageType.Notice);

        }
    }
}