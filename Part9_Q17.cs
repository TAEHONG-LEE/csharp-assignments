using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static public void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine("0으로 나눌 수 없습니다" + e.Message); //어떻게 출력해야하는지 
                //https://hobbylife.tistory.com/entry/C%EC%97%90%EC%84%9C-%EC%98%88%EC%99%B8-%EC%B2%98%EB%A6%AC%EB%A5%BC-%ED%95%98%EB%8A%94-5%EA%B0%80%EC%A7%80-%EB%B0%A9%EB%B2%95try-catch 참고
            }
        }
    }
}
