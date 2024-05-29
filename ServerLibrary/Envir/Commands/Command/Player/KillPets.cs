using Server.Envir.Commands.Command;
using Server.Envir.Commands.Command.Player;
using Server.Models;

namespace Server.Envir.Commands.Player
{
    class KillPets : AbstractCommand<IPlayerCommand>
    {
        public override string VALUE => "KILLPETS";

        public override void Action(PlayerObject player)
        {
            for (int i = player.Pets.Count - 1; i >= 0; i--)
            {
                player.Pets[i].ChangeHP(-player.Pets[i].CurrentHP);
            }
            //player.Pets[i].Despawn();
            player.Pets.Clear();
        }
    }
}
