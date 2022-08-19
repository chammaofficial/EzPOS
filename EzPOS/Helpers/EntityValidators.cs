using System.Linq;

namespace EzPOS.Helpers
{
    public static class EntityValidators
    {

        public static bool Validate(this Models.Employee emp)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(emp).GetValidationResult().ValidationErrors;
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

        public static bool Validate(this Models.Supplier sup)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(sup).GetValidationResult().ValidationErrors;
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

        public static bool Validate(this Models.Customer cus)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(cus).GetValidationResult().ValidationErrors;
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

        public static bool Validate(this Models.Brand brand)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(brand).GetValidationResult().ValidationErrors;
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

        public static bool Validate(this Models.Category category)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(category).GetValidationResult().ValidationErrors;
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

        public static bool Validate(this Models.ProductStatusCode code)
        {
            using (var context = new POSContext())
            {
                var errors = context.Entry(code).GetValidationResult().ValidationErrors;
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
