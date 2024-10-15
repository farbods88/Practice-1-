// if-else fight
int ammoCount = 10;
int health = 100;

ammoCount = 4;
health = 40;


if ( ammoCount >= 5 && health >= 50)
{
    Console.WriteLine ("Arthur continues the fight");
}

else if (ammoCount >= 5 && health <= 50)
{
    Console.WriteLine ("Arthur is low on health but has enough ammo");
}

else if (ammoCount <= 5 && health >= 50)
{
    Console.WriteLine ("Arthur has low ammo but high health");
}

else 
{
    Console.WriteLine ("Arthur decides to retreat");
}
