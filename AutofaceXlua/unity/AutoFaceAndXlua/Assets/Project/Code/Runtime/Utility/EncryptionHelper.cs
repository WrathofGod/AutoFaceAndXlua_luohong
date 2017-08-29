/************************************************************************************* 
**文 件 名：EncryptionHelper 
**创建时间：2017/8/29 星期二 上午 11:21:20 
**作    者：罗弘(email： 243515320@qq.com)
**工    号：102193
**说    明： 
**版    本：V1.0.0  
**修改时间： 
**修 改 人： 
 *************************************************************************************/
using System;
using System.Collections.Generic;
using Code.Core;
using UnityEngine;
using Xxtea;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class EncryptionHelper:Singleton<EncryptionHelper>
{
    /// <summary>
    /// 加密
    /// </summary>
    /// <param name="data"></param>
    /// <param name="key"></param>
    /// <returns></returns>
   public Byte[] Encrypt(Byte[] data, String key)
   {
       return XXTEA.Encrypt(data, key);
   }

    /// <summary>
    /// 解密
    /// </summary>
    /// <param name="data"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public Byte[] Decrypt(Byte[] data, String key)
    {
        return XXTEA.Encrypt(data, key);
    }

}
