namespace console_api
{
    public class GetUsersResponse
    {
        public string? login { get; set; }
        public string? avatar_urlavatar_url { get; set; }
        public string? url { get; set; }
        public string? repos_url { get; set; }
        public bool site_admin { get; set; }
        public string? location { get; set; }
        public string? bio { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
