public class Album
{
    public string Title { get; set; }

    public Band Band { get; set; }
}

public class Band
{
    public string Name { get; set; }
    public List<Member> Members {get;set;}
}

public class Member {
    public string Name {get;set;}
}
