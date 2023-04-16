public class Query
{
    public Album GetAlbum() =>
        new Album
        {
            Title = "Aptosis",
            Band = new Band {
                Name = "Allegeon",
                Members = new List<Member> {
                    new Member {Name = "Riley McShane"},
                    new Member {Name = "Greg Burgess"},
                    new Member {Name = "Michael Stancel"},
                    new Member {Name = "Brandon Michael"},
                    new Member {Name = "Jeff Saltzman"},
                }
            }
        };
}
