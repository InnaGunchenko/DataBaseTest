using System;
using System.Collections.Generic;

namespace DBTestsAppProj.Models.Base
{
    public static class EntityNaming
    {
        public static readonly string BrandEntity = "Brand";

        public static readonly IDictionary<string, Type> Entities;

        static EntityNaming()
        {
            Entities = new Dictionary<string, Type>()
            {
                [BrandEntity] = typeof(Brand),
            };
        }
    }
}
