using System.Data.Entity.Validation;
using System.Linq;
using System.Text;

namespace Snippr.Domain.Helpers
{
    public static class DbEntityValidationExceptionHelper
    {
        public static DbEntityValidationException ConvertToReadableException(DbEntityValidationException dbValidationException)
        {
            var stringBuilder = new StringBuilder();

            foreach (var validationError in dbValidationException.EntityValidationErrors.SelectMany(entityValidationErrors => entityValidationErrors.ValidationErrors))
                stringBuilder.Append($"A validation exception occured for property {validationError.PropertyName} with message: {validationError.ErrorMessage}");

            return new DbEntityValidationException(stringBuilder.ToString(), dbValidationException);
        }
    }
}
