﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Xfrog.Net;
using System.Diagnostics;
using System.Web;

//----------------------------------
// 净值数据调用示例代码 － 聚合数据
// 在线接口文档：http://www.juhe.cn/docs/25
// 代码中JsonObject类下载地址:http://download.csdn.net/download/gcm3206021155665/7458439
//----------------------------------

namespace JJDataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string appkey = "*******************"; //配置您申请的appkey


            //1.全部开放基金
            string url1 = "http://web.juhe.cn:8080/fund/netdata/all";

            var parameters1 = new Dictionary<string, string>();

            parameters1.Add("key", appkey);//你申请的key

            string result1 = sendPost(url1, parameters1, "get");

            JsonObject newObj1 = new JsonObject(result1);
            String errorCode1 = newObj1["error_code"].Value;

            if (errorCode1 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj1);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj1["error_code"].Value + ":" + newObj1["reason"].Value);
            }


            //2.股票型基金
            string url2 = "http://web.juhe.cn:8080/fund/netdata/stock";

            var parameters2 = new Dictionary<string, string>();

            parameters2.Add("key", appkey);//你申请的key

            string result2 = sendPost(url2, parameters2, "get");

            JsonObject newObj2 = new JsonObject(result2);
            String errorCode2 = newObj2["error_code"].Value;

            if (errorCode2 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj2);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj2["error_code"].Value + ":" + newObj2["reason"].Value);
            }


            //3.普通债券型基金
            string url3 = "http://web.juhe.cn:8080/fund/netdata/bond";

            var parameters3 = new Dictionary<string, string>();

            parameters3.Add("key", appkey);//你申请的key

            string result3 = sendPost(url3, parameters3, "get");

            JsonObject newObj3 = new JsonObject(result3);
            String errorCode3 = newObj3["error_code"].Value;

            if (errorCode3 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj3);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj3["error_code"].Value + ":" + newObj3["reason"].Value);
            }


            //4.货币型基金
            string url4 = "http://web.juhe.cn:8080/fund/netdata/monet";

            var parameters4 = new Dictionary<string, string>();

            parameters4.Add("key", appkey);//你申请的key

            string result4 = sendPost(url4, parameters4, "get");

            JsonObject newObj4 = new JsonObject(result4);
            String errorCode4 = newObj4["error_code"].Value;

            if (errorCode4 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj4);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj4["error_code"].Value + ":" + newObj4["reason"].Value);
            }


            //5.封闭型基金
            string url5 = "http://web.juhe.cn:8080/fund/netdata/close";

            var parameters5 = new Dictionary<string, string>();

            parameters5.Add("key", appkey);//你申请的key

            string result5 = sendPost(url5, parameters5, "get");

            JsonObject newObj5 = new JsonObject(result5);
            String errorCode5 = newObj5["error_code"].Value;

            if (errorCode5 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj5);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj5["error_code"].Value + ":" + newObj5["reason"].Value);
            }


            //6.创新封基
            string url6 = "http://web.juhe.cn:8080/fund/netdata/innov";

            var parameters6 = new Dictionary<string, string>();

            parameters6.Add("key", appkey);//你申请的key

            string result6 = sendPost(url6, parameters6, "get");

            JsonObject newObj6 = new JsonObject(result6);
            String errorCode6 = newObj6["error_code"].Value;

            if (errorCode6 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj6);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj6["error_code"].Value + ":" + newObj6["reason"].Value);
            }


            //7.LOF
            string url7 = "http://web.juhe.cn:8080/fund/netdata/lof";

            var parameters7 = new Dictionary<string, string>();

            parameters7.Add("key", appkey);//你申请的key

            string result7 = sendPost(url7, parameters7, "get");

            JsonObject newObj7 = new JsonObject(result7);
            String errorCode7 = newObj7["error_code"].Value;

            if (errorCode7 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj7);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj7["error_code"].Value + ":" + newObj7["reason"].Value);
            }


            //8.ETF
            string url8 = "http://web.juhe.cn:8080/fund/netdata/etf";

            var parameters8 = new Dictionary<string, string>();

            parameters8.Add("key", appkey);//你申请的key

            string result8 = sendPost(url8, parameters8, "get");

            JsonObject newObj8 = new JsonObject(result8);
            String errorCode8 = newObj8["error_code"].Value;

            if (errorCode8 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj8);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj8["error_code"].Value + ":" + newObj8["reason"].Value);
            }


            //9.QDII
            string url9 = "http://web.juhe.cn:8080/fund/netdata/qdii";

            var parameters9 = new Dictionary<string, string>();

            parameters9.Add("key", appkey);//你申请的key

            string result9 = sendPost(url9, parameters9, "get");

            JsonObject newObj9 = new JsonObject(result9);
            String errorCode9 = newObj9["error_code"].Value;

            if (errorCode9 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj9);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj9["error_code"].Value + ":" + newObj9["reason"].Value);
            }


        }

        /// <summary>
                /// Http (GET/POST)
                /// </summary>
                /// <param name="url">请求URL</param>
                /// <param name="parameters">请求参数</param>
                /// <param name="method">请求方法</param>
                /// <returns>响应内容</returns>
        static string sendPost(string url, IDictionary<string, string> parameters, string method)
        {
            if (method.ToLower() == "post")
            {
                HttpWebRequest req = null;
                HttpWebResponse rsp = null;
                System.IO.Stream reqStream = null;
                try
                {
                    req = (HttpWebRequest)WebRequest.Create(url);
                    req.Method = method;
                    req.KeepAlive = false;
                    req.ProtocolVersion = HttpVersion.Version10;
                    req.Timeout = 5000;
                    req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                    byte[] postData = Encoding.UTF8.GetBytes(BuildQuery(parameters, "utf8"));
                    reqStream = req.GetRequestStream();
                    reqStream.Write(postData, 0, postData.Length);
                    rsp = (HttpWebResponse)req.GetResponse();
                    Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
                    return GetResponseAsString(rsp, encoding);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    if (reqStream != null) reqStream.Close();
                    if (rsp != null) rsp.Close();
                }
            }
            else
            {
                //创建请求
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "?" + BuildQuery(parameters, "utf8"));

                //GET请求
                request.Method = "GET";
                request.ReadWriteTimeout = 5000;
                request.ContentType = "text/html;charset=UTF-8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

                //返回内容
                string retString = myStreamReader.ReadToEnd();
                return retString;
            }
        }

        /// <summary>
                /// 组装普通文本请求参数。
                /// </summary>
                /// <param name="parameters">Key-Value形式请求参数字典</param>
                /// <returns>URL编码后的请求数据</returns>
        static string BuildQuery(IDictionary<string, string> parameters, string encode)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;
            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name))//&& !string.IsNullOrEmpty(value)
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }
                    postData.Append(name);
                    postData.Append("=");
                    if (encode == "gb2312")
                    {
                        postData.Append(HttpUtility.UrlEncode(value, Encoding.GetEncoding("gb2312")));
                    }
                    else if (encode == "utf8")
                    {
                        postData.Append(HttpUtility.UrlEncode(value, Encoding.UTF8));
                    }
                    else
                    {
                        postData.Append(value);
                    }
                    hasParam = true;
                }
            }
            return postData.ToString();
        }

        /// <summary>
                /// 把响应流转换为文本。
                /// </summary>
                /// <param name="rsp">响应流对象</param>
                /// <param name="encoding">编码方式</param>
                /// <returns>响应文本</returns>
        static string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            System.IO.Stream stream = null;
            StreamReader reader = null;
            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }
    }
}