using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAMS_WebSys.Models
{
    public class MemberStorage
    {
        private List<MemberModel> members;
        public MemberStorage()
        {
            members = new List<MemberModel>();
        }
        public void SetMember(MemberModel member)
        {
            members.Add(member);
        }

        public List<MemberModel> GetMembers()
        {
            return members;
        }
    }
}
