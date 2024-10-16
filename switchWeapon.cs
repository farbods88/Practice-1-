//Switch weapons

string selectedWeapon = "null";

switch (selectedWeapon)
{
    case "Revolver":
        Console.WriteLine ("Arthur pulls out his revolver.");
        break;
    case "Rifle":
        Console.WriteLine ("Arthur prepares his rifle for long-range combat.");
        break;
    case "Bow": 
        Console.WriteLine ("Arthur grabs his bow for silent kills.");
        break;
    default: 
        Console.WriteLine ("Arthur is unarmed.");
        break;
}
