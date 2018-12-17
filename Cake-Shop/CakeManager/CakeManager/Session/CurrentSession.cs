using DTOLibrary;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Session
{
    public class CurrentSession
    {
        private static AdminDTO loginInfo;
        private static object data;
        private static Dictionary<string, Form> formCollection;

        public AdminDTO LoginInfo { get => loginInfo; set => loginInfo = value; }
        public object Data { get => data; set => data = value; }
        public Dictionary<string, Form> FormCollection { get => formCollection; set => formCollection = value; }

        public CurrentSession()
        {
        }

        public CurrentSession(AdminDTO loginInfo, object data, Dictionary<string, Form> formCollection)
        {
            LoginInfo = loginInfo;
            Data = data;
            FormCollection = formCollection;
        }

        public void ClearSession()
        {
            loginInfo = null;
            data = null;
            formCollection = null;
        }

    }
}
