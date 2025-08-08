class Program{
    static void Main(){
        string s = Console.ReadLine();
        int tcCount = int.Parse(s);
        
        for(int i = 1; i <= tcCount; i++){
            Console.WriteLine($"Hello World, Judge {i}!");
        }
    }
}