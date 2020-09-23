using System;

namespace HelloWorld
{
    public class DbMigrator
    {
        private ILogger _logger { get; }

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " +DateTime.Now);
            _logger.LogInfo("Migration ended at " + DateTime.Now);
        }
    }
}
