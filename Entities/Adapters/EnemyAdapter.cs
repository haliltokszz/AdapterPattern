using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EnemyAdapter:IEnemy
    {
        private readonly INewEnemy _newEnemy;
        public EnemyAdapter(INewEnemy newEnemy)
        {
            _newEnemy = newEnemy;
        }
      
        public void EnemyName(string enemyName)
        {
            _newEnemy.RobotName(enemyName);
        }

        public void SpeedUp()
        {
            _newEnemy.Walk();
        }

        public void UseGun()
        {
            _newEnemy.Punch();
        }
    }
}
