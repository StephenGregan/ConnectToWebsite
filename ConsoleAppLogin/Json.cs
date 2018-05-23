// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ConsoleAppLogin;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace ConsoleAppLogin
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Microsoft.Azure.Search;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Json
    {
        public partial class Welcome
        {
            [System.ComponentModel.DataAnnotations.Key]
            [IsFilterable]
            [JsonProperty("id")]
            public long Id { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("uuid")]
            public string Uuid { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("versionValue")]
            public long VersionValue { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("company.id")]
            public long CompanyId { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("createdBy")]
            public string CreatedBy { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("createdDate")]
            public string CreatedDate { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("lastModifiedBy")]
            public string LastModifiedBy { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("lastModifiedDate")]
            public string LastModifiedDate { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("name")]
            public string Name { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("accountingReference")]
            public object AccountingReference { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("parentAccountingReference")]
            public object ParentAccountingReference { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("contactName")]
            public object ContactName { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("website")]
            public object Website { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("notes")]
            public object Notes { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("paymentTerms")]
            public object PaymentTerms { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("paymentDaysDue")]
            public object PaymentDaysDue { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("purchaseOrderNumber")]
            public object PurchaseOrderNumber { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("accountingSickLeaveCode")]
            public object AccountingSickLeaveCode { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("billingMethod.id")]
            public string BillingMethodId { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("number")]
            public string Number { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("address")]
            public string Address { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("email")]
            public string Email { get; set; }

            //[JsonProperty("numbers")]
            //public Number[] Numbers { get; set; }

            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
            [JsonProperty("addresses")]
            public object[] Addresses { get; set; }
        }
    }
}
         
        

