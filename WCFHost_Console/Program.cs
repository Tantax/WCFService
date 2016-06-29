using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCFLibrary;

namespace WCFHost_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建宿主的基地址
            Uri baseAddress = new Uri("http://localhost:8080/User");
            //创建宿主
            using (ServiceHost host = new ServiceHost(typeof(User), baseAddress))
            {
                //向宿主中添加终结点
                host.AddServiceEndpoint(typeof(IUser), new WSHttpBinding(), "");
                //将HttpGetEnabled属性设置为true
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                //将行为添加到Behaviors中
                host.Description.Behaviors.Add(smb);
                //打开宿主
                host.Open();
                Console.WriteLine("WCF中的HTTP监听已启动....");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
