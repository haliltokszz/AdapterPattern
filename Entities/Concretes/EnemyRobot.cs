using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EnemyRobot : INewEnemy
    {
        public void Punch()
        {
            Console.WriteLine("Enemy Robot Punch");
        }

        public void RobotName(string robotName)
        {
            Console.WriteLine("Enemy Robot Name:"+robotName);
        }

        public void Walk()
        {
            Console.WriteLine("Enemy Robot Walk");
        }
    }
}
