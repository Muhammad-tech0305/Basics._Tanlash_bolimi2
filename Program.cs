using System;

// 1-topshiriq
Console.WriteLine("\n < VAQT KALKULYATORI > ");

Console.Write("Daqiqalar sonini kiriting: ");
int minutes = Convert.ToInt32(Console.ReadLine());
int hour = minutes / 60;
int minute = minutes % 60;

Console.WriteLine($"Soat >>> {hour}:{minute}");

// 2-topshiriq
Console.WriteLine("\n < YOSH TOIFASINI ANIQLASH > ");

Console.Write("Yoshingiz nechada: ");
int age = int.Parse(Console.ReadLine());

string toifa = ((age >= 0) && (age <= 12))
    ? "Siz hali \'bolasiz\'."
    : ((age >= 13) && (age <= 19))
        ? "Siz \'o'smirsiz\'."
        : ((age >= 20) && (age <= 59))
            ? "Siz \'kattalar\'dansiz."
            : "Siz \'katta\'siz.";
Console.WriteLine(toifa);

// 3-topshiriq
Console.WriteLine("\n < O'RTACHA BALLNI HISOBLASH > ");

Console.WriteLine("3 ta fan bo'yicha baholarizni yozing (0 dan 100 gacha): ");
int[] ball = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"{i+1}-fan: ");
    ball[i] = Convert.ToInt16(Console.ReadLine());

    string baho = ((ball[i] >= 80) && (ball[i] <= 100))
        ? "Bahoyiz A'lo!"
        : ((ball[i] >= 60) && (ball[i] <= 79))
            ? "Bahoyiz Yaxshi!"
            : ((ball[i] >= 40) && (ball[i] <= 59))
                ? "Bahoyiz Qoniqarli"
                : ((ball[i] >= 0) && (ball[i] < 40))
                    ? "Bahoyiz Qoniqarsiz"
                    : "Bunday ball mavjud emas.";
Console.WriteLine(baho);     
}

// 4-topshiriq
Console.WriteLine("\n < \"RAQAMNI TOPING\" O'YINI > ");

Random Son = new Random();
int son = Son.Next(1, 101);
int guess;

Console.Write("Men bir son o'yladim (1 - 100), uni topib ko'ringchi...\n>>> ");

do
{
Console.Write("Taxminingizni kiriting: ");
guess = int.Parse(Console.ReadLine());
Console.WriteLine
    (
        guess < son 
        ? "Yo'q, son kattaroq!" 
        : guess > son 
        ? "Yo'q, son kichikroq!" 
        : $"To'g'ri topdingiz!: {son}"
    );
} while (guess != son);
