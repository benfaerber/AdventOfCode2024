class Day1 {
    public static (List<int>, List<int>) LoadData() {
        var raw = File.ReadAllText("./data/day1.txt");
        var parts = raw.Trim().Split("\n");
        var left = new List<int>();
        var right = new List<int>();
        foreach (string part in parts) {
            var sides = part.Split("   ");
            left.Add(int.Parse(sides[0]));
            right.Add(int.Parse(sides[1]));
        } 
        return (left, right); 
    }


    public static void Compute() {
        var (left, right) = LoadData();
        left.Sort();
        right.Sort();
        int total = 0;
        foreach ((int l, int r) in left.Zip(right)) {
            var dist = Math.Abs(l - r);
            total += dist;
        }

        Console.WriteLine(total);
    }
}


