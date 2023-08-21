using System.Reflection.Metadata.Ecma335;

namespace RtanWorld
{
    internal class Program
    {
        private static Character player;
       

        static void Main(string[] args)
        {
            
            gameStart();//메인화면 문구
        
        }
        static void CaracterInfo()
        {
            playerInfo();
            Console.Clear();
            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n\n\n\n");
            Console.WriteLine("레벨 : {0}", player.Level);
            Console.WriteLine("닉네임 : {0}({1})",player.Name,player.Job);
            Console.WriteLine("공격력 : {0}",player.Atk);
            Console.WriteLine("방어력 : {0}",player.Def );
            Console.WriteLine("체력 : {0}",player.Hp);
            Console.WriteLine("소지골드 : {0}",player.Gold ); 
            Console.WriteLine("\n\n0. 나가기\n\n\n");
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Input();


        }
        static void Input()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number == 1)
                {
                    CaracterInfo();
                }
                else if (number == 2)
                {
                    Inventory();
                }

                else if (number == 0) 
                {
                    gameStart();
                }                               
            }
        }
        static void Inventory() 
        {
            Console.Clear();
        }
        static void playerInfo()
        {
            
            player = new Character("LEE", "궁수", 10, 20, 5, 100, 1000);
        }
        static void gameStart()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("스파르타 마을에 오신 여러분을 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가지 전 활동을 할 수 있습니다.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("원하시는 행동의 번호를 입력해주세요");
            Input();
        }
    }
    public class Character
    {
        public string Name { get; }
        public string Job { get; }
        public int Level { get; }
        public int Atk { get; }
        public int Def { get; }
        public int Hp { get; }
        public int Gold { get; }

        public Character(string name, string job, int level, int atk,int def, int hp, int gold) 
        {
            Name = name;
            Job = job;
            Level = level;
            Atk = atk;
            Def = def;
            Hp = hp;
            Gold = gold;

        }
        
    }

}