using CandyEShopData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandyEShopData
{
    public interface IItemsAsset
    {
        IEnumerable<Item> getAll();
        void addNewItem(Item newItem);
        Item getById(int id);
        string getPath(int id);
        string getName(int id);
        string getDescription(int id);
        double getPrice(int id);
        double getWeight(int id);
        string getType(int id);
    }
}
