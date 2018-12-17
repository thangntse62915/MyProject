using DAOLibrary;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Session
{
    public class CurrentSession
    {
        private static Employee loginInfo;
        private static object data;
        private static Dictionary<string, Form> formDictionary;
        static CurrentSession()
        {
            loginInfo = new Employee();
            formDictionary = new Dictionary<string, Form>();
        }

        public Employee LoginInfo { get => loginInfo; set => loginInfo = value; }
        public object Data { get => data; set => data = value; }
        public Dictionary<string, Form> FormDictionary { get => formDictionary; set => formDictionary = value; }

        public CurrentSession()
        {
        }

        public CurrentSession(Employee loginInfo, object data, Dictionary<string, Form> formDictionary)
        {
            LoginInfo = loginInfo;
            Data = data;
            FormDictionary = formDictionary;
        }
        public void InitSession()
        {
            loginInfo = new Employee();
            formDictionary = new Dictionary<string, Form>();
        }
        public void ClearSession()
        {
            loginInfo = null;
            data = null;
            formDictionary = null;
        }
       
    }
}
