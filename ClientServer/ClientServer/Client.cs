using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteNetLib;

namespace ClientServer
{
    public class Client
    {
        NetManager netmanager;
        EventBasedNetListener netListener;


        void start()
        {
            netListener = new EventBasedNetListener();
            netListener.PeerConnectedEvent += (server) =>
            {
                Debug.log();
            }
        }

        void update()
        {

        }

    }
}
