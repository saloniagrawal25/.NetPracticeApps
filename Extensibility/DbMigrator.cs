using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
{
    public class DbMigrator 
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            this._logger = logger; 
        }
        public void Migrate()
        {
            _logger.LogInfo(string.Format("Migraton started at {0}", DateTime.Now));

            //process

            _logger.LogInfo(string.Format("Migraton finisted at {0}", DateTime.Now));
        }
    }
}
