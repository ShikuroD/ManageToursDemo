using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Models
{
    public class GroupDetail
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public GroupDetail()
        {
        }

        public GroupDetail(int groupId, int customerId)
        {
            GroupId = groupId;
            CustomerId = customerId;
        }
        public GroupDetail(GroupDetail groupDetail)
        {
            this.Copy(groupDetail);
        }
        public void Copy(GroupDetail a)
        {
            GroupId = a.GroupId;
            CustomerId = a.CustomerId;
        }
    }
}
