using System;

// 1. Create Delegate
public delegate void VotingCountChangedHandler(
    object sender,
    string Constituency,
    int newVotingCount
);

// 2. Publisher Class
public class Election
{
    // 3. Create Event
    public event VotingCountChangedHandler? VotingCountChanged;

    private int votingCount;

    public string Constituency { get; }

    // 4. Constructor
    public Election(string Constituency, int initialVotingCount)
    {
        this.Constituency = Constituency;
        votingCount = initialVotingCount;
    }

    // 5. Business Logic
    public int VotingCount
    {
        get
        {
            return votingCount;
        }

        set
        {
            if (votingCount != value)
            {
                votingCount = value;

                // 6. Raise Event
                OnVotingCountChanged(Constituency, value);
            }
        }
    }

    // 7. Event Handler Method
    protected void OnVotingCountChanged(
        string Constituency,
        int newVotingCount)
    {
        // Call all Subscribers
        VotingCountChanged?.Invoke(
            this,
            Constituency,
            newVotingCount
        );
    }
}

// 8. Subscriber Class - District
public class District
{
    public static void UpdateToDistrictOffice(
        object sender,
        string Constituency,
        int newVotingCount)
    {
        Console.WriteLine(
            "District Office: " + Constituency +
            " - " + newVotingCount
        );
    }
}

// 9. Subscriber Class - State
public class State
{
    public static void UpdateToStateOffice(
        object sender,
        string Constituency,
        int newVotingCount)
    {
        Console.WriteLine(
            "State Office: " + Constituency +
            " - " + newVotingCount
        );
    }
}

// 10. Subscriber Class - Union
public class Union
{
    public static void UpdateToUnionOffice(
        object sender,
        string Constituency,
        int newVotingCount)
    {
        Console.WriteLine(
            "Union Office: " + Constituency +
            " - " + newVotingCount
        );
    }
}

// 11. Main Program
class Taskprogram
{
    static void Main()
    {
        Election election =
            new Election("Madurai", 0);

        // 12. Add Subscribers
        election.VotingCountChanged +=
            District.UpdateToDistrictOffice;

        election.VotingCountChanged +=
            State.UpdateToStateOffice;

        election.VotingCountChanged +=
            Union.UpdateToUnionOffice;

        // 13. First Update
        Console.WriteLine("First Update:");

        election.VotingCount = 111;

        Console.WriteLine();

        // 14. Second Update
        Console.WriteLine("Second Update:");

        election.VotingCount = 450;

        Console.WriteLine();

        // 15. Unsubscribe District
        election.VotingCountChanged -=
            District.UpdateToDistrictOffice;

        // 16. Third Update
        Console.WriteLine("Third Update:");

        election.VotingCount = 785;
    }
}