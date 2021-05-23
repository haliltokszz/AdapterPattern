using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EnemyTank : IEnemy
    {
        public void UseGun()
        {
            Console.WriteLine("Enemy Tank Use gun");
        }
        public void SpeedUp()
        {
            Console.WriteLine("Enemy Tank Speed Up");
        }
        public void EnemyName(string enemyName)
        {
            Console.WriteLine("Enemy Tank Enemy Name:" + enemyName);
        }
    }
}
