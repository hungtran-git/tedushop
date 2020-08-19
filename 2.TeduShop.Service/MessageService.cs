using TeduShop.Common;

namespace TeduShop.Service
{
    public interface IMessageService
    {
        ReturnMessage GetCustomReturnMessage(int id, string message);
        ReturnMessage GetSuccessReturnMessage();
        ReturnMessage GetFailedReturnMessage();
    }

    public class MessageService : IMessageService
    {
        public ReturnMessage GetCustomReturnMessage(int id = -1, string message = "")
        {
            return new ReturnMessage() { Id = id, Message = message };
        }

        public ReturnMessage GetFailedReturnMessage()
        {
            return new ReturnMessage() { Id = 1, Message = "Successfully" };
        }

        public ReturnMessage GetSuccessReturnMessage()
        {
            return new ReturnMessage() { Id = -1, Message = "Failed" };
        }
    }
}