using CandyEShopData;
using CandyEShopData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShopServices
{
    public class ItemAssetService : IItemsAsset
    {
        private EShopContext _context;

        public ItemAssetService(EShopContext context)
        {
            _context = context;
        }

        public void addNewItem(Item newItem)
        {
            _context.Add(newItem);
            _context.SaveChanges();
        }

        public IEnumerable<Item> getAll()
        {
            return _context.ItemsTable;
        }

        public Item getById(int id)
        {
            return _context.ItemsTable.FirstOrDefault(asset=> asset.Id == id);
        }

        public string getDescription(int id)
        {
            return _context.ItemsTable.FirstOrDefault(asset => asset.Id == id).Description;
        }

        public string getName(int id)
        {
            return _context.ItemsTable.FirstOrDefault(asset => asset.Id == id).Name;
        }

        public string getPath(int id)
        {
            return _context.ItemsTable.FirstOrDefault(asset => asset.Id == id).ImgPath;
        }

        public double getPrice(int id)
        {
            return _context.ItemsTable.FirstOrDefault(asset => asset.Id == id).price;
        }

        public string getType(int id)
        {
            return _context.ItemsTable.FirstOrDefault(asset => asset.Id == id).type;
        }

        public double getWeight(int id)
        {
            return _context.ItemsTable.FirstOrDefault(asset => asset.Id == id).weight;
        }
    }
}
