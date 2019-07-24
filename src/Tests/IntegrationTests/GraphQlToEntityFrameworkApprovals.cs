using ApprovalTests;

public class GraphQlToEntityFrameworkApprovals
{
    public static void Verify(string graphQlInput)
    {Approvals.Verify(graphQlInput);
    }
}