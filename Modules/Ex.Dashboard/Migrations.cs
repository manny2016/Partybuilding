using System;
using System.Collections.Generic;
using System.Data;
using Orchard;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Ex.Dashboard
{
    public class Migrations : DataMigrationImpl
    {
        private readonly IOrchardServices OrchardServices;
        public Migrations(IOrchardServices services)
        {
            this.OrchardServices = services;
        }
        public int Create()
        {

           // SchemaBuilder.CreateTable("");
            return 1;
        }
    }
}