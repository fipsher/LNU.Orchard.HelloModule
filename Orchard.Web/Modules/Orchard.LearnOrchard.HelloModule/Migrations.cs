using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
//using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.LearnOrchard.HelloModule.Models;

namespace Orchard.LearnOrchard.HelloModule {
    public class Migrations : DataMigrationImpl {

        public int Create() {
   //         ContentDefinitionManager.AlterTypeDefinition(
   //"HelloModelWidget", cfg => cfg
   //  .WithSetting("Stereotype", "Widget")
   //  .WithPart(typeof(HelloModel).Name)
   //  .WithPart(typeof(CommonPart).Name)
   //  .WithPart(typeof(WidgetPart).Name));
            return 1;
        }
    }
}