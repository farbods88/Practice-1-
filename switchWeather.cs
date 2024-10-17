//Switch weather

string weatherCondition = "null";

switch (weatherCondition)
{
    case "Sunny":
        Console.WriteLine ("Arthur enjoys the sunny weather.");
        break;
    case "Rainy":
        Console.WriteLine ("Arthur puts on his raincoat.");
        break;
    case "Snowy":
        Console.WriteLine ("Arthur wraps himself.");
        break;
    case "Windy":
        Console.WriteLine ("Arthur holds onto his hat.");
        break;
    default :
        Console.WriteLine ("Unknown weather.");
        break;
}
