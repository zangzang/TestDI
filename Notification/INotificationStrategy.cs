using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDI.Notification
{
    public interface INotificationStrategy
    {
        string Key { get; }   // 전략을 식별하는 문자열 키 
        void Send(string message);
    }

}