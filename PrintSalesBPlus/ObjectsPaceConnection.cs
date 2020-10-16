using DevExpress.ExpressApp;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSalesBPlus
{
    class ObjectsPaceConnection
    {

        private static IObjectSpace propObjectSpace;

        public static IObjectSpace PropObjectSpace
        {
            get { return propObjectSpace; }
            set { propObjectSpace = value; }
        }

        private static Session session;
        public static Session Session
        {
            get
            {

                if (session == null)
                    session = new Session();
                return session;
            }

            set
            {
                session = value;
            }

        }


    }
}