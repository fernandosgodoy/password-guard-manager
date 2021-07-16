using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace PGM.InfraHelpers.ModelHelpers
{
    public static class EntityModelValidationHelper
    {

        public static bool CheckHasDefinedPrimaryKey(this Type source)
        {
            return source.GetRuntimeProperties()
                 .Where(pi => pi.PropertyType == typeof(int)
                    && pi.GetCustomAttributes<KeyAttribute>(true).Any()).Any();
        }

    }
}
