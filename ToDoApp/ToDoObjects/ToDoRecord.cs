using System;


namespace ToDoApp.ToDoObjects
{
    public class ToDoRecord
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string EndDate { get; set; }
        
        public string User { get; set; }

        public ToDoRecord(string type, string content, string endDate, string user)
        {
            Id = Guid.NewGuid();
            Type = type;
            Content = content;
            EndDate = endDate;
            User = user;
        }
    }
}
