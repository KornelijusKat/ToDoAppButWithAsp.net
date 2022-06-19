

namespace ToDoApp.ToDoObjects
{
    public class ToDoRecordDto
    {
        public string type { get; set; }
        public string content { get; set; }
        public string endDate { get; set; }
        public string user { get; set; }

        public ToDoRecordDto(string type, string content, string endDate, string user)
        {
            this.type = type;
            this.content = content;
            this.endDate = endDate;
            this.user = user;
        }
    }
}
