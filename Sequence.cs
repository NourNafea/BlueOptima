
public class Sequence
{
    public static bool isDivisible(int number, int divisor) {
        return number % divisor == 0;
    }
    public static List<String> sequence(int N) {
        List<String> results = new List<String>();
        for (int i = 0; i<N; i++)
        {
            results.Add(i.ToString());
        }
        foreach (var item in results.ToList())
        {
            var state1 = isDivisible(Int32.Parse(item), 7);
            var state2 = isDivisible(Int32.Parse(item), 11);
            if(state1){
                results[Int32.Parse(item)] = "Goose";
            }
            else if (state2){
                results[Int32.Parse(item)] = "Mouse";
            }
            if (state1 && state2){
                results[Int32.Parse(item)] = "GooseMouse";
            }
        }
    
        return results;
    }

    public static void Main()
    {
        foreach (String s in sequence(100)) {
            Console.WriteLine(s);
        }
    }
}
