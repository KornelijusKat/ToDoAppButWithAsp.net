using System;
using System.Collections.Generic;
using ToDoApp.ToDoObjects;

namespace ToDoApp.Interfaces
{
   public interface IToDoEr
    {
        void AddRecord(ToDoRecord person);
        IEnumerable<ToDoRecord> ShowRecords();
        void DeleteRecord(Guid person);
        void EditRecord(ToDoRecord person);
    }
}
