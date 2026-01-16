using Dars5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars5.Services;

public interface IBlackBoardServices
{
    public Guid AddBlackBoard(BlackBoard  blackboard);
    public bool UpdateBlackBoard(BlackBoard blackboard);
    public bool DeleteBlackBoard(Guid blackboardId);
    public BlackBoard? GetBlackBoardByID(Guid blackboardId);
    public List<BlackBoard> GetBlackBoardies();
    BlackBoard? GetBalckBoardById(Guid blackboardId);
}
