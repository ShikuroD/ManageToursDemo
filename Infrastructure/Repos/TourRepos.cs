using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repos
{
    public partial class TourRepos : Repository<Tour>, ITourRepos
    {
        private readonly ManageToursContext _context;
        public TourRepos(ManageToursContext context) : base(context)
        {
            _context = context;
        }

        public new IList<Tour> GetAllByStatus(STATUS status = STATUS.ALL)
        {
            if (status == STATUS.ALL) return this.GetAll();
            else
            {
                return _context.Tours.Where(m => m.Status == status).ToList();
            }
        }
        public new void Activate(Tour entity)
        {
            this.UpdateStatus(entity, STATUS.AVAILABLE);
        }

        public new void Disable(Tour entity)
        {
            this.UpdateStatus(entity, STATUS.DISABLED);
        }

        private void UpdateStatus(Tour entity, STATUS status)
        {
            entity.Status = status;
            this.Update(entity);
        }

        //manage tour details
        public IList<TourDetail> GetTourDetailsByTourId(int tourId)
        {
            return _context.TourDetails.Where(m => m.TourId.Equals(tourId)).OrderBy(m => m.Order).ToList();
        }

        public void UpdateTourDetails(IList<TourDetail> dets)
        {
            if (dets == null || !dets.Any())
            {
                return;
            }
            var tourId = dets.First().TourId;
            this.RemoveAllTourDetails(tourId);
            _context.TourDetails.AddRange(dets);
            _context.SaveChanges();
        }

        public void RemoveAllTourDetails(int tourId)
        {
            _context.TourDetails.RemoveRange((this.GetTourDetailsByTourId(tourId)));
            _context.SaveChanges();
        }


        //-------------------------------------------------------------------------------------------------------------------------------
        //manage prices
        public IList<Price> GetAllPrices()
        {

            return _context.Prices.ToList();
        }
        public IList<Price> GetPricesByTourId(int tourId, STATUS status = STATUS.ALL)
        {

            var res = _context.Prices.Where(m => m.TourId.Equals(tourId)).ToList();
            if (status == STATUS.ALL) return res;
            else
            {
                return res.Where(m => m.Status.Equals(status)).ToList();
            }
        }
        public Price GetPrice(int tourId, int priceId)
        {
            var prices = _context.Prices.Where(m => m.Id.Equals(priceId) && m.TourId.Equals(tourId)).ToList();
            if (prices == null || !prices.Any())
            {
                return null;
            }
            return prices.First();
        }
        public Price AddPrice(int tourId, Price price)
        {
            if((this.Exists(tourId)) && tourId.Equals(price.TourId)){
                var tracked = _context.Prices.Add(price);
                _context.SaveChanges();
                return tracked.Entity;
            }
            return null;

        }
        public void UpdatePrice(int tourId, Price price)
        {
            if ((this.Exists(tourId)) && price != null && tourId.Equals(price.TourId))
            {
                _context.Prices.Update(price);
                _context.SaveChanges();
            }
        }
        public void DeletePrice(int tourId, Price price)
        {
            if ((this.Exists(tourId)) && price != null && tourId.Equals(price.TourId))
            {
                _context.Prices.Remove(price);
                _context.SaveChanges();
            }
        }
        public void DisablePrice(int tourId, int priceId)
        {
            var price = this.GetPrice(tourId, priceId);
            if(price != null)
            {
                this.UpdatePriceStatus(price, STATUS.DISABLED);
            }

        }
        public void ActivatePrice(int tourId, int priceId)
        {
            var price = this.GetPrice(tourId, priceId);
            if (price != null)
            {
                this.UpdatePriceStatus(price, STATUS.AVAILABLE);
            }

        }
        private void UpdatePriceStatus(Price price, STATUS status)
        {
            price.Status = status;
            _context.Prices.Update(price);
            _context.SaveChanges();
        }




        //manage groups
        public IList<Group> GetAllGroups()
        {
            return _context.Groups.ToList();
        }
        public IList<Group> GetGroupsByTourId(int tourId, STATUS status = STATUS.ALL)
        {
            var tour = this.GetBy(tourId);
            var groups = _context.Groups.Where(m => m.TourId.Equals(tour.Id)).ToList();
            return groups;
        }

        public Group GetGroup(int tourId, int groupId)
        {
            var groups = this.GetGroupsByTourId(tourId);
            if (groups == null || !groups.Any())
            {
                return null;
            }
            return groups.Where(m => m.Id.Equals(groupId)).FirstOrDefault();

        }
        public Group AddGroup(int tourId, Group group)
        {
            if (this.Exists(tourId) && group.TourId.Equals(tourId))
            {
                var tracked = _context.Set<Group>().Add(group);
                _context.SaveChanges();
                return tracked.Entity;
            }
            return null;
        }
        public void DeleteGroup(Group group)
        {
            _context.Set<Group>().Remove(group);
            _context.SaveChanges();
        }
        public void UpdateGroup(Group group)
        {
            _context.Set<Group>().Update(group);
            _context.SaveChanges();
        }
        public void DisableGroup(int tourId, int groupId)
        {
            var group = this.GetGroup(tourId, groupId);
            if (group != null)
            {
                this.UpdateGroupStatus(group, STATUS.DISABLED);
            }
        }
        public void ActivateGroup(int tourId, int groupId)
        {
            var group = this.GetGroup(tourId, groupId);
            if (group != null)
            {
                this.UpdateGroupStatus(group, STATUS.AVAILABLE);
            }
        }

        private void UpdateGroupStatus(Group group, STATUS status)
        {
            group.Status = status;
            _context.Groups.Update(group);
            _context.SaveChanges();
        }

    }
}
