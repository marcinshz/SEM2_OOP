using System;

namespace PD07._06
{
    class DB_NOT_INIT : ApplicationException
    {
        public DB_NOT_INIT(string message) : base(message)
        { }
    }
    class DB_OPEN_ERROR : ApplicationException
    {
        public DB_OPEN_ERROR(string message):base(message)
        { }
    }
    class DB_CLOSE_ERROR : ApplicationException
    {
        public DB_CLOSE_ERROR(string message) : base(message)
        { }
    }
    class DB_ACCESS_ERROR : ApplicationException
    {
        public DB_ACCESS_ERROR(string message) : base(message)
        { }
    }
    class Baza
    {
        public const int DB_OK = 0;
        public const int DB_NOT_INIT = -1;
        public const int DB_OPEN_ERROR = -2;
        public const int DB_CLOSE_ERROR = -3;
        public const int DB_ACCESS_ERROR = -4;
        Random random;
        public Baza()
        {
            random = new Random();

        }
        public int dbInit()
        {
            if (random.Next(7) % 4 != 0) return DB_OK;
            throw new DB_NOT_INIT("Not init");
        }

        public int dbOpen(string name)
        {
            if (random.Next(6) % 4 != 0) return 1;
            throw new DB_OPEN_ERROR("Blad przy odczycie");
        }

        public int dbGetData(int field, char[] data)
        {
            if (random.Next(5) / 4 != 0) throw new DB_ACCESS_ERROR("Blad przy otwarciu");
            int i = 0;
            for (; i < 10; i++)
                data[i] = (char)(i + 48);
            data[i] = (char)0x00;
            return DB_OK;
        }

        public int dbClose(int handle)
        {
            if (random.Next(8) % 4 != 0) return DB_OK;
            throw new DB_CLOSE_ERROR("Blad przy zamknieciu");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Baza b = new Baza();

        }
    }

}
