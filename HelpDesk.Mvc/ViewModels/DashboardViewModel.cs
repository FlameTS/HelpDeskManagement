namespace HelpDesk.Mvc.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalTickets { get; set; }

        public int OpenTickets { get; set; }

        public int InProgressTickets { get; set; }

        public int ClosedTickets { get; set; }
    }
}