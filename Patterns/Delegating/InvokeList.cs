using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvellousWorks.PracticalPattern.Concept.Delegating
{
    public delegate void StringAssignmentEventHandler();  // 抽象的操作方法
    public class InvokeList
    {
        private IList<StringAssignmentEventHandler> handlers;
        private string[] message = new string[3];
        public InvokeList()
        {
            // 绑定一组抽象方法
            handlers = new List<StringAssignmentEventHandler>();
            handlers.Add(AppendHello);
            handlers.Add(AppendComma);
            handlers.Add(AppendWorld);
        }
        public void Invoke()
        {
            foreach (StringAssignmentEventHandler handler in handlers)
                handler();
        }
        public string this[int index] { get { return message[index]; } }

        private void AppendWorld()
        {
            message[0] = "hello";
        }

        private void AppendComma()
        {
            message[1] = ", ";
        }

        private void AppendHello()
        {
            message[2] = "world";
        }
    }
}
