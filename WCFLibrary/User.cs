using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLibrary
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“User”。
    public class User : IUser
    {
        public string ShowName(string name)
        {
            return String.Format("这是WCF服务库返回的值：{0}", name);
        }
    }
}
