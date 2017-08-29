/************************************************************************************* 
**文 件 名：ILuaInjection 
**创建时间：2017/8/28 星期一 下午 6:02:48 
**作    者：
**工    号：
**说    明： 
**版    本：V1.0.0  
**修改时间： 
**修 改 人： 
 *************************************************************************************/
using System;
using System.Collections.Generic;

namespace XluaHotUpdate
{
    public interface ILuaInjection
    {
        string LuaPath { get; set; }

        void InitLoadLua();
    }
}