using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business
{
    public static class CreateEnemiesFactory 
    {

        public static IEnemy CreateEnemy(EnemyType enemyType)
        {
            if (enemyType==EnemyType.Robot)
            {
                return new EnemyAdapter(new EnemyRobot());           
            }

            else
            {             
                return new EnemyTank();
               
            }
           
        }
    }
}
