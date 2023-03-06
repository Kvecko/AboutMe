Console.ForegroundColor = ConsoleColor.Magenta;

string[] zajmy = {"Zdravím, jmenuji se Tomáš 'Kvéčko' Pabián, aktuálně studuji na SŠ Educhem",
                    "", "Mezi mé oblíbené věci patří:", "Hry a obzvlášť FPSka", "Ping Pong",
                    "Fialková FTW", "average vesnice > město chad"};

Console.WriteLine("");

foreach (var item in zajmy)
{
    Console.WriteLine(item);
}