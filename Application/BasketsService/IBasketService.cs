﻿using Application.Catalogs.CatalogItems.UriComposer;
using Application.Interfaces.Contexts;
using Domain.Baskets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BasketsService
{
    public interface IBasketService
    {
        BasketDto GetOrCreateBasketForUser(string BuyerId);
        void AddItemToBasket(int basketId, int catalogItemId, int quantity = 1);
        bool RemoveItemFromBasket(int ItemId);
        bool SetQuantities(int itemId, int quantity);
        BasketDto GetBasketForUser(string UserId);

        void TransferBasket(string anonymousId, string UserId);

    }
    public class BasketService : IBasketService
    {
        private readonly IDataBaseContext context;
        private readonly IUriComposerService uriComposerService;

        public BasketService(IDataBaseContext context
            , IUriComposerService uriComposerService)
        {
            this.context = context;
            this.uriComposerService = uriComposerService;
        }

        public void AddItemToBasket(int basketId, int catalogItemId, int quantity = 1)
        {
            var basket = context.Baskets.FirstOrDefault(p => p.Id == basketId);
            if (basket == null)
                throw new Exception("");

            var catalog = context.CatalogItems.Find(catalogItemId);
            basket.AddItem(catalogItemId, quantity, catalog.Price);

            context.SaveChanges();
        }

        public BasketDto GetBasketForUser(string UserId)
        {
            var basket = context.Baskets
              .Include(p => p.Items)
              .ThenInclude(p => p.CatalogItem)
              .ThenInclude(p => p.CatalogItemImages)
              .SingleOrDefault(p => p.BuyerId == UserId);
            if (basket == null)
            {
                return null;
            }
            return new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                DiscountAmount=basket.DiscountAmount,
                Items = basket.Items.Select(item => new BasketItemDto
                {
                    CatalogItemid = item.CatalogItemId,
                    Id = item.Id,
                    CatalogName = item.CatalogItem.Name,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    ImageUrl = uriComposerService.ComposeImageUri(item?.CatalogItem?
                     .CatalogItemImages?.FirstOrDefault()?.Src ?? ""),

                }).ToList(),
            };
        }

        public BasketDto GetOrCreateBasketForUser(string BuyerId)
        {
            var basket = context.Baskets
                .Include(p => p.Items)
                .ThenInclude(p => p.CatalogItem)
                .ThenInclude(p => p.CatalogItemImages)

                .Include(p => p.Items)
                .ThenInclude(p => p.CatalogItem)
                .ThenInclude(p => p.Discounts)


                .SingleOrDefault(p => p.BuyerId == BuyerId);
            if (basket == null)
            {
                return CreateBasketForUser(BuyerId);
            }
            return new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                DiscountAmount = basket.DiscountAmount,
                Items = basket.Items.Select(item => new BasketItemDto
                {
                    CatalogItemid = item.CatalogItemId,
                    Id = item.Id,
                    CatalogName = item.CatalogItem.Name,
                    Quantity = item.Quantity,
                    UnitPrice = item.CatalogItem.Price,
                    ImageUrl = uriComposerService.ComposeImageUri(item?.CatalogItem?
                   .CatalogItemImages?.FirstOrDefault()?.Src ?? ""),

                }).ToList(),
            };

        }

        public bool RemoveItemFromBasket(int ItemId)
        {
            var item = context.BasketItems.SingleOrDefault(p => p.Id == ItemId);
            context.BasketItems.Remove(item);
            context.SaveChanges();
            return true;
        }

        public bool SetQuantities(int itemId, int quantity)
        {
            var item = context.BasketItems.SingleOrDefault(p => p.Id == itemId);
            item.SetQuantity(quantity);
            context.SaveChanges();
            return true;
        }



        private BasketDto CreateBasketForUser(string BuyerId)
        {
            Basket basket = new Basket(BuyerId);
            context.Baskets.Add(basket);
            context.SaveChanges();
            return new BasketDto
            {
                BuyerId = basket.BuyerId,
                Id = basket.Id,
            };
        }
        public void TransferBasket(string anonymousId, string UserId)
        {
            var anonymousBasket = context.Baskets
                .Include(p => p.Items)
                .Include(p=>p.AppliedDiscount)
                .SingleOrDefault(p => p.BuyerId == anonymousId);
            if (anonymousBasket == null) return;
            var userBasket = context.Baskets.SingleOrDefault(p => p.BuyerId == UserId);
            if (userBasket == null)
            {
                userBasket = new Basket(UserId);
                context.Baskets.Add(userBasket);
            }
            foreach (var item in anonymousBasket.Items)
            {
                userBasket.AddItem(item.CatalogItemId, item.Quantity, item.UnitPrice);
            }

            if (anonymousBasket.AppliedDiscount != null)
            {
                userBasket.ApplyDiscountCode(anonymousBasket.AppliedDiscount);
            }

            context.Baskets.Remove(anonymousBasket);
            context.SaveChanges();
        }

    }

    public class BasketDto
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItemDto> Items { get; set; } = new List<BasketItemDto>();
        public int DiscountAmount { get; set; }

        public int Total()
        {
            if (Items.Count > 0)
            {
                int total = Items.Sum(p => p.UnitPrice * p.Quantity);
                total -= DiscountAmount;
                return total;
            }
            return 0;
        }
        public int TotalWithOutDiescount()
        {
            if (Items.Count > 0)
            {
                int total = Items.Sum(p => p.UnitPrice * p.Quantity);
                return total;
            }
            return 0;
        }
    }

    public class BasketItemDto
    {
        public int Id { get; set; }
        public int CatalogItemid { get; set; }
        public string CatalogName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    }

}
