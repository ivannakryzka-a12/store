using Store.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Services
{
    /// <summary>
    /// Відповідає за оформлення покупки та роботу з чеком.
    /// </summary>
    public class CheckManager
    {
        private readonly StoreManager _storeManager;

        public CheckManager(StoreManager storeManager)
        {
            _storeManager = storeManager;
        }

        public Check CreateCheck()
        {
            return new Check();
        }

        /// <summary>
        /// Додає товар у чек та списує його зі складу.
        /// </summary>
        public bool AddProductToCheck(Check check, string productName, int quantity)
        {
            var product = _storeManager.GetByName(productName);

            if (product == null)
                return false;

            if (quantity <= 0)
                return false;

            if (product.Quantity < quantity)
                return false;

            product.Quantity -= quantity;

            check.Items.Add(new CheckItem
            {
                ProductName = product.Name,
                Price = product.Price,
                Count = quantity
            });

            return true;
        }

        public decimal GetCheckTotal(Check check)
        {
            return check.TotalAmount();
        }

        /// <summary>
        /// Завершує оформлення чека (резерв для розширення функціоналу).
        /// </summary>
        public void FinishCheck(Check check)
        {
            // додати логіку друку чека або збереження історії покупок
        }
    }
}

