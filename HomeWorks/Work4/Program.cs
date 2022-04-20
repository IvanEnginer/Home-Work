using System;

namespace Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            uint lineCopasity = 3;
            uint folderCopasity = 52;
            uint fullLines = folderCopasity / lineCopasity;
            uint remainder = folderCopasity - fullLines * lineCopasity; // при использовании % необходимо думать о преобрзовании типов
                                                                        // предпочитаю не пользоваться без необходимости
            Console.WriteLine("Full lines = " + fullLines + "," + " remainder = " + remainder);
        }
    }
}
