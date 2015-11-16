using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageRouting.Shared.Model;

namespace MessageRouting.Shared.Service
{
    public interface ISignalrPublisher
    {
        void Publish(Message msg);
        event EventHandler<string> StatusChanged;
    }
}
