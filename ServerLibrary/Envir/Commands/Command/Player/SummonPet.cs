using Library;
using Server.Envir.Commands.Command;
using Server.Envir.Commands.Command.Player;
using Server.Models;
using System.Linq;

namespace Server.Envir.Commands.Player
{
    class Pet : AbstractCommand<IPlayerCommand>
    {
        public override string VALUE => "PET";

        public override void Action(PlayerObject player)
        {
            if (player.Character.Pet != null)
            {
                MonsterObject ob = player.Pets.FirstOrDefault(x => x.MonsterInfo == player.Character.Pet);

                if (ob == null)
                {
                    ob = MonsterObject.GetMonster(player.Character.Pet);

                    ob.PetOwner = player;
                    player.Pets.Add(ob);

                    ob.Master?.MinionList.Remove(ob);
                    ob.Master = null;
                    ob.SummonLevel = player.Level;
                    ob.TameTime = SEnvir.Now.AddDays(365);

                    var location = Functions.Move(player.CurrentLocation, player.Character.Direction, 1);

                    Cell cell = player.CurrentMap.GetCell(location);

                    if (cell == null || cell.Movements != null || !ob.Spawn(player.CurrentMap, location))
                        ob.Spawn(player.CurrentMap, player.CurrentLocation);

                    ob.SetHP(ob.Stats[Stat.Health]);
                }
            }
        }
    }
}
