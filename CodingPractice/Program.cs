using System;

// README.md를 읽고 코드를 작성하세요.
//1.
/*
Player player = new Player();
player.ShowStatus();

class Player
{
    string name;
    int health;

    public void ShowStatus()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("체력: " + health);
    }
}


//2.
Character hero = new Character();
hero.name = "용사";
hero.level = 10;
Console.WriteLine(hero.name);
Console.WriteLine(hero.level);
class Character
{
    public string name;
    public int level;
}


//3.
Character hero = new Character();
hero.SetInfo("용사", 10);
hero.showInfo();
class Character
{
    private string name;
    private int level;

    public void SetInfo(string n, int lv)
    {
        name = n;
        level = lv;
    }

    public void showInfo()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("레벨: " + level);
    }
}


//4.
Player player = new Player();
player.ShowStatus();
class Player
{
    private string name = "이름없음";
    private int health = 100;
    private int level = 1;

    public void ShowStatus()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("체력: " + health);
        Console.WriteLine("레벨: " + level);
    }
}


//5.
Say say = new Say();
say.Hi();
class Say
{
    private string message = "안녕하세요.";

    public void Hi()
    {
        message = "반갑습니다.";
        Console.WriteLine(message);
    }
}


//6.
Schedule schedule = new Schedule();
schedule.PrintWeekDays();
class Schedule
{
    private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

    public void PrintWeekDays()
    {
        foreach (var day in weekDays)
        {
            Console.Write(day + "\n");
        }
        Console.WriteLine();
    }

}


//7.
DefaultValues dv = new DefaultValues();
dv.ShowDefaults();
class DefaultValues
{
    private int number;
    private bool flag;
    private string text;

    public void ShowDefaults()
    {
        Console.WriteLine("number: " + number);
        Console.WriteLine("flag: " + flag);
        Console.WriteLine("text: " + (text == null ? "null" : text));
    }
}


//8.
Counter c1 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);

Counter c2 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);

Counter c3 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);

class Counter
{
    public static int count = 0;

    public Counter()
    {
        count++;
    }
}


//9.
Player p1 = new Player("용사");
Player p2 = new Player("마법사");
Player p3 = new Player("궁수");

Console.WriteLine(p1.name);
Console.WriteLine(p2.name);
Console.WriteLine(p3.name);
Console.WriteLine("총 플레이어 수: " + Player.totalCount);
class Player
{
    public string name;
    public static int totalCount;

    public Player (string n)
    {
        name = n;
        totalCount++;
    }
}


//10.
GameConfig config = new GameConfig(4);
config.ShowConfig();
class GameConfig
{
    public readonly string version = "1.0.0";
    public readonly int maxPlayers;

    public GameConfig(int max)
    {
        maxPlayers = max;
    }

    public void ShowConfig()
    {
        Console.WriteLine("버전: " + version);
        Console.WriteLine("최대 플레이어: " + maxPlayers);
    }
}


//11.
Example ex = new Example();
ex.ShowValues();
class Example
{
    public const double Pi = 3.14159;

    public readonly DateTime ceatedAt = DateTime.Now;

    public void ShowValues()
    {
        Console.WriteLine("원주율: " + Pi);
        Console.WriteLine("생성 시간: " + ceatedAt);
    }
}


//12.
Player player = new Player();
player.SetInfo("용사", 10);
player.ShowInfo();
 class Player
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine("이름: " + this.name);
        Console.WriteLine("레벨: " + this.level);
    }
}
*/

//13.
Person person = new Person();
person.ShowProfile();
class Person
{
    private string name = "홍길동";
    private const int Age = 21;
    private readonly string nickname = "길동이";
    private string[] websites = { "네이버", "구글" };

    public void ShowProfile()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("나이: " + Age);
        Console.WriteLine("닉네임: " + nickname);
        Console.WriteLine("사이트: " + string.Join(",", websites));
    }
}