namespace Day03_Exception_File;

class Program
{
    static void Main(string[] args)
    {
        var numString = "10.5";
        
        int num = int.Parse(numString);
        // The input string '10.5' was not in a correct format.
        // 입력 문자열 '10.5'가 올바른 형식이 아닙니다.
        
        Console.WriteLine(num);

        // // 새로 쓰기
        // File.WriteAllText("text.txt", "Hello World!");
        // File.WriteAllText("text.txt", "Hello World!");
        //
        //
        // // 뒤에 붙이기(Append)
        // File.AppendAllText("text.txt", "붙이기");
        // File.AppendAllText("text.txt", "붙이기");
        // File.AppendAllText("text.txt", "붙이기");
        //
        // // 붙이고 내리기
        // File.AppendAllText("text.txt", "내리기\n");
        // File.AppendAllText("text.txt", "내리기\n");
        // File.AppendAllText("text.txt", "내리기\n");
        //
        // string text = File.ReadAllText("text.txt");
        //
        // string[] lines = File.ReadAllLines("text.txt");
        //
        // try
        // {
        //     File.ReadAllText("test.txt");
        // }
        // catch(FileNotFoundException e)
        // {
        //     Console.WriteLine("파일이 없습니다.");
        // }
    }
}