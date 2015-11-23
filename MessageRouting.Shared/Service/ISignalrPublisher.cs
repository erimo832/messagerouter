using MessageRouting.Shared.Model;
using System;

namespace MessageRouting.Shared.Service
{
    public interface ISignalrPublisher
    {
        void Publish(Message msg);
        event EventHandler<string> StatusChanged;
    }
}
