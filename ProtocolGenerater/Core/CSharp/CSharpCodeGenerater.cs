﻿/************************************************************************ 
 * 项目名称 :  ProtocolGenerater.CSharp       
 * 类 名 称 :  CSharpCodeGenerater 
 * 类 描 述 : 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  FReedom 
 * 创建时间 :  2018/4/20 星期五 17:37:31 
 * 更新时间 :  2018/4/20 星期五 17:37:31 
************************************************************************ 
 * Copyright @ BoilingBlood 2018. All rights reserved. 
************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolGenerater.CSharp
{
    public class CSharpCodeGenerater : ICodeGenerater
    {
        string spaceStr = "     ";
        private string SetSpace(int spaceCount)
        {
            StringBuilder space = new StringBuilder();
            for (int i = 0; i < spaceCount; i++)
            {
                space.Append(spaceStr);
            }
            return space.ToString();
        }
        /// <summary>
        /// 文件开头说明文字框架
        /// </summary>
        /// <returns></returns>
        public StringBuilder ClassCommentsFrame()
        {
            //------------------------------------------------------------------------------
            // <auto-generated>
            //     This code was generated by a tool.(The author is Boiling)
            //     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.  
            // </auto-generated>
            //------------------------------------------------------------------------------

            StringBuilder sb = new StringBuilder();
            sb.Append(" //------------------------------------------------------------------------------");
            sb.Append(Environment.NewLine);
            sb.Append(" // <auto-generated>");
            sb.Append(Environment.NewLine);
            sb.Append(" //     This code was generated by a tool.(The author is Boiling)");
            sb.Append(Environment.NewLine);
            sb.Append(" //     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.");
            sb.Append(Environment.NewLine);
            sb.Append(" // </auto-generated>");
            sb.Append(Environment.NewLine);
            sb.Append(" //------------------------------------------------------------------------------");
            sb.Append(Environment.NewLine);
            return sb;
        }
        /// <summary>
        /// using框架
        /// </summary>
        /// <returns></returns>
        public StringBuilder IncludeHeadFrame()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("using System.IO;");
            //sb.Append(Environment.NewLine);
            //sb.Append("using Protocol.Client.C2G;");
            //sb.Append(Environment.NewLine);
            //sb.Append("using Protocol.Gate.G2C;");
            //sb.Append(Environment.NewLine);
            //sb.Append("using Engine.Foundation;");
            //sb.Append(Environment.NewLine);
            //sb.Append("using GenerateCodeLib;");
            //sb.Append(Environment.NewLine);
            //sb.Append("using CryptoLib;");
            //sb.Append(Environment.NewLine);
            return sb;
        }
        /// <summary>
        /// namespace框架
        /// </summary>
        /// <param name="nameSpace"></param>
        /// <param name="classBody"></param>
        /// <returns></returns>
        public StringBuilder NameSpaceFrame(string nameSpace, StringBuilder classBody)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("namespace ");
            sb.Append(nameSpace);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append(classBody.ToString());
            sb.Append(Environment.NewLine);
            sb.Append("}");
            return sb;
        }
        /// <summary>
        /// 类框架
        /// </summary>
        /// <param name="className"></param>
        /// <param name="attrs"></param>
        /// <param name="methods"></param>
        /// <param name="spaceCount"></param>
        /// <returns></returns>
        public StringBuilder ClassFrame(string className, List<StringBuilder> attrs = null, List<StringBuilder> methods = null, int spaceCount = 1)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(SetSpace(spaceCount));
            sb.Append("public ");
            sb.Append(className);
            sb.Append(Environment.NewLine);
            sb.Append(SetSpace(spaceCount));
            sb.Append("{");
            sb.Append(Environment.NewLine);
            if (attrs != null)
            {
                foreach (var item in attrs)
                {
                    sb.Append(item.ToString());
                }
            }
            if (methods != null)
            {
                foreach (var item in methods)
                {
                    sb.Append(item.ToString());
                }
            }
            sb.Append(SetSpace(spaceCount));
            sb.Append("}");
            return sb;
        }
        /// <summary>
        /// 变量框架
        /// </summary>
        /// <param name="attrType"></param>
        /// <param name="attrName"></param>
        /// <param name="spaceCount"></param>
        /// <returns></returns>
        public StringBuilder AttrFrame(string attrType, string attrName, int spaceCount = 2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(SetSpace(spaceCount));
            sb.Append(attrType);
            sb.Append(" ");
            sb.Append(attrName);
            sb.Append(";");
            sb.Append(Environment.NewLine);
            return sb;
        }
        /// <summary>
        /// 函数框架
        /// </summary>
        /// <param name="methodType"></param>
        /// <param name="methodName"></param>
        /// <param name="methodValue"></param>
        /// <param name="spaceCount"></param>
        /// <returns></returns>
        public StringBuilder MethodFrame(string methodType, string methodName, List<StringBuilder> methodValue, int spaceCount = 2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(SetSpace(spaceCount));
            sb.Append("public ");
            sb.Append(methodType);
            sb.Append(" ");
            sb.Append(methodName);
            sb.Append(Environment.NewLine);
            sb.Append(SetSpace(spaceCount));
            sb.Append("{");
            sb.Append(Environment.NewLine);
            foreach (var item in methodValue)
            {
                sb.Append(SetSpace(1));
                sb.Append(item.ToString());
            }
            sb.Append(SetSpace(spaceCount));
            sb.Append("}");
            sb.Append(Environment.NewLine);
            return sb;
        }
    }
}
