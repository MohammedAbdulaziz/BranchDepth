using System;
using System.Collections.Generic;

class Branch
{
    public List<Branch> branches;

    public Branch()
    {
        branches = new List<Branch>();
    }
}

class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    static void Main()
    {
        // Initialize the hierarchy
        var root = InitializeHierarchy();

        // Calculate the depth of the hierarchy
        int depth = CalculateDepth(root);

        // Print the depth
        Console.WriteLine("Depth: " + depth);
    }

    /// <summary>
    /// Initializes the hierarchical structure.
    /// </summary>
    /// <returns>The root branch of the hierarchy.</returns>
    static Branch InitializeHierarchy()
    {
        // Create the hierarchical structure
        var root = new Branch();
        var branch1 = new Branch();
        var branch2 = new Branch();
        var branch3 = new Branch();
        var branch4 = new Branch();
        var branch5 = new Branch();
        var branch6 = new Branch();
        var branch7 = new Branch();
        var branch8 = new Branch();
        var branch9 = new Branch();
        var branch10 = new Branch();

        // Connect the branches to form the hierarchy
        root.branches.Add(branch1);
        root.branches.Add(branch2);

        branch1.branches.Add(branch3);

        branch2.branches.Add(branch4);
        branch2.branches.Add(branch5);
        branch2.branches.Add(branch6);

        branch4.branches.Add(branch7);

        branch5.branches.Add(branch8);
        branch5.branches.Add(branch9);

        branch8.branches.Add(branch10);

        // Return the root of the hierarchy
        return root;
    }

    /// <summary>
    /// Calculates the depth of a branch in the hierarchy.
    /// </summary>
    /// <param name="branch">The branch to calculate the depth for.</param>
    /// <returns>The depth of the branch.</returns>
    static int CalculateDepth(Branch branch)
    {
        // Base case: if the branch has no sub-branches, return 0
        if (branch.branches.Count == 0)
            return 0;

        int maxDepth = 0;

        // Recursive case: iterate over sub-branches and calculate the depth
        foreach (var subBranch in branch.branches)
        {
            int depth = CalculateDepth(subBranch);
            maxDepth = Math.Max(maxDepth, depth);
        }

        // Increment the depth by 1 and return
        return maxDepth + 1;
    }
}
