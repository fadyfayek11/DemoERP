namespace DemoERP.Domain;

public class EmailReminder
{
    public int EmailId { get; set; }
    public string Title { get; set; }
    public DateTime DateTime { get; set; }
    public bool IsSent { get; set; } 

}