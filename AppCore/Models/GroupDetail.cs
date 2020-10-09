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

        public GroupDetail(int groupId, Group group, int customerId, Customer customer)
        {
            GroupId = groupId;
            Group = group;
            CustomerId = customerId;
            Customer = customer;
        }
    }
}
