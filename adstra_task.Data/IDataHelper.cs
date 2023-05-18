using System;
using System.Collections.Generic;
using System.Text;

namespace adstra_task.Data
{
    public interface IDataHelper<Table>
    {
        //read
        List<Table> GetAllData();
        List<Table> GetDataByUser(string UserId);
        List<Table> Search(string SearchItem);
        Table Find(int Id);
        //write
        int Add(Table table);
        int Edit(int Id, Table table);
        int Delete(int Id);
        




    }
}
