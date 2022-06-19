using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Interfaces;
using ToDoApp.ToDoObjects;

namespace ToDoApp.Repositories
{
    public class ToDoRepo : IToDoEr
    {
        private readonly ToDoDbContext _context;
        public ToDoRepo(ToDoDbContext context)
        {
            _context = context;
        }
        public void AddRecord(ToDoRecord person)
        {
            _context.Add(person);
            _context.SaveChanges();
        }

        public void DeleteRecord(Guid person)
        {
            var Hi =_context.ToDoRecords.First(x => x.Id == person);
            _context.Remove(Hi);
            _context.SaveChanges();
        }
        public void EditRecord(ToDoRecord person)
        {
            var editing = _context.ToDoRecords.First(x => x.Id == person.Id);
            editing.Type = person.Type;
            editing.Content = person.Content;
            editing.EndDate = person.EndDate;
            _context.SaveChanges();
        }

        public IEnumerable<ToDoRecord> ShowRecords()
        {
            //var recordsDto = new List<ToDoRecordDto>();
            //foreach(var x in _context.ToDoRecords.ToList())
            //{
            //    recordsDto.Add(new ToDoRecordDto(x.Type, x.Content, x.EndDate, x.User));
            //}
            return _context.ToDoRecords.ToList();
        }
    }
}
