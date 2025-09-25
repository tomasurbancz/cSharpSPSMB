using OopExamples.Interfaces.Types;

namespace OopExamples.Interfaces;

public interface IMonitor : IComponent
{
    GPUConnector Connector { get; }
}