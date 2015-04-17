namespace LoveSeat.Support
{
    public class ReplicationOptions
    {
        private readonly string source;
        private readonly string target;
        private readonly bool continuous;
        private readonly bool cancel;
        private readonly string query_params;

        public ReplicationOptions(string source, string target, bool continuous, bool cancel, string query_params)
        {
            this.source = source;
            this.target = target;
            this.continuous = continuous;
            this.cancel = cancel;
            this.query_params = query_params;
        }

        public ReplicationOptions(string source, string target, bool continuous, string query_params)
        {
            this.source = source;
            this.target = target;
            this.continuous = continuous;
            this.query_params = query_params;
        }
        public ReplicationOptions(string source, string target, bool continuous, bool cancel)
            : this(source, target, continuous, cancel, null)
        {
        }
        public ReplicationOptions(string source, string target)
            : this(source, target, false, false)
        {
        }

        public override string ToString()
        {
            string result = @"{ ""source"": ""%source%"", ""target"" : ""%target%"", ""continuous"" : %continuous%, ""cancel"" : %cancel% " +
                            (string.IsNullOrEmpty(query_params) ? "" : @", ""query_params"" : %query_params%") +
                            " }";
            result = result.Replace("%source%", source).Replace("%target%", target).Replace("%query_params%", query_params).Replace("%continuous%", continuous.ToString().ToLower())
                .Replace("%cancel%", cancel.ToString().ToLower());
            return result;
        }
    }
}