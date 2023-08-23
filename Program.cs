using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace RtanWorld
{
    internal class Program
    {

        public static Character player;
        public static Item[] Inventory;

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
            Console.WriteLine("닉네임 : {0}({1})", player.Name, player.Job);
            Console.WriteLine("공격력 : {0}", player.Atk);
            Console.WriteLine("방어력 : {0}", player.Def);
            Console.WriteLine("체력 : {0}", player.Hp);
            Console.WriteLine("소지골드 : {0}", player.Gold);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.WriteLine(">>");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int ret))
            {
                if (ret == 0)
                {
                    //메인 화면
                    gameStart();
                }
                else
                {
                    Console.WriteLine("잘못입력했음");
                }

            }


        }
        static void ItemInfo()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. 장착하기");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.WriteLine(">>");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int ret))
            {
                if (ret == 1)
                {
                    //장비장착
                }
                else if (ret == 0)
                {
                    //메인화면으로 나가기
                    gameStart();
                }
                else
                {
                    Console.WriteLine("잘못 입력했습니다.");
                }

            }
        }


        static void playerInfo()
        {

            player = new Character("Name", "전사", 10, 20, 5, 100, 1000, 0, 0);
            Inventory = new Item[10];


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

            string input = Console.ReadLine();

            if (int.TryParse(input, out int ret))
            {
                if (ret == 1)
                {
                    //인포창
                    CaracterInfo();

                }
                if (ret == 2)
                {
                    //인벤토리창
                    ItemInfo();
                }
                else
                {
                    Console.WriteLine("잘못입력했음");
                }
            }
        }
        static void EquipItem(Item item)
        {
            item.IsEquiped = true;
        }
        static void UnEquipItem(Item item)
        {
            item.IsEquiped = false;
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

            public int AddAtk { get; }
            public int AddDef { get; }


            public Character(string name, string job, int level, int atk, int def, int hp, int gold, int addAtk, int addDef)
            {
                Name = name;
                Job = job;
                Level = level;
                Atk = atk;
                Def = def;
                Hp = hp;
                Gold = gold;
                AddAtk = addAtk;
                AddDef = addDef;

            }

        }
        public class Item
        {
            public string Name { get; }
            public int ItemAtk { get; }
            public int ItemDef { get; }
            public string Description { get; }


            public bool IsEquiped { get; set; }

            public Item(string name, int itemAtk, int itemDef, string description)
            {
                Name = name;
                ItemAtk = itemAtk;
                ItemDef = itemDef;
                Description = description;



                IsEquiped = false;
            }

        }

    }
}
