using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<IList<TourDetail>> GetTourDetailsByTourId(int tourId)
        {
            return await _context.TourDetails.Where(m => m.TourId.Equals(tourId)).OrderBy(m => m.Order).ToListAsync();
        }

        public async Task UpdateTourDetails(IList<TourDetail> dets)
        {
            if(dets == null || dets.Count == 0)
            {
                return;
            }
            var tourId = dets.First().TourId;
            await this.RemoveAllTourDetails(tourId);
            await _context.TourDetails.AddRangeAsync(dets);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAllTourDetails(int tourId)
        {
            _context.TourDetails.RemoveRange((await this.GetTourDetailsByTourId(tourId)));
            await _context.SaveChangesAsync();
        }


        //manage prices
        public async Task<IList<Price>> GetPricesByTourId(int tourId)
        {
            return await _context.Prices.Where(m => m.TourId.Equals(tourId)).ToListAsync();
        }
        public async Task<Price> GetPrice(int tourId, int priceId)
        {
            var prices = await _context.Prices.Where(m => m.Id.Equals(priceId) && m.TourId.Equals(tourId)).ToListAsync();
            if (prices != null && prices.Count() != 0)
            {
                return prices.First();
            }
            return null;
        }
        public async Task<Price> AddPrice(int tourId, Price price)
        {
            if((await this.TourExists(tourId)) && tourId.Equals(price.TourId)){
                var tracked = await _context.Prices.AddAsync(price);
                await _context.SaveChangesAsync();
                return tracked.Entity;
            }
            return null;

        }
        public async Task DisablePrice(int tourId, int priceId)
        {
            var price = await this.GetPrice(tourId, priceId);
            if(price != null)
            {
                await this.UpdatePriceStatus(price, STATUS.DISABLED);
            }

        }
        public async Task ActivatePrice(int tourId, int priceId)
        {
            var price = await this.GetPrice(tourId, priceId);
            if (price != null)
            {
                await this.UpdatePriceStatus(price, STATUS.AVAILABLE);
            }

        }
        private async Task UpdatePriceStatus(Price price, STATUS status)
        {
            price.Status = status;
            _context.Prices.Update(price);
            await _context.SaveChangesAsync();
        }




        //status
        public new async Task Activate(Tour entity)
        {
            await this.UpdateStatus(entity, STATUS.AVAILABLE); 
        }

        public new async Task Disable(Tour entity)
        {
            await this.UpdateStatus(entity, STATUS.DISABLED);
        }

        private async Task UpdateStatus(Tour entity, STATUS status)
        {
            entity.Status = status;
            await this.Update(entity);
        }
        public async Task<bool> TourExists(int tourId)
        {
            return (await this.GetBy(tourId)) != null;
        }
    }
}
