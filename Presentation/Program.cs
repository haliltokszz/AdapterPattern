using System;
using Business;
using Entities;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnemy enemyRobot= CreateEnemiesFactory.CreateEnemy(EnemyType.Robot);
            enemyRobot.EnemyName("Fatma Yürek");
            enemyRobot.SpeedUp();
            enemyRobot.UseGun();
    
            IEnemy enemyTank= CreateEnemiesFactory.CreateEnemy(EnemyType.Tank);
            enemyTank.EnemyName("Halil Toksöz");
            enemyTank.SpeedUp();
            enemyTank.UseGun();
            
            Console.ReadKey();
        }
    }
}