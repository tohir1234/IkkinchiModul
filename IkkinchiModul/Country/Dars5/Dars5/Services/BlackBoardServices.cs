using Dars5.Models;

namespace Dars5.Services
{
    public class BlackBoardServices : IBlackBoardServices
    {

        List<BlackBoard> BlackBoards;
        public BlackBoardServices()
        {
            BlackBoards = new List<BlackBoard>();
        }
        public Guid AddBlackBoard(BlackBoard blackboard)
        {
            blackboard.BlackBoardId = Guid.NewGuid();
            BlackBoards.Add(blackboard);
            return blackboard.BlackBoardId;

        }

        public bool DeleteBlackBoard(Guid blackboardId)
        {
            foreach (var blackboard in BlackBoards)
            {
                if (blackboard.BlackBoardId == blackboardId)
                {
                    BlackBoards.Remove(blackboard);
                    return true;
                }
            }
            return false;
        }

        public BlackBoard? GetBalckBoardByID(Guid blackboardId)
        {

            foreach (var blackboard in BlackBoards)
            {
                if (blackboard.BlackBoardId == blackboardId)
                {
                    return blackboard;
                }
            }
            return null;
        }

        public List<BlackBoard> GetBlackBoardies()
        {
            return BlackBoards;
        }

        public bool UpdateBlackBoard(BlackBoard ablackboard)
        {
            foreach (var blackboard in BlackBoards)
            {
                if (blackboard.BlackBoardId == ablackboard.BlackBoardId)
                {
                    blackboard.Color=ablackboard.Color;
                    blackboard.Weight=ablackboard.Weight;
                    blackboard.Widht=ablackboard.Widht; 
                    blackboard.Height=ablackboard.Height;
                    blackboard.Type=ablackboard.Type;
                    blackboard.Price=ablackboard.Price;
                    return true;

                }

            }
            return false;


        }
    }
}
