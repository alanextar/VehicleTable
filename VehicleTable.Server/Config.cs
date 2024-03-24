namespace VehicleTable
{
    public class Config
    {
        public string ConnectionString { get; }

        public Config()
        {
            ConnectionString = GetEnvStrict("SQL_CONNECTION_STRING");
        }

        private string GetEnvStrict(string name)
        {
            var env = Environment.GetEnvironmentVariable(name);
            if (env is null or "")
                throw new ArgumentNullException(name);

            return env;
        }
    }
}
