using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IEnemy
    {
        void UseGun();
        void SpeedUp();
        void EnemyName(string enemyName);

    }
}
