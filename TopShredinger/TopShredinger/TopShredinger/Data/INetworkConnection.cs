using System;
using System.Collections.Generic;
using System.Text;

namespace TopShredinger.Data
{
    public interface INetworkConnection
    {
        bool IsConnected { get; set; }
        void CheckNetworkConnection();
    }
}
