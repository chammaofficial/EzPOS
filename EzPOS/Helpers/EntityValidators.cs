using System.Linq;
using System.Runtime.Remoting.Contexts;
using EzPOS.Models;
using EzPOS.Models.Contacts;
using EzPOS.Models.Products;
using EzPOS.Models.Settings;

namespace EzPOS.Helpers
{
    public static class EntityValidators
    {
        public static bool Validate(this Employee entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this Supplier entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this Customer entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this Brand entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this Category entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this Branch entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this BusinessSetting entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this PurchaseOrder entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this PurchaseOrderDetail entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this ProductStatusCode entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool Validate(this Product entity)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(entity).GetValidationResult().ValidationErrors;
                if (errors.Any())
                {
                    Alerts.Error(errors.First().ErrorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
