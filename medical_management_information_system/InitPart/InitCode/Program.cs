using medical_management_information_system.ServicePart.ManagementPart.ManagementForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace medical_management_information_system
{
    
    static class Program
    {
        static public User user = new User();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //如果没登录就退出
            if (Program.user.getAccount()!=null)
            {
                //如果没有绑定就绑定
                if (Program.user.getStaffId()==-1)
                {
                    Application.Run(new BindForm());
                }
                //如果绑定成功就进入
                if (Program.user.getStaffId()!=-1)
                {
                    Application.Run(new ManagementForm());
                }
            }
            
             
        }
        
    }
}
