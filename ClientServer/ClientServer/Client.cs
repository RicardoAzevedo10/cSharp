using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteNetLib;// Using a library "LiteNetLib"

namespace ClientServer
{//Create a server using LitenetLib
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
