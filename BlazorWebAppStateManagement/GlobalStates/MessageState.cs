namespace BlazorWebAppStateManagement.GlobalStates
{
    public class MessageState
    {
        public string Message { get; set; }
        public void SetMessage(string incomingText)
        {
            Message = incomingText;
        }
        public void ClearMessage()
        {
            Message = "";
        }
    }
}
