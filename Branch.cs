

namespace Hospital__registration;

public class Branch
{
    public string BranchName { get; set; }

    public Branch(string branchName)
    {
        BranchName = branchName;
    }

    public override string ToString()=>
        $"BranchName:{BranchName}";


}
