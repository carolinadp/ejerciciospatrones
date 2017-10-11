using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Data;

namespace Core
{
    public class PlayerManager
    {
        public async Task<bool> SavePlayer(Player player)
        {
            PlayerDataProvider dataProvider = new PlayerDataProvider();
            string pcId = Environment.MachineName;
            bool result = await dataProvider.SavePlayer(player, pcId);
            return result;
        }
    }
}
