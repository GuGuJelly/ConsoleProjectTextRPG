using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextRPG_RogueLike
{
    internal class Program
    {
        // 원래는 몬스터가 존재하는 방을 연결리스트로 만들고,
        // 각 방에 있는 몬스터를 하나씩 처치하고 보스몬스터도 처치하고
        // 끝에 있는 골에 도달하는 게임을 만들려고 했는데
        // 연결리스트에 맵을 구현하는 것도 못하고
        // 플레이어가 스킬을 쓰는 함수에서 Player클래스에 Game 데이터를 인수로 못담아서 플레이어 스킬 효과 구현을 못했습니다
        // 이 클래스에서 저 클래스 참조할려고 할려니 null 이라고 출력되는 오류를 고치는게 너무 힘들어서
        // 조교님에게도 물어봤는데 설명을 듣고 돌아가서 해볼려고 하니까 또 막혀서 그리고 시간이 끝났습니다.
        

        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }
    }
}
