/************************************************************************************* 
**文 件 名：ZipHelper 
**创建时间：2017/8/29 星期二 上午 11:48:55 
**作    者：罗弘(email： 243515320@qq.com)
**工    号：102193
**说    明： 
**版    本：V1.0.0  
**修改时间： 
**修 改 人： 
 *************************************************************************************/
using Code.Core;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using WorthGod;
using Xxtea;

public class ZipHelper : Singleton<EncryptionHelper>
{
    /// <summary>
    /// 压缩加密处理
    /// </summary>
    /// <param name="inputPath">未加密文件path</param>
    /// <param name="outputPath">加密和压缩后的path</param>
	public void CompressAndEncrypt(string inputPath, string outputPath)
    {
        using (MemoryStream inputStream = new MemoryStream(File.ReadAllBytes(inputPath)))
        {
            SevenZip.Compression.LZMA.Encoder encoder = new SevenZip.Compression.LZMA.Encoder();
            using (MemoryStream compressStream = new MemoryStream())
            {
                encoder.WriteCoderProperties(compressStream);
                compressStream.Write(BitConverter.GetBytes(inputStream.Length), 0, 8);
                encoder.Code(inputStream, compressStream, inputStream.Length, -1, null);
                if (string.IsNullOrEmpty(AppConst.PwKey))
                    File.WriteAllBytes(outputPath, compressStream.ToArray());
                else
                    File.WriteAllBytes(outputPath, XXTEA.Encrypt(compressStream.ToArray(), AppConst.PwKey));
            }
        }
    }

    /// <summary>
    /// 解压缩数据。
    /// </summary>
    /// <param name="bytes">要解压缩的数据。</param>
    /// <returns>解压缩后的数据。</returns>
    public byte[] Decompress(byte[] bytes)
    {

        return null;
    }
}
