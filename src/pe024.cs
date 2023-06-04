using ProjectEuler.Contracts;

namespace ProjectEuler;

//backtracking technique
public class pe024 : IGet
{
    public void Get()
    {
        var permutations = Permute(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9});

        foreach (var item in permutations[999999])
        {
            Console.Write(item);
        }
    }
    
    private static IList<IList<int>> Permute(int[] nums)
    {
        var permutations = new List<IList<int>>();
        Solve(nums, permutations, new List<int>(), new bool[nums.Length]);
        return permutations;
    }

    private static void Solve(int[] nums, IList<IList<int>> permutations, IList<int> permutation, bool[] visited)
    {
        if (permutation.Count == nums.Length)
        {
            permutations.Add(new List<int>(permutation));
           return;
        }

        //no need to calculate all the permutations.
        if (permutations.Count > 1000002)
            return;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if(!visited[i])
            {
                permutation.Add(nums[i]);
                visited[i] = true;
                Solve(nums, permutations, permutation, visited);
                permutation.RemoveAt(permutation.Count - 1);
                visited[i] = false;
            }
        }
    }
}