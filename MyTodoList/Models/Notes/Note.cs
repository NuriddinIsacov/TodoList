namespace MyTodoList.Models.Notes
{
    public class Note
    {
        private string _title = string.Empty;
        public int Id { get; set; }
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }



    }
}
