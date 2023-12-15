using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp.ConsoleApp.Logic
{
    public interface IDataAccess
    {
        void InsertData(int id, string name);
        void UpdateData(int id, string name);
        void DeleteData(int id);
        void ReadData();
    }
}
