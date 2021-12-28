using PiskaBobra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiskaBobra
{                           
    public class MeetManager       
    {                       
        private List<Meet> meets = new List<Meet>();

        public List<Meet> GetAll()
        {
            return meets;
        }
        public void AddNewMeet(string name, DateTime meetTime)
        {
            Meet newMeet = new Meet() { Name = name, CreateTime = DateTime.Now, MeetTime = meetTime };
            meets.Add(newMeet);    
        }
    }
}
