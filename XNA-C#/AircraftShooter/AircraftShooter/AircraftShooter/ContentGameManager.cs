using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AircraftShooter
{
    class ContentGameManager
    {
        private static ContentGameManager instance;

        private ContentGameManager()
        {
        }

        public static ContentGameManager GetInstance
        { 
            get 
            {
                if (instance == null)
                {
                    instance = new ContentGameManager();
                }
                return instance;
            }
        }
    }
}
