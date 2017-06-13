using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClasses
{
    public sealed class DbSingletonConn
    {
        private static readonly string conn_string =
            @"Driver={SQL Server};Server=SBT-PC1\SQLEXPRESS;Database=DBModel.Context";
        private static readonly Lazy<DbSingletonConn> lazy = new Lazy<DbSingletonConn>(()=> new DbSingletonConn());

        private static OdbcConnection conn = null;

        public static DbSingletonConn Instance { get { return lazy.Value; } }

        private DbSingletonConn()
        {
            conn = new OdbcConnection(conn_string);
            conn.Open();
        }

        public OdbcDataReader GetReader(String sql)
        {
            OdbcCommand command = conn.CreateCommand();
            command.CommandText = sql;
            return command.ExecuteReader();
        }
            
    }
}
