/*
 * Budgeting Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// PurchaseCategoryCreate
    /// </summary>
    [DataContract(Name = "PurchaseCategoryCreate")]
    public partial class PurchaseCategoryCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategoryCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurchaseCategoryCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCategoryCreate" /> class.
        /// </summary>
        /// <param name="categoryName">Name of the purchase category. (required).</param>
        /// <param name="categoryDescription">categoryDescription.</param>
        public PurchaseCategoryCreate(string categoryName = default(string), string categoryDescription = default(string))
        {
            // to ensure "categoryName" is required (not null)
            if (categoryName == null)
            {
                throw new ArgumentNullException("categoryName is a required property for PurchaseCategoryCreate and cannot be null");
            }
            this.CategoryName = categoryName;
            this.CategoryDescription = categoryDescription;
        }

        /// <summary>
        /// Name of the purchase category.
        /// </summary>
        /// <value>Name of the purchase category.</value>
        [DataMember(Name = "category_name", IsRequired = true, EmitDefaultValue = true)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name = "category_description", EmitDefaultValue = true)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PurchaseCategoryCreate {\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // CategoryDescription (string) maxLength
            if (this.CategoryDescription != null && this.CategoryDescription.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CategoryDescription, length must be less than 500.", new [] { "CategoryDescription" });
            }

            yield break;
        }
    }

}