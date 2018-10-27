using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NLog.Config;

namespace NLog.LayoutRenderers
{
    /// <summary>
    /// https://nlog-project.org/2015/06/30/extending-nlog-is-easy.html
    /// </summary>
    [LayoutRenderer("IP")]

    public class IPLayoutRenderer : LayoutRenderer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateLayoutRenderer" /> class.
        /// </summary>
        public IPLayoutRenderer()
        {
            ipv4 = true;
        }
        /// <summary>
        /// 
        /// </summary>
        [RequiredParameter]
        public bool ipv4 { get; set; }
        /// <summary>
        /// Renders the current date and appends it to the specified <see cref="StringBuilder" />.
        /// </summary>
        /// <param name="builder">The <see cref="StringBuilder"/> to append the rendered data to.</param>
        /// <param name="logEvent">Logging event.</param>
        protected override void Append(StringBuilder builder, NLog.LogEventInfo logEvent)
        {
            string hostName = Dns.GetHostName();   //获取本机名
            IPHostEntry localhost= Dns.GetHostEntry(hostName);   //获取IPv6地址
            foreach (var item in localhost.AddressList)
            {
                if (ipv4 == false)
                {
                    if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                    {
                        builder.Append(item.ToString());
                       // break;
                    }
                }
                else {
                    if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        builder.Append(item.ToString());
                      //  break;
                    }

                }
            }
        }
    }
}
