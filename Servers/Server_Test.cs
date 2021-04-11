using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Servers
{
    public class Server_Test
    {
        /// <summary>
        /// 获取测试数据
        /// </summary>
        /// <returns></returns>
        public static List<Model_Test> GetData()
        {
            List<Model_Test> list = new List<Model_Test>();
            string[] name = { "张三", "李四", "王五", "赵六" };
            for (int i = 0; i < 4; i++)
            {
                Model_Test model = new Model_Test() { CreateTime = name[i], Salary = i * 10 + 100 };
                list.Add(model);
            }
            return list;
        }
    }
}
