﻿namespace Flowers_Riven.MyBase
{
    #region 

    using Flowers_Riven.MyCommon;

    using System;

    #endregion

    internal class MyChampions
    {
        public MyChampions()
        {
            try
            {
                Initializer();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MyChampions." + ex);
            }
        }

        internal void Initializer()
        {
            try
            {
                MySpellManager.Initializer();
                MyMenuManager.Initializer();
                MyEventManager.Initializer();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MyChampions.Initializer" + ex);
            }
        }
    }
}
