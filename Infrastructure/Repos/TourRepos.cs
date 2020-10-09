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
    public class TourRepos : Repository<Tour>, ITourRepos
    {
        private readonly ManageToursContext _context;
        public TourRepos(ManageToursContext context) : base(context)
        {
            _context = context;
        }

        //manage tour details
        public IList<TourDetail> GetTourDetailsByTourId(int tourId)
        {
            return _context.TourDetails.Where(m => m.TourId.Equals(tourId)).OrderBy(m => m.Order).ToList();
        }

        public void UpdateTourDetails(IList<TourDetail> dets)
        {
            if(dets == null || dets.Count == 0)
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


        //manage prices
        public IList<Price> GetPricesByTourId(int tourId)
        {
            return _context.Prices.Where(m => m.TourId.Equals(tourId)).ToList();
        }
        public Price GetPrice(int tourId, int priceId)
        {
            var prices = _context.Prices.Where(m => m.Id.Equals(priceId) && m.TourId.Equals(tourId)).ToList();
            if (prices != null && prices.Count() != 0)
            {
                return prices.First();
            }
            return null;
        }
        public Price AddPrice(int tourId, Price price)
        {
            if((this.TourExists(tourId)) && tourId.Equals(price.TourId)){
                var tracked = _context.Prices.Add(price);
                _context.SaveChanges();
                return tracked.Entity;
            }
            return null;

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




        //status
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
        public bool TourExists(int tourId)
        {
            return (this.GetBy(tourId)) != null;
        }
    }
}
