using System;

namespace _002_FactoryMethod
{
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();
        public abstract string State
        {
            get;
        }
    }

    public abstract class Command
    {
        public abstract void Execute(string query);
    }

    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
    ////////////////////////////////////////////////////////////
    
    public class DB2Connection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("DB2 Bağlantısı açılacak");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("DB2 Bağlantısı kaptılacak");
            return true;
        }
    }
    public class DB2Command : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("DB2 Sorgusu çalıştırılır.");
        }
    }

    public class DB2Factory : DatabaseFactory
    {
        public override Connection CreateConnection()
        {
            return new DB2Connection();
        }

        public override Command CreateCommand()
        {
            return new DB2Command();
        }
    }
    /// //////////////////
    public class MySqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("MySql Bağlantısı açılacak");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("MySql Bağlantısı kaptılacak");
            return true;
        }
    }
    public class MySqlCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("MySql Sorgusu çalıştırılır.");
        }
    }

    public class MySqlFactory : DatabaseFactory
    {
        public override Connection CreateConnection()
        {
            return new MySqlConnection();
        }

        public override Command CreateCommand()
        {
            return new MySqlCommand();
        }

    }
    ////////////////////////////////////////////////////////////

    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection  _connection;
        private Command     _command;

        public Factory(DatabaseFactory databaseFactory)
        {
            _databaseFactory    = databaseFactory;
            _connection         = _databaseFactory.CreateConnection();
            _command            = _databaseFactory.CreateCommand();
        }
        public void Start()
        {
            _connection.Connect();
            if (_connection.State == "Open")
                _command.Execute("Select ..");
        }
    }

}
