using System;
using System.Collections.Generic;
using System.Text;
using COMCMS.Common;
using Dos.ORM;

namespace COMCMS.Core
{
    public static class DB
    {
        public static readonly DbSession Context = new DbSession(DatabaseType.MySql, Utils.Configuration["connectionStrings:dbconn:connectionString"]);

    }
}
