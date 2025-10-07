namespace Domain.Model
{
    public class SearchCriteria
    {
        public string Text { get; private set; }

        public SearchCriteria(string text)
        {
            Text = text.Trim();
        }
    }
}
